using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using connquery;

namespace SQL
{
    public partial class Form1 : Form
    {
        #region 起始

        Thread SQL_status, SQL_flash;
        string cmd = "",log_unit,log_led;
        bool loginOK = true;
        private void Form1_Load(object sender, EventArgs e)
        {
            Form.CheckForIllegalCrossThreadCalls = false;
            if (loginOK == false)
            {
                login login = new login();
                login.ShowDialog();
            }
            toolStripStatusLabel1.Text = "IP : " + new connquery.connquery().mysqlip();

            //Gridview 指標欄位寬度
            grid_lora.RowHeadersWidth = 30;
            grid_log.RowHeadersWidth = 30;

            //DataTimePicker 預設時間格式
            tx_time.Format = DateTimePickerFormat.Custom;
            tx_time.CustomFormat = "yyyy-MM-dd HH:mm:ss";

            editbtn.Enabled = false;
            ADDbtn.Enabled = false;
            DELbtn.Enabled = false;
            CLbtn.Enabled = false;

            combox_unitdata();
            combox_leddata();
            editlog();
            gridcolname();
            LED();
        }

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region GridView
        private void grid_lora_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tx_time.Text = grid_lora.CurrentRow.Cells["time"].Value.ToString();
            tx_unit.Text = grid_lora.CurrentRow.Cells["unit"].Value.ToString();
            tx_led_data.Text = grid_lora.CurrentRow.Cells["led_status"].Value.ToString();
            log_unit = tx_unit.Text.ToString();
            log_led = tx_led_data.Text.ToString();
        }

        private void grid_lora_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //目前指標欄位
            //grid_lora.CurrentRow.Cells["NO"].Value = grid_lora.CurrentCell.RowIndex + 1;
        }

        private void grid_lora_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tx_time.Text = grid_lora.CurrentRow.Cells["time"].Value.ToString();
            tx_unit.Text = grid_lora.CurrentRow.Cells["unit"].Value.ToString();
            tx_led_data.Text = grid_lora.CurrentRow.Cells["led_status"].Value.ToString();
        }
        #endregion

        #region 按鈕

        //查詢按鈕
        private void querybtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("query");
            cmd = @"SELECT LORA.TIME,LORA_UNIT.UNIT,LED_DATA.LED_STATUS,LORA.ID
                    FROM LORA_UNIT 
                    JOIN LORA ON LORA_UNIT.LORA_IP = LORA.LORA_IP
                    JOIN LED_DATA ON LORA.LED_DATA = LED_DATA.LED_DATA";

            if (tx_unit.Text != "" && tx_led_data.Text != "")
                cmd = String.Format(cmd + @" WHERE LORA.LORA_IP = '{0}' AND LORA.LED_DATA = '{1}'"
                                           , tx_unit.SelectedValue.ToString(), tx_led_data.SelectedValue.ToString());
            else if (tx_unit.Text != "" && tx_led_data.Text == "")
                cmd = String.Format(cmd + @" WHERE LORA.LORA_IP = '{0}'"
                                           , tx_unit.SelectedValue.ToString());
            else if (tx_unit.Text == "" && tx_led_data.Text != "")
                cmd = String.Format(cmd + @" WHERE LORA.LED_DATA = '{0}'"
                                           , tx_led_data.SelectedValue.ToString());

            cmd = cmd + @" ORDER BY LORA.TIME DESC LIMIT 5000";

            DataTable dt = new connquery.connquery().conndt(cmd);
            if (dt.Rows.Count != 0)
            {
                /*for (int i = 0; i < dt.Rows.Count; i++)
                    dt.Rows[i]["NO"] = i + 1;*/

                grid_lora.DataSource = dt;
                grid_lora.Columns["TIME"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
                gridcolname();
            }
            else
            {
                grid_lora.DataSource = null; 
                MessageBox.Show("查無資料", "錯誤");
            }

            if (grid_lora.DataSource != null)
                tx_time.Text = grid_lora.Rows[0].Cells["time"].Value.ToString();

            ADDbtn.Enabled = true;
            DELbtn.Enabled = true;
            CLbtn.Enabled = true;
            editbtn.Enabled = true;
        }

        //查詢記錄
        private void button_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("query");
            String[] tag = (sender as Button).Tag.ToString().Split(',');
            tx_unit.SelectedValue = tag[0];
            cmd = String.Format(@"SELECT LORA.TIME,LORA_UNIT.UNIT,LED_DATA.LED_STATUS,LORA.ID
                                              FROM LORA_UNIT 
                                              JOIN LORA ON LORA_UNIT.LORA_IP = LORA.LORA_IP
                                              JOIN LED_DATA ON LORA.LED_DATA = LED_DATA.LED_DATA
                                              WHERE LORA.LORA_IP = '{0}' ORDER BY LORA.TIME DESC LIMIT 5000"
                                               , tag[0].ToString());

            DataTable dt = new connquery.connquery().conndt(cmd);
            if (dt.Rows.Count != 0)
            {
                grid_lora.DataSource = dt;
                grid_lora.Columns["TIME"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
                gridcolname();
            }

            tx_time.Text = grid_lora.Rows[0].Cells["time"].Value.ToString();

            ADDbtn.Enabled = true;
            DELbtn.Enabled = true;
            CLbtn.Enabled = true;
            editbtn.Enabled = true;
        }

        //修改按鈕
        private void editbtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("修改確認", "修改確認", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                cmd = String.Format(@"UPDATE LORA SET LORA_IP = '{0}' , LED_DATA = '{1}' , TIME = '{2}' WHERE id = {3}"
                                    , tx_unit.SelectedValue, tx_led_data.SelectedValue, tx_time.Text, grid_lora.CurrentRow.Cells["id"].Value);
                new connquery.connquery().connsql(cmd);

                cmd = String.Format(@"INSERT INTO LOG(TIME, ACTION, USER, LORA_ID, BEFOR, AFTER) VALUES ('{0}','修改','{1}','{2}','{3},{4}','{5},{6}')"
                                   , string.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now), toolStripStatusLabel2.Text.Split(':')[1].Trim()
                                   , grid_lora.CurrentRow.Cells["id"].Value, log_unit, log_led, tx_unit.Text, tx_led_data.Text);
                new connquery.connquery().connsql(cmd);

                MessageBox.Show(grid_lora.CurrentRow.Cells["id"].Value + " 修改成功");
                editlog();
            }
        }

        //新增按鈕
        private void ADDbtn_Click(object sender, EventArgs e)
        {
            string savetime = string.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now);
            cmd = String.Format(@"INSERT INTO LORA(TIME, LORA_IP, LED_DATA) VALUES ('{0}','{1}','{2}')"
                                , savetime, tx_unit.SelectedValue, tx_led_data.SelectedValue);
            new connquery.connquery().connsql(cmd);

            cmd = String.Format(@"SELECT ID FROM LORA WHERE LORA.TIME = '{0}'"
                               , savetime);
            string insertid = new connquery.connquery().connScalar(cmd);

            cmd = String.Format(@"INSERT INTO LOG(TIME, ACTION, USER, LORA_ID, BEFOR ,AFTER) VALUES ('{0}','新增','{1}','{2}','N/A','{3},{4}')"
                               , savetime, toolStripStatusLabel2.Text.Split(':')[1].Trim(), insertid, tx_unit.Text, tx_led_data.Text);
            new connquery.connquery().connsql(cmd);

            MessageBox.Show(tx_time.Text + " " + tx_unit.Text + " " + tx_led_data.Text + " 新增成功");
            editlog();
        }

        //刪除按鈕
        private void DELbtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(String.Format("確定是否刪除 NO : {0}", grid_lora.CurrentRow.Cells["id"].Value)
                                                        , "刪除確認", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cmd = String.Format(@"DELETE FROM LORA WHERE id = {0}"
                                    , grid_lora.CurrentRow.Cells["id"].Value);
                new connquery.connquery().connsql(cmd);

                cmd = String.Format(@"INSERT INTO LOG(TIME, ACTION, USER, LORA_ID, BEFOR ,AFTER) VALUES ('{0}','刪除','{1}','{2}','{3},{4}','N/A')"
                                   , string.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now), toolStripStatusLabel2.Text.Split(':')[1].Trim()
                                   , grid_lora.CurrentRow.Cells["id"].Value, tx_unit.Text, tx_led_data.Text);
                new connquery.connquery().connsql(cmd);

                MessageBox.Show(tx_time.Text + " " + tx_unit.Text + " " + tx_led_data.Text + " 刪除成功");
                querybtn_Click(sender, e);
                editlog();
            }
        }

        //清空按鈕
        private void CLbtn_Click(object sender, EventArgs e)
        {
            grid_lora.DataSource = null; 
            editbtn.Enabled = false;
            ADDbtn.Enabled = false;
            DELbtn.Enabled = false;
            CLbtn.Enabled = false;
        }

        #endregion

        #region 功能紐

        //功能列-結束
        private void ENDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abort();
            Application.Exit();
        }

        //功能列-回登入畫面
        private void LOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abort();
            login login = new login();
            login.Show();
            this.Dispose();
        }
        #endregion

        #region 副程式

        //獲取設備名稱
        private void combox_unitdata()
        {
            cmd = @"SELECT LORA_IP,UNIT FROM LORA_UNIT";
            DataSet ds = new connquery.connquery().connds(cmd);
            tx_unit.DisplayMember = "unit";
            tx_unit.ValueMember = "lora_ip";
            tx_unit.DataSource = ds.Tables[0];
        }

        //獲取設備狀態
        private void combox_leddata()
        {
            cmd = @"SELECT DISTINCT LED_STATUS,LED_DATA FROM LED_DATA GROUP BY LED_STATUS";
            DataSet ds = new connquery.connquery().connds(cmd);
            tx_led_data.DisplayMember = "led_status";
            tx_led_data.ValueMember = "led_data";
            tx_led_data.DataSource = ds.Tables[0];
        }

        //log
        private void editlog()
        {
            cmd = @"SELECT ID,TIME,ACTION,USER,LORA_ID,BEFOR,AFTER FROM LOG ORDER BY ID DESC";
            DataTable dt = new connquery.connquery().conndt(cmd);
            grid_log.DataSource = dt;
            grid_log.Columns["TIME"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
        }

        //獲取 GridView 欄位名稱
        private void gridcolname()
        {
            cmd = String.Format(@"SELECT FRM_NAME, FRM_GRID, NAME_E, NAME_C, ORDERN, LENGTH 
                                  FROM GRIDCOLNAME WHERE FRM_NAME = '{0}'"
                                     , this.GetType().Name);
            DataTable dt = new connquery.connquery().conndt(cmd);

            //抓取 tabControl1 內所有元件
            foreach (Control element in this.tabControl1.Controls)
                //抓取 element 內所有物件
                foreach (object item in element.Controls)
                    //判斷物件是否為 DataGridView
                    if (item is DataGridView)
                        //抓取 DataTable 內所有資料
                        foreach (DataRow dtfield in dt.Rows)
                            //判斷 DataGridView 名稱是否等於 dtfield "FRM_GRID" 的名稱
                            if (((DataGridView)item).Name == dtfield["FRM_GRID"].ToString())
                                //抓取 DataGridView 欄位所有名稱
                                foreach (DataGridViewColumn gridfield in ((DataGridView)item).Columns)
                                    //判斷 DataGridView 欄位名稱是否等於 DataTable "name_e" 的欄位名稱
                                    if (gridfield.HeaderText.ToString() == dtfield["name_e"].ToString())
                                    {
                                        ((DataGridView)item).Columns[gridfield.HeaderText.ToString()].DisplayIndex = Convert.ToInt32(dtfield["ordern"]) - 1;
                                        ((DataGridView)item).Columns[gridfield.HeaderText.ToString()].Width = Convert.ToInt32(dtfield["length"]);
                                        ((DataGridView)item).Columns[gridfield.HeaderText.ToString()].HeaderText = dtfield["name_c"].ToString();
                                    }
        }

        private void LED()
        {
            this.panel2.Controls.Clear();

            string SQL_t0cmd = @"SELECT LORA_STATUS.LORA_IP, LORA_STATUS.TIME, LORA_UNIT.UNIT, LORA_STATUS.LED_DATA 
                    FROM LORA_STATUS 
                    JOIN LORA_UNIT ON LORA_STATUS.LORA_IP = LORA_UNIT.LORA_IP";
            DataTable dt = new connquery.connquery().conndt(SQL_t0cmd);

            int top = 5;
            int btnWidth = this.panel2.Size.Width;
            int btnhei = this.panel2.Size.Height / (dt.Rows.Count + 1);
            string btnname = "unit_status_";
            Color[] backcolor = new Color[] { Color.Red, Color.Yellow, Color.LimeGreen, SystemColors.Control };
            Color[] textcolor = new Color[] { Color.Black, Color.White };
            List<Button> btn = new List<Button>();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Button button = new Button();
                button.Left = 0; //靠左位置
                button.Top = top; //靠上位置
                button.Height = btnhei; //高度
                button.Width = btnWidth - 90; //寬度
                button.ForeColor = textcolor[0]; //字體顏色
                button.Font = new Font("微軟正黑體", 10); //字型
                button.FlatStyle = FlatStyle.Flat; //造型
                button.Anchor = AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left; //描點
                button.Text = String.Format("{0} {1}", Convert.ToDateTime(dt.Rows[i]["TIME"]).ToString("yyyy/MM/dd HH:mm:ss"), dt.Rows[i]["UNIT"].ToString()); //內容
                button.Name = btnname + i; //名稱
                button.TextAlign = ContentAlignment.MiddleCenter;//文字置中
                button.Click += new EventHandler(button_Click); //加入事件
                button.Tag = dt.Rows[i]["LORA_IP"].ToString() + "," + dt.Rows[i]["LED_DATA"].ToString(); //Tag
                this.panel2.Controls.Add(button); //加入新按鈕
                btn.Add(button);

                int led_data = (int)dt.Rows[i]["LED_DATA"];

                //色彩
                switch (led_data)
                {
                    case 0: button.BackColor = backcolor[3]; break;
                    case 1: button.BackColor = backcolor[2]; break;
                    case 2: button.BackColor = backcolor[1]; break;
                    case 3: button.BackColor = backcolor[1]; break;
                    case 4: button.BackColor = backcolor[0]; break;
                    case 5: button.BackColor = backcolor[0]; break;
                    case 6: button.BackColor = backcolor[0]; break;
                    case 7: button.BackColor = backcolor[0]; break;
                }

                int ledw = button.Width;
                string led_Binary = Convert.ToString(led_data, 2).PadLeft(3, '0');
                List<Button> led_btn = new List<Button>();
                for (int j = 0; j < 3; j++)
                {
                    Button led = new Button();
                    led.FlatStyle = FlatStyle.Flat;
                    led.Anchor = AnchorStyles.Right | AnchorStyles.Top;
                    led.Left = ledw + 2;
                    led.Top = button.Top;
                    led.Height = button.Height;
                    led.Width = button.Height;
                    led.Enabled = false;
                    led.Name = btnname + i + "_" + j;
                    this.panel2.Controls.Add(led);
                    ledw += led.Width + 2;
                    switch (j)
                    {
                        case 2:
                            if (led_Binary[j] == '1') led.BackColor = backcolor[2];
                            else led.BackColor = backcolor[3];
                            break;
                        case 1:
                            if (led_Binary[j] == '1') led.BackColor = backcolor[1];
                            else led.BackColor = backcolor[3];
                            break;
                        case 0:
                            if (led_Binary[j] == '1') led.BackColor = backcolor[0];
                            else led.BackColor = backcolor[3];
                            break;
                    }
                    led_btn.Add(led);
                }
                mylist.Add(led_btn);
                top += button.Height + 1;
            }

//            string btn_status_sql = @"SELECT COUNT(LORA_UNIT.UNIT) 
//                            FROM LORA_STATUS 
//                            JOIN LORA_UNIT ON LORA_STATUS.LORA_IP = LORA_UNIT.LORA_IP";
//            string btn_status_count = new connquery.connquery().connScalar(btn_status_sql);

            //更新狀態
            SQL_status = new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(10000);
                    dt = new connquery.connquery().conndt(SQL_t0cmd);
                    int btncount = 0;
                    foreach (Button item in btn)
                    {
                        item.Text = String.Format("{0} {1}", Convert.ToDateTime(dt.Rows[btncount]["TIME"]).ToString("yyyy/MM/dd HH:mm:ss")
                                                           , dt.Rows[btncount]["UNIT"].ToString());
                        switch ((int)dt.Rows[btncount]["LED_DATA"])
                        {
                            case 1: item.BackColor = backcolor[2]; break;
                            case 2: item.BackColor = backcolor[1]; break;
                            case 3: item.BackColor = backcolor[1]; break;
                            case 4: item.BackColor = backcolor[0]; break;
                            case 5: item.BackColor = backcolor[0]; break;
                            case 6: item.BackColor = backcolor[0]; break;
                            case 7: item.BackColor = backcolor[0]; break;
                            default: item.BackColor = backcolor[3]; break;
                        }

                        btncount++;
                    }

                    //foreach (List<Button> d in mylist)
                    //    foreach (Button c in d)
                    //        debug.AppendText(c.Name + "\n");

                    for (int i = 0; i < mylist.Count; i++)
                    {
                        int led_data = (int)dt.Rows[i]["LED_DATA"];
                        string led_Binary = Convert.ToString(led_data, 2).PadLeft(3, '0');
                        for (int j = 0; j < mylist[i].Count; j++)
                            switch (j)
                            {
                                case 2:
                                    if (led_Binary[j] == '1') mylist[i][j].BackColor = backcolor[2];
                                    else mylist[i][j].BackColor = backcolor[3];
                                    break;
                                case 1:
                                    if (led_Binary[j] == '1') mylist[i][j].BackColor = backcolor[1];
                                    else mylist[i][j].BackColor = backcolor[3];
                                    break;
                                case 0:
                                    if (led_Binary[j] == '1') mylist[i][j].BackColor = backcolor[0];
                                    else mylist[i][j].BackColor = backcolor[3];
                                    break;
                            }
                    }
                }
            });
            SQL_status.Start();

            //閃爍
            SQL_flash = new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(1000);
                    foreach (Button item in btn)
                    {
                        if (item.BackColor == backcolor[0])
                            item.BackColor = Color.White;
                        else if (item.BackColor == Color.White)
                            item.BackColor = backcolor[0];
                    }
                }
            });
            SQL_flash.Start();
        }

        private void abort()
        {
            SQL_status.Abort();
            SQL_flash.Abort(); 
        }

        #endregion

        #region 其他

        //關閉程式
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            abort();
            Application.Exit();
        }

        //回傳值
        public string TextBoxMsg
        {
            set { toolStripStatusLabel2.Text = value; }
            get { return toolStripStatusLabel2.Text; }
        }

        //二維陣列
        private List<List<Button>> mylist = new List<List<Button>>();

        #endregion
    }
}

namespace SQL
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.CLbtn = new System.Windows.Forms.Button();
            this.DELbtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ADDbtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.UNIT_STATUS = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.query = new System.Windows.Forms.TabPage();
            this.grid_lora = new System.Windows.Forms.DataGridView();
            this.tx_time = new System.Windows.Forms.DateTimePicker();
            this.tx_led_data = new System.Windows.Forms.ComboBox();
            this.tx_unit = new System.Windows.Forms.ComboBox();
            this.lb_led_data = new System.Windows.Forms.Label();
            this.lb_unit = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.TabPage();
            this.grid_log = new System.Windows.Forms.DataGridView();
            this.De = new System.Windows.Forms.TabPage();
            this.debug = new System.Windows.Forms.RichTextBox();
            this.querybtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ENDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.UNIT_STATUS.SuspendLayout();
            this.query.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_lora)).BeginInit();
            this.log.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_log)).BeginInit();
            this.De.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CLbtn);
            this.panel1.Controls.Add(this.DELbtn);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.ADDbtn);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.querybtn);
            this.panel1.Controls.Add(this.editbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 412);
            this.panel1.TabIndex = 0;
            // 
            // CLbtn
            // 
            this.CLbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CLbtn.Location = new System.Drawing.Point(333, 5);
            this.CLbtn.Name = "CLbtn";
            this.CLbtn.Size = new System.Drawing.Size(75, 23);
            this.CLbtn.TabIndex = 18;
            this.CLbtn.Text = "清空";
            this.CLbtn.UseVisualStyleBackColor = true;
            this.CLbtn.Click += new System.EventHandler(this.CLbtn_Click);
            // 
            // DELbtn
            // 
            this.DELbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DELbtn.Location = new System.Drawing.Point(171, 5);
            this.DELbtn.Name = "DELbtn";
            this.DELbtn.Size = new System.Drawing.Size(75, 23);
            this.DELbtn.TabIndex = 17;
            this.DELbtn.Text = "刪除";
            this.DELbtn.UseVisualStyleBackColor = true;
            this.DELbtn.Click += new System.EventHandler(this.DELbtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 387);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(736, 25);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(22, 20);
            this.toolStripStatusLabel1.Text = "IP";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(43, 20);
            this.toolStripStatusLabel2.Text = "USER";
            // 
            // ADDbtn
            // 
            this.ADDbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ADDbtn.Location = new System.Drawing.Point(90, 5);
            this.ADDbtn.Name = "ADDbtn";
            this.ADDbtn.Size = new System.Drawing.Size(75, 23);
            this.ADDbtn.TabIndex = 14;
            this.ADDbtn.Text = "新增";
            this.ADDbtn.UseVisualStyleBackColor = true;
            this.ADDbtn.Click += new System.EventHandler(this.ADDbtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.UNIT_STATUS);
            this.tabControl1.Controls.Add(this.query);
            this.tabControl1.Controls.Add(this.log);
            this.tabControl1.Controls.Add(this.De);
            this.tabControl1.Location = new System.Drawing.Point(3, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(730, 352);
            this.tabControl1.TabIndex = 13;
            // 
            // UNIT_STATUS
            // 
            this.UNIT_STATUS.Controls.Add(this.panel2);
            this.UNIT_STATUS.Location = new System.Drawing.Point(4, 22);
            this.UNIT_STATUS.Name = "UNIT_STATUS";
            this.UNIT_STATUS.Size = new System.Drawing.Size(722, 326);
            this.UNIT_STATUS.TabIndex = 3;
            this.UNIT_STATUS.Text = "設備狀態";
            this.UNIT_STATUS.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(722, 326);
            this.panel2.TabIndex = 0;
            // 
            // query
            // 
            this.query.Controls.Add(this.grid_lora);
            this.query.Controls.Add(this.tx_time);
            this.query.Controls.Add(this.tx_led_data);
            this.query.Controls.Add(this.tx_unit);
            this.query.Controls.Add(this.lb_led_data);
            this.query.Controls.Add(this.lb_unit);
            this.query.Controls.Add(this.lb_time);
            this.query.Location = new System.Drawing.Point(4, 22);
            this.query.Name = "query";
            this.query.Padding = new System.Windows.Forms.Padding(3);
            this.query.Size = new System.Drawing.Size(722, 326);
            this.query.TabIndex = 0;
            this.query.Text = "歷史查詢";
            this.query.UseVisualStyleBackColor = true;
            // 
            // grid_lora
            // 
            this.grid_lora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_lora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_lora.Location = new System.Drawing.Point(5, 29);
            this.grid_lora.Name = "grid_lora";
            this.grid_lora.RowTemplate.Height = 24;
            this.grid_lora.Size = new System.Drawing.Size(711, 291);
            this.grid_lora.TabIndex = 0;
            this.grid_lora.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_lora_CellContentClick);
            this.grid_lora.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_lora_CellDoubleClick);
            this.grid_lora.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.grid_lora_EditingControlShowing);
            // 
            // tx_time
            // 
            this.tx_time.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.tx_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tx_time.Location = new System.Drawing.Point(49, 2);
            this.tx_time.Name = "tx_time";
            this.tx_time.Size = new System.Drawing.Size(139, 22);
            this.tx_time.TabIndex = 12;
            // 
            // tx_led_data
            // 
            this.tx_led_data.FormattingEnabled = true;
            this.tx_led_data.Items.AddRange(new object[] {
            ""});
            this.tx_led_data.Location = new System.Drawing.Point(416, 3);
            this.tx_led_data.Name = "tx_led_data";
            this.tx_led_data.Size = new System.Drawing.Size(64, 20);
            this.tx_led_data.TabIndex = 11;
            // 
            // tx_unit
            // 
            this.tx_unit.FormattingEnabled = true;
            this.tx_unit.Items.AddRange(new object[] {
            ""});
            this.tx_unit.Location = new System.Drawing.Point(265, 3);
            this.tx_unit.Name = "tx_unit";
            this.tx_unit.Size = new System.Drawing.Size(73, 20);
            this.tx_unit.TabIndex = 10;
            // 
            // lb_led_data
            // 
            this.lb_led_data.AutoSize = true;
            this.lb_led_data.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_led_data.Location = new System.Drawing.Point(344, 3);
            this.lb_led_data.Name = "lb_led_data";
            this.lb_led_data.Size = new System.Drawing.Size(73, 20);
            this.lb_led_data.TabIndex = 6;
            this.lb_led_data.Text = "燈號狀態";
            // 
            // lb_unit
            // 
            this.lb_unit.AutoSize = true;
            this.lb_unit.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_unit.Location = new System.Drawing.Point(190, 3);
            this.lb_unit.Name = "lb_unit";
            this.lb_unit.Size = new System.Drawing.Size(73, 20);
            this.lb_unit.TabIndex = 5;
            this.lb_unit.Text = "設備名稱";
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_time.Location = new System.Drawing.Point(6, 3);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(41, 20);
            this.lb_time.TabIndex = 4;
            this.lb_time.Text = "時間";
            // 
            // log
            // 
            this.log.Controls.Add(this.grid_log);
            this.log.Location = new System.Drawing.Point(4, 22);
            this.log.Name = "log";
            this.log.Padding = new System.Windows.Forms.Padding(3);
            this.log.Size = new System.Drawing.Size(722, 326);
            this.log.TabIndex = 1;
            this.log.Text = "修改記錄";
            this.log.UseVisualStyleBackColor = true;
            // 
            // grid_log
            // 
            this.grid_log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_log.Location = new System.Drawing.Point(3, 3);
            this.grid_log.Name = "grid_log";
            this.grid_log.RowTemplate.Height = 24;
            this.grid_log.Size = new System.Drawing.Size(716, 320);
            this.grid_log.TabIndex = 19;
            // 
            // De
            // 
            this.De.Controls.Add(this.debug);
            this.De.Location = new System.Drawing.Point(4, 22);
            this.De.Name = "De";
            this.De.Padding = new System.Windows.Forms.Padding(3);
            this.De.Size = new System.Drawing.Size(722, 326);
            this.De.TabIndex = 2;
            this.De.Text = "DeBug";
            this.De.UseVisualStyleBackColor = true;
            // 
            // debug
            // 
            this.debug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debug.Location = new System.Drawing.Point(3, 3);
            this.debug.Name = "debug";
            this.debug.ReadOnly = true;
            this.debug.Size = new System.Drawing.Size(716, 320);
            this.debug.TabIndex = 1;
            this.debug.Text = "";
            // 
            // querybtn
            // 
            this.querybtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.querybtn.Location = new System.Drawing.Point(9, 5);
            this.querybtn.Name = "querybtn";
            this.querybtn.Size = new System.Drawing.Size(75, 23);
            this.querybtn.TabIndex = 7;
            this.querybtn.Text = "查詢";
            this.querybtn.UseVisualStyleBackColor = true;
            this.querybtn.Click += new System.EventHandler(this.querybtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editbtn.Location = new System.Drawing.Point(252, 5);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(75, 23);
            this.editbtn.TabIndex = 8;
            this.editbtn.Text = "修改";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(736, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LOGINToolStripMenuItem,
            this.ENDToolStripMenuItem});
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ToolStripMenuItem.Text = "功能";
            // 
            // LOGINToolStripMenuItem
            // 
            this.LOGINToolStripMenuItem.Name = "LOGINToolStripMenuItem";
            this.LOGINToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.LOGINToolStripMenuItem.Text = "登入畫面";
            this.LOGINToolStripMenuItem.Click += new System.EventHandler(this.LOGINToolStripMenuItem_Click);
            // 
            // ENDToolStripMenuItem
            // 
            this.ENDToolStripMenuItem.Name = "ENDToolStripMenuItem";
            this.ENDToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.ENDToolStripMenuItem.Text = "結束";
            this.ENDToolStripMenuItem.Click += new System.EventHandler(this.ENDToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 436);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "設備監控系統";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.UNIT_STATUS.ResumeLayout(false);
            this.query.ResumeLayout(false);
            this.query.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_lora)).EndInit();
            this.log.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_log)).EndInit();
            this.De.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grid_lora;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Label lb_led_data;
        private System.Windows.Forms.Label lb_unit;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button querybtn;
        private System.Windows.Forms.ComboBox tx_unit;
        private System.Windows.Forms.ComboBox tx_led_data;
        private System.Windows.Forms.DateTimePicker tx_time;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage query;
        private System.Windows.Forms.TabPage log;
        private System.Windows.Forms.Button ADDbtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LOGINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ENDToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.DataGridView grid_log;
        private System.Windows.Forms.Button DELbtn;
        private System.Windows.Forms.Button CLbtn;
        private System.Windows.Forms.TabPage De;
        private System.Windows.Forms.RichTextBox debug;
        private System.Windows.Forms.TabPage UNIT_STATUS;
        private System.Windows.Forms.Panel panel2;
    }
}


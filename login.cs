using System;
using System.Data;
using System.Windows.Forms;
using connquery;

namespace SQL
{
    public partial class login : Form
    {
        string cmd = "";
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            //游標預設位置
            tx_user.Select();
            tx_pw.UseSystemPasswordChar = true;
            tx_pw.MaxLength = 14;
            tx_user.Text = "root";
            tx_pw.Text = "root";

            cmd = @"SELECT MENT FROM announcement ORDER BY MENT ASC LIMIT 1";
            DataTable dt = new connquery.connquery().conndt(cmd);
            richTextBox1.Text = dt.Rows[0]["ment"].ToString();
        }
            
        private void bt_login_Click(object sender, EventArgs e)
        {
            cmd = String.Format(@"SELECT USER,PASSWORD FROM USER WHERE USER = '{0}' AND PASSWORD = '{1}'"
                                    , tx_user.Text, tx_pw.Text);
            DataTable dt = new connquery.connquery().conndt(cmd);
            if (dt.Rows.Count != 0)
            {
                Form1 Form1 = new Form1();
                Form1.TextBoxMsg = "使用者 : " + tx_user.Text;
                Form1.Show();
                this.Hide();
            }
            else
                MessageBox.Show("使用者或密碼錯誤", "錯誤");

        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tx_user_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                bt_login_Click(this, null); 
        }

        private void tx_pw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                bt_login_Click(this, null); 
        }

        //右鍵選單
        private void ENDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //error 元件
        private void tx_user_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(tx_user.Text == "")
                errorProvider1.SetError(tx_user, "請輸入使用者");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                tx_pw.UseSystemPasswordChar = false;
            else
                tx_pw.UseSystemPasswordChar = true;
        }

    }
}

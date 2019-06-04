namespace SQL
{
    partial class login
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bt_exit = new System.Windows.Forms.Button();
            this.lb_pw = new System.Windows.Forms.Label();
            this.lb_user = new System.Windows.Forms.Label();
            this.bt_login = new System.Windows.Forms.Button();
            this.tx_pw = new System.Windows.Forms.TextBox();
            this.tx_user = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ENDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 216);
            this.panel1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(408, 216);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.bt_exit);
            this.panel2.Controls.Add(this.lb_pw);
            this.panel2.Controls.Add(this.lb_user);
            this.panel2.Controls.Add(this.bt_login);
            this.panel2.Controls.Add(this.tx_pw);
            this.panel2.Controls.Add(this.tx_user);
            this.panel2.Location = new System.Drawing.Point(168, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 89);
            this.panel2.TabIndex = 1;
            // 
            // bt_exit
            // 
            this.bt_exit.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bt_exit.Location = new System.Drawing.Point(159, 60);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(57, 23);
            this.bt_exit.TabIndex = 5;
            this.bt_exit.Text = "離開";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // lb_pw
            // 
            this.lb_pw.AutoSize = true;
            this.lb_pw.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_pw.Location = new System.Drawing.Point(19, 33);
            this.lb_pw.Name = "lb_pw";
            this.lb_pw.Size = new System.Drawing.Size(41, 20);
            this.lb_pw.TabIndex = 4;
            this.lb_pw.Text = "密碼";
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_user.Location = new System.Drawing.Point(3, 5);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(57, 20);
            this.lb_user.TabIndex = 3;
            this.lb_user.Text = "使用者";
            // 
            // bt_login
            // 
            this.bt_login.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bt_login.Location = new System.Drawing.Point(96, 60);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(57, 23);
            this.bt_login.TabIndex = 2;
            this.bt_login.Text = "登入";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // tx_pw
            // 
            this.tx_pw.Location = new System.Drawing.Point(62, 32);
            this.tx_pw.Name = "tx_pw";
            this.tx_pw.Size = new System.Drawing.Size(154, 22);
            this.tx_pw.TabIndex = 1;
            this.tx_pw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tx_pw_KeyDown);
            // 
            // tx_user
            // 
            this.tx_user.Location = new System.Drawing.Point(62, 4);
            this.tx_user.Name = "tx_user";
            this.tx_user.Size = new System.Drawing.Size(154, 22);
            this.tx_user.TabIndex = 0;
            this.tx_user.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tx_user_KeyDown);
            this.tx_user.Validating += new System.ComponentModel.CancelEventHandler(this.tx_user_Validating);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ENDToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // ENDToolStripMenuItem
            // 
            this.ENDToolStripMenuItem.Name = "ENDToolStripMenuItem";
            this.ENDToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.ENDToolStripMenuItem.Text = "關閉";
            this.ENDToolStripMenuItem.Click += new System.EventHandler(this.ENDToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.checkBox1.Location = new System.Drawing.Point(20, 63);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 20);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "顯示密碼";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 316);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "login";
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lb_pw;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.TextBox tx_pw;
        private System.Windows.Forms.TextBox tx_user;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ENDToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
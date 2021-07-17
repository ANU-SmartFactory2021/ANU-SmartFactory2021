namespace WindowsFormsApp2
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_user_id = new System.Windows.Forms.TextBox();
            this.txtbox_pw = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picbox_id_fail = new System.Windows.Forms.PictureBox();
            this.picbox_pw_fail = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_id_fail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_pw_fail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(100, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(100, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txtbox_user_id
            // 
            this.txtbox_user_id.BackColor = System.Drawing.SystemColors.Control;
            this.txtbox_user_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_user_id.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_user_id.Location = new System.Drawing.Point(105, 400);
            this.txtbox_user_id.Name = "txtbox_user_id";
            this.txtbox_user_id.Size = new System.Drawing.Size(292, 23);
            this.txtbox_user_id.TabIndex = 2;
            // 
            // txtbox_pw
            // 
            this.txtbox_pw.BackColor = System.Drawing.SystemColors.Control;
            this.txtbox_pw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_pw.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_pw.Location = new System.Drawing.Point(105, 482);
            this.txtbox_pw.Name = "txtbox_pw";
            this.txtbox_pw.PasswordChar = '*';
            this.txtbox_pw.Size = new System.Drawing.Size(292, 23);
            this.txtbox_pw.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(166, 638);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(168, 38);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.login_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 300);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Image = global::WindowsFormsApp2.Properties.Resources.baseline_power_settings_new_black_18dp;
            this.btn_exit.Location = new System.Drawing.Point(457, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(31, 27);
            this.btn_exit.TabIndex = 1;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(141, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 55);
            this.label3.TabIndex = 0;
            this.label3.Text = "Aria_MES";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(95, 431);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 1);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Location = new System.Drawing.Point(95, 513);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(315, 1);
            this.panel3.TabIndex = 7;
            // 
            // picbox_id_fail
            // 
            this.picbox_id_fail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picbox_id_fail.Image = global::WindowsFormsApp2.Properties.Resources.cancel;
            this.picbox_id_fail.Location = new System.Drawing.Point(417, 393);
            this.picbox_id_fail.Name = "picbox_id_fail";
            this.picbox_id_fail.Size = new System.Drawing.Size(30, 30);
            this.picbox_id_fail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_id_fail.TabIndex = 8;
            this.picbox_id_fail.TabStop = false;
            // 
            // picbox_pw_fail
            // 
            this.picbox_pw_fail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picbox_pw_fail.Image = global::WindowsFormsApp2.Properties.Resources.cancel;
            this.picbox_pw_fail.Location = new System.Drawing.Point(417, 475);
            this.picbox_pw_fail.Name = "picbox_pw_fail";
            this.picbox_pw_fail.Size = new System.Drawing.Size(30, 30);
            this.picbox_pw_fail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox_pw_fail.TabIndex = 8;
            this.picbox_pw_fail.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 800);
            this.Controls.Add(this.picbox_pw_fail);
            this.Controls.Add(this.picbox_id_fail);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txtbox_pw);
            this.Controls.Add(this.txtbox_user_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_id_fail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_pw_fail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_pw;
        private System.Windows.Forms.Button btn_login;
        public System.Windows.Forms.TextBox txtbox_user_id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox picbox_id_fail;
        private System.Windows.Forms.PictureBox picbox_pw_fail;
    }
}
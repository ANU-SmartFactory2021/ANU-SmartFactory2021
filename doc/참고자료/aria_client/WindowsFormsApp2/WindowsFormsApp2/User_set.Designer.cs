namespace WindowsFormsApp2
{
    partial class User_set
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
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_user_id = new System.Windows.Forms.TextBox();
            this.txtbox_user_pw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbox_email = new System.Windows.Forms.TextBox();
            this.txtbox_first_name = new System.Windows.Forms.TextBox();
            this.txtbox_last_text = new System.Windows.Forms.TextBox();
            this.rtxtbox_users = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbtn_level_0 = new System.Windows.Forms.RadioButton();
            this.rbtn_lever_1 = new System.Windows.Forms.RadioButton();
            this.DataGridView_user_view = new System.Windows.Forms.DataGridView();
            this.txtbox_id_sc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_user_view)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Insert
            // 
            this.btn_Insert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Insert.Location = new System.Drawing.Point(287, 524);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert.TabIndex = 0;
            this.btn_Insert.Text = "생성";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Delete.Location = new System.Drawing.Point(427, 524);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "삭제";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Update.Location = new System.Drawing.Point(580, 524);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 2;
            this.btn_Update.Text = "변경";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Search.Location = new System.Drawing.Point(1346, 486);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "검색";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.search_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "아이디";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "비밀번호";
            // 
            // txtbox_user_id
            // 
            this.txtbox_user_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbox_user_id.Location = new System.Drawing.Point(362, 109);
            this.txtbox_user_id.Name = "txtbox_user_id";
            this.txtbox_user_id.Size = new System.Drawing.Size(176, 25);
            this.txtbox_user_id.TabIndex = 6;
            // 
            // txtbox_user_pw
            // 
            this.txtbox_user_pw.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbox_user_pw.Location = new System.Drawing.Point(362, 167);
            this.txtbox_user_pw.Name = "txtbox_user_pw";
            this.txtbox_user_pw.Size = new System.Drawing.Size(176, 25);
            this.txtbox_user_pw.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "level";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "e_mail";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "first_name";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "last_name";
            // 
            // txtbox_email
            // 
            this.txtbox_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbox_email.Location = new System.Drawing.Point(362, 295);
            this.txtbox_email.Name = "txtbox_email";
            this.txtbox_email.Size = new System.Drawing.Size(176, 25);
            this.txtbox_email.TabIndex = 13;
            // 
            // txtbox_first_name
            // 
            this.txtbox_first_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbox_first_name.Location = new System.Drawing.Point(362, 356);
            this.txtbox_first_name.Name = "txtbox_first_name";
            this.txtbox_first_name.Size = new System.Drawing.Size(176, 25);
            this.txtbox_first_name.TabIndex = 14;
            // 
            // txtbox_last_text
            // 
            this.txtbox_last_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbox_last_text.Location = new System.Drawing.Point(362, 416);
            this.txtbox_last_text.Name = "txtbox_last_text";
            this.txtbox_last_text.Size = new System.Drawing.Size(176, 25);
            this.txtbox_last_text.TabIndex = 15;
            // 
            // rtxtbox_users
            // 
            this.rtxtbox_users.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtxtbox_users.Location = new System.Drawing.Point(596, 109);
            this.rtxtbox_users.Name = "rtxtbox_users";
            this.rtxtbox_users.Size = new System.Drawing.Size(300, 371);
            this.rtxtbox_users.TabIndex = 17;
            this.rtxtbox_users.Text = "";
            this.rtxtbox_users.TextChanged += new System.EventHandler(this.Rtxtbox_users_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(679, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "현재 회원목록";
            // 
            // rbtn_level_0
            // 
            this.rbtn_level_0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_level_0.AutoSize = true;
            this.rbtn_level_0.Location = new System.Drawing.Point(369, 237);
            this.rbtn_level_0.Name = "rbtn_level_0";
            this.rbtn_level_0.Size = new System.Drawing.Size(73, 19);
            this.rbtn_level_0.TabIndex = 19;
            this.rbtn_level_0.TabStop = true;
            this.rbtn_level_0.Text = "관리자";
            this.rbtn_level_0.UseVisualStyleBackColor = true;
            // 
            // rbtn_lever_1
            // 
            this.rbtn_lever_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbtn_lever_1.AutoSize = true;
            this.rbtn_lever_1.Location = new System.Drawing.Point(448, 237);
            this.rbtn_lever_1.Name = "rbtn_lever_1";
            this.rbtn_lever_1.Size = new System.Drawing.Size(73, 19);
            this.rbtn_lever_1.TabIndex = 19;
            this.rbtn_lever_1.TabStop = true;
            this.rbtn_lever_1.Text = "사용자";
            this.rbtn_lever_1.UseVisualStyleBackColor = true;
            // 
            // DataGridView_user_view
            // 
            this.DataGridView_user_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_user_view.Location = new System.Drawing.Point(902, 109);
            this.DataGridView_user_view.Name = "DataGridView_user_view";
            this.DataGridView_user_view.RowHeadersWidth = 51;
            this.DataGridView_user_view.RowTemplate.Height = 27;
            this.DataGridView_user_view.Size = new System.Drawing.Size(519, 371);
            this.DataGridView_user_view.TabIndex = 20;
            this.DataGridView_user_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.User_view_CellClick);
            this.DataGridView_user_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.User_view_CellContentClick);
            // 
            // txtbox_id_sc
            // 
            this.txtbox_id_sc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbox_id_sc.Location = new System.Drawing.Point(1164, 484);
            this.txtbox_id_sc.Name = "txtbox_id_sc";
            this.txtbox_id_sc.Size = new System.Drawing.Size(176, 25);
            this.txtbox_id_sc.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(706, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // User_set
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 792);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DataGridView_user_view);
            this.Controls.Add(this.rbtn_lever_1);
            this.Controls.Add(this.rbtn_level_0);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rtxtbox_users);
            this.Controls.Add(this.txtbox_last_text);
            this.Controls.Add(this.txtbox_first_name);
            this.Controls.Add(this.txtbox_email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox_user_pw);
            this.Controls.Add(this.txtbox_id_sc);
            this.Controls.Add(this.txtbox_user_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Insert);
            this.Name = "User_set";
            this.Text = "m1";
            this.Load += new System.EventHandler(this.m1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_user_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_user_id;
        private System.Windows.Forms.TextBox txtbox_user_pw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbox_email;
        private System.Windows.Forms.TextBox txtbox_first_name;
        private System.Windows.Forms.TextBox txtbox_last_text;
        private System.Windows.Forms.RichTextBox rtxtbox_users;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbtn_level_0;
        private System.Windows.Forms.RadioButton rbtn_lever_1;
        private System.Windows.Forms.DataGridView DataGridView_user_view;
        private System.Windows.Forms.TextBox txtbox_id_sc;
        private System.Windows.Forms.Button button1;
    }
}
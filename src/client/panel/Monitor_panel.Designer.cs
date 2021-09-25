
namespace Client.panel
{
    partial class Monitor_panel
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.M_Product_txt = new System.Windows.Forms.TextBox();
            this.M_Kcal_txt = new System.Windows.Forms.TextBox();
            this.M_Serialnum_txt = new System.Windows.Forms.TextBox();
            this.M_Company_txt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bad_txt = new System.Windows.Forms.Label();
            this.good_txt = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sensor_off = new System.Windows.Forms.TextBox();
            this.sensor_on = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cam_off = new System.Windows.Forms.TextBox();
            this.cam_on = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "제 품 명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "제조회사";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "일련번호";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "칼 로 리";
            // 
            // M_Product_txt
            // 
            this.M_Product_txt.Location = new System.Drawing.Point(141, 57);
            this.M_Product_txt.Name = "M_Product_txt";
            this.M_Product_txt.Size = new System.Drawing.Size(121, 21);
            this.M_Product_txt.TabIndex = 5;
            this.M_Product_txt.Text = "  ";
            // 
            // M_Kcal_txt
            // 
            this.M_Kcal_txt.Location = new System.Drawing.Point(141, 171);
            this.M_Kcal_txt.Name = "M_Kcal_txt";
            this.M_Kcal_txt.Size = new System.Drawing.Size(121, 21);
            this.M_Kcal_txt.TabIndex = 6;
            // 
            // M_Serialnum_txt
            // 
            this.M_Serialnum_txt.Location = new System.Drawing.Point(141, 133);
            this.M_Serialnum_txt.Name = "M_Serialnum_txt";
            this.M_Serialnum_txt.Size = new System.Drawing.Size(121, 21);
            this.M_Serialnum_txt.TabIndex = 7;
            this.M_Serialnum_txt.Text = "0";
            this.M_Serialnum_txt.TextChanged += new System.EventHandler(this.M_Serialnum_txt_TextChanged);
            // 
            // M_Company_txt
            // 
            this.M_Company_txt.Location = new System.Drawing.Point(141, 97);
            this.M_Company_txt.Name = "M_Company_txt";
            this.M_Company_txt.Size = new System.Drawing.Size(121, 21);
            this.M_Company_txt.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(332, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 188);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(406, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "QR 이미지";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bad_txt);
            this.groupBox1.Controls.Add(this.good_txt);
            this.groupBox1.Location = new System.Drawing.Point(332, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 67);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "제품 상태";
            // 
            // bad_txt
            // 
            this.bad_txt.AutoSize = true;
            this.bad_txt.BackColor = System.Drawing.Color.White;
            this.bad_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bad_txt.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bad_txt.Location = new System.Drawing.Point(145, 32);
            this.bad_txt.Name = "bad_txt";
            this.bad_txt.Size = new System.Drawing.Size(39, 17);
            this.bad_txt.TabIndex = 1;
            this.bad_txt.Text = "불량";
            // 
            // good_txt
            // 
            this.good_txt.AutoSize = true;
            this.good_txt.BackColor = System.Drawing.Color.White;
            this.good_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.good_txt.Font = new System.Drawing.Font("굴림", 11F);
            this.good_txt.Location = new System.Drawing.Point(24, 32);
            this.good_txt.Name = "good_txt";
            this.good_txt.Size = new System.Drawing.Size(39, 17);
            this.good_txt.TabIndex = 0;
            this.good_txt.Text = "정상";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(50, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 188);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "제품 정보";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sensor_off);
            this.groupBox3.Controls.Add(this.sensor_on);
            this.groupBox3.Location = new System.Drawing.Point(50, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(105, 83);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "센서";
            // 
            // sensor_off
            // 
            this.sensor_off.BackColor = System.Drawing.Color.Red;
            this.sensor_off.Location = new System.Drawing.Point(20, 53);
            this.sensor_off.Name = "sensor_off";
            this.sensor_off.Size = new System.Drawing.Size(66, 21);
            this.sensor_off.TabIndex = 1;
            this.sensor_off.Text = "OFF";
            this.sensor_off.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sensor_on
            // 
            this.sensor_on.Location = new System.Drawing.Point(20, 28);
            this.sensor_on.Name = "sensor_on";
            this.sensor_on.Size = new System.Drawing.Size(66, 21);
            this.sensor_on.TabIndex = 0;
            this.sensor_on.Text = "ON";
            this.sensor_on.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cam_off);
            this.groupBox4.Controls.Add(this.cam_on);
            this.groupBox4.Location = new System.Drawing.Point(182, 240);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(105, 83);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "카메라";
            // 
            // cam_off
            // 
            this.cam_off.BackColor = System.Drawing.Color.Red;
            this.cam_off.Location = new System.Drawing.Point(21, 53);
            this.cam_off.Name = "cam_off";
            this.cam_off.Size = new System.Drawing.Size(66, 21);
            this.cam_off.TabIndex = 3;
            this.cam_off.Text = "OFF";
            this.cam_off.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cam_on
            // 
            this.cam_on.BackColor = System.Drawing.Color.White;
            this.cam_on.Location = new System.Drawing.Point(21, 28);
            this.cam_on.Name = "cam_on";
            this.cam_on.Size = new System.Drawing.Size(66, 21);
            this.cam_on.TabIndex = 2;
            this.cam_on.Text = "ON";
            this.cam_on.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Monitor_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.M_Company_txt);
            this.Controls.Add(this.M_Serialnum_txt);
            this.Controls.Add(this.M_Kcal_txt);
            this.Controls.Add(this.M_Product_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Monitor_panel";
            this.Size = new System.Drawing.Size(589, 352);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox M_Kcal_txt;
        private System.Windows.Forms.TextBox M_Company_txt;
        private System.Windows.Forms.TextBox M_Product_txt;
        public System.Windows.Forms.TextBox M_Serialnum_txt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label good_txt;
        private System.Windows.Forms.Label bad_txt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox sensor_off;
        private System.Windows.Forms.TextBox sensor_on;
        public System.Windows.Forms.TextBox cam_off;
        public System.Windows.Forms.TextBox cam_on;
    }
}

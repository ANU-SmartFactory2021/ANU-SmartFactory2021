
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
            this.output_num_txt = new System.Windows.Forms.TextBox();
            this.M_Serialnum_txt = new System.Windows.Forms.TextBox();
            this.M_Company_txt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sensor_off = new System.Windows.Forms.TextBox();
            this.sensor_on = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cam_off = new System.Windows.Forms.TextBox();
            this.cam_on = new System.Windows.Forms.TextBox();
            this.belt_off = new System.Windows.Forms.TextBox();
            this.belt_on = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.step_2 = new System.Windows.Forms.TextBox();
            this.step_4 = new System.Windows.Forms.TextBox();
            this.step_3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.step_1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.good_txt = new System.Windows.Forms.Label();
            this.bad_txt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "제 품 명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "제조회사";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "일련번호";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "수    량";
            // 
            // M_Product_txt
            // 
            this.M_Product_txt.Location = new System.Drawing.Point(130, 168);
            this.M_Product_txt.Name = "M_Product_txt";
            this.M_Product_txt.Size = new System.Drawing.Size(121, 21);
            this.M_Product_txt.TabIndex = 5;
            this.M_Product_txt.Text = "  ";
            // 
            // output_num_txt
            // 
            this.output_num_txt.Location = new System.Drawing.Point(130, 282);
            this.output_num_txt.Name = "output_num_txt";
            this.output_num_txt.Size = new System.Drawing.Size(121, 21);
            this.output_num_txt.TabIndex = 6;
            // 
            // M_Serialnum_txt
            // 
            this.M_Serialnum_txt.Location = new System.Drawing.Point(130, 244);
            this.M_Serialnum_txt.Name = "M_Serialnum_txt";
            this.M_Serialnum_txt.Size = new System.Drawing.Size(121, 21);
            this.M_Serialnum_txt.TabIndex = 7;
            this.M_Serialnum_txt.Text = "0";
            this.M_Serialnum_txt.TextChanged += new System.EventHandler(this.M_Serialnum_txt_TextChanged);
            // 
            // M_Company_txt
            // 
            this.M_Company_txt.Location = new System.Drawing.Point(130, 208);
            this.M_Company_txt.Name = "M_Company_txt";
            this.M_Company_txt.Size = new System.Drawing.Size(121, 21);
            this.M_Company_txt.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(307, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(43, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 258);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "제품 정보";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sensor_off);
            this.groupBox3.Controls.Add(this.sensor_on);
            this.groupBox3.Location = new System.Drawing.Point(43, 17);
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
            this.groupBox4.Location = new System.Drawing.Point(154, 17);
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
            // belt_off
            // 
            this.belt_off.BackColor = System.Drawing.Color.Red;
            this.belt_off.Location = new System.Drawing.Point(21, 53);
            this.belt_off.Name = "belt_off";
            this.belt_off.Size = new System.Drawing.Size(66, 21);
            this.belt_off.TabIndex = 3;
            this.belt_off.Text = "OFF";
            this.belt_off.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // belt_on
            // 
            this.belt_on.BackColor = System.Drawing.Color.White;
            this.belt_on.Location = new System.Drawing.Point(21, 28);
            this.belt_on.Name = "belt_on";
            this.belt_on.Size = new System.Drawing.Size(66, 21);
            this.belt_on.TabIndex = 2;
            this.belt_on.Text = "ON";
            this.belt_on.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.belt_off);
            this.groupBox5.Controls.Add(this.belt_on);
            this.groupBox5.Location = new System.Drawing.Point(265, 17);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(105, 83);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "컨베이어 벨트";
            // 
            // step_2
            // 
            this.step_2.BackColor = System.Drawing.Color.White;
            this.step_2.Location = new System.Drawing.Point(154, 384);
            this.step_2.Multiline = true;
            this.step_2.Name = "step_2";
            this.step_2.Size = new System.Drawing.Size(61, 60);
            this.step_2.TabIndex = 11;
            this.step_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // step_4
            // 
            this.step_4.BackColor = System.Drawing.Color.White;
            this.step_4.Location = new System.Drawing.Point(388, 384);
            this.step_4.Multiline = true;
            this.step_4.Name = "step_4";
            this.step_4.Size = new System.Drawing.Size(60, 60);
            this.step_4.TabIndex = 23;
            this.step_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // step_3
            // 
            this.step_3.BackColor = System.Drawing.Color.White;
            this.step_3.Location = new System.Drawing.Point(265, 384);
            this.step_3.Multiline = true;
            this.step_3.Name = "step_3";
            this.step_3.Size = new System.Drawing.Size(61, 60);
            this.step_3.TabIndex = 24;
            this.step_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(230, 409);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 28;
            this.label9.Text = ">>>";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(348, 409);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 29;
            this.label10.Text = ">>>";
            // 
            // step_1
            // 
            this.step_1.BackColor = System.Drawing.Color.White;
            this.step_1.Location = new System.Drawing.Point(46, 384);
            this.step_1.Multiline = true;
            this.step_1.Name = "step_1";
            this.step_1.Size = new System.Drawing.Size(62, 60);
            this.step_1.TabIndex = 30;
            this.step_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 31;
            this.label1.Text = ">>>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 32;
            this.label6.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 447);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 33;
            this.label7.Text = "4";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(287, 447);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 12);
            this.label11.TabIndex = 34;
            this.label11.Text = "3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(179, 447);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 12);
            this.label12.TabIndex = 35;
            this.label12.Text = "2";
            // 
            // good_txt
            // 
            this.good_txt.AutoSize = true;
            this.good_txt.BackColor = System.Drawing.Color.White;
            this.good_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.good_txt.Font = new System.Drawing.Font("굴림", 11F);
            this.good_txt.Location = new System.Drawing.Point(343, 336);
            this.good_txt.Name = "good_txt";
            this.good_txt.Size = new System.Drawing.Size(39, 17);
            this.good_txt.TabIndex = 0;
            this.good_txt.Text = "정상";
            // 
            // bad_txt
            // 
            this.bad_txt.AutoSize = true;
            this.bad_txt.BackColor = System.Drawing.Color.White;
            this.bad_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bad_txt.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bad_txt.Location = new System.Drawing.Point(445, 336);
            this.bad_txt.Name = "bad_txt";
            this.bad_txt.Size = new System.Drawing.Size(39, 17);
            this.bad_txt.TabIndex = 1;
            this.bad_txt.Text = "불량";
            // 
            // Monitor_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.bad_txt);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.good_txt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.step_1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.step_3);
            this.Controls.Add(this.step_4);
            this.Controls.Add(this.step_2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.M_Company_txt);
            this.Controls.Add(this.M_Serialnum_txt);
            this.Controls.Add(this.output_num_txt);
            this.Controls.Add(this.M_Product_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Name = "Monitor_panel";
            this.Size = new System.Drawing.Size(726, 474);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox output_num_txt;
        private System.Windows.Forms.TextBox M_Company_txt;
        private System.Windows.Forms.TextBox M_Product_txt;
        public System.Windows.Forms.TextBox M_Serialnum_txt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox sensor_off;
        private System.Windows.Forms.TextBox sensor_on;
        public System.Windows.Forms.TextBox cam_off;
        public System.Windows.Forms.TextBox cam_on;
        public System.Windows.Forms.TextBox belt_off;
        public System.Windows.Forms.TextBox belt_on;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox step_2;
        private System.Windows.Forms.TextBox step_4;
        private System.Windows.Forms.TextBox step_3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox step_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label good_txt;
        private System.Windows.Forms.Label bad_txt;
    }
}

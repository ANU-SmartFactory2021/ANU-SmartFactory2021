
namespace Client.panel
{
    partial class Start_panel
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
            this.Company_txt = new System.Windows.Forms.TextBox();
            this.Kcal_txt = new System.Windows.Forms.TextBox();
            this.Serialnum_txt = new System.Windows.Forms.TextBox();
            this.Product_combo = new System.Windows.Forms.ComboBox();
            this.Start_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.product_png = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.product_png)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.label3.Location = new System.Drawing.Point(16, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "제조회사";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "일련번호";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "칼 로 리";
            // 
            // Company_txt
            // 
            this.Company_txt.Location = new System.Drawing.Point(91, 70);
            this.Company_txt.Name = "Company_txt";
            this.Company_txt.Size = new System.Drawing.Size(121, 21);
            this.Company_txt.TabIndex = 5;
            // 
            // Kcal_txt
            // 
            this.Kcal_txt.Location = new System.Drawing.Point(91, 144);
            this.Kcal_txt.Name = "Kcal_txt";
            this.Kcal_txt.Size = new System.Drawing.Size(121, 21);
            this.Kcal_txt.TabIndex = 6;
            // 
            // Serialnum_txt
            // 
            this.Serialnum_txt.Location = new System.Drawing.Point(91, 106);
            this.Serialnum_txt.Name = "Serialnum_txt";
            this.Serialnum_txt.Size = new System.Drawing.Size(121, 21);
            this.Serialnum_txt.TabIndex = 7;
            // 
            // Product_combo
            // 
            this.Product_combo.FormattingEnabled = true;
            this.Product_combo.Location = new System.Drawing.Point(141, 57);
            this.Product_combo.Name = "Product_combo";
            this.Product_combo.Size = new System.Drawing.Size(121, 20);
            this.Product_combo.TabIndex = 8;
            this.Product_combo.SelectedIndexChanged += new System.EventHandler(this.Product_combo_SelectedIndexChanged);
            // 
            // Start_btn
            // 
            this.Start_btn.Location = new System.Drawing.Point(317, 293);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(114, 44);
            this.Start_btn.TabIndex = 9;
            this.Start_btn.Text = "시   작";
            this.Start_btn.UseVisualStyleBackColor = true;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(437, 293);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(114, 44);
            this.Cancel_btn.TabIndex = 10;
            this.Cancel_btn.Text = "중지";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // product_png
            // 
            this.product_png.Location = new System.Drawing.Point(332, 27);
            this.product_png.Name = "product_png";
            this.product_png.Size = new System.Drawing.Size(216, 188);
            this.product_png.TabIndex = 11;
            this.product_png.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.Company_txt);
            this.groupBox2.Controls.Add(this.Kcal_txt);
            this.groupBox2.Controls.Add(this.Serialnum_txt);
            this.groupBox2.Location = new System.Drawing.Point(50, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 188);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "제품 정보";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(406, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "제품 이미지";
            // 
            // Start_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.product_png);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Start_btn);
            this.Controls.Add(this.Product_combo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Name = "Start_panel";
            this.Size = new System.Drawing.Size(589, 352);
            ((System.ComponentModel.ISupportInitialize)(this.product_png)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Company_txt;
        private System.Windows.Forms.ComboBox Product_combo;
        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.PictureBox product_png;
        public System.Windows.Forms.TextBox Serialnum_txt;
        public System.Windows.Forms.TextBox Kcal_txt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
    }
}

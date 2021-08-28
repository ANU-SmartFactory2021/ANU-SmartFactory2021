
namespace ClientTest01.panel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Company_txt = new System.Windows.Forms.TextBox();
            this.Outputnum_txt = new System.Windows.Forms.TextBox();
            this.Serialnum_txt = new System.Windows.Forms.TextBox();
            this.Product_combo = new System.Windows.Forms.ComboBox();
            this.Start_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.product_png = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.product_png)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start_panel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "제품  명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "제조회사";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "일련번호";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "수      량";
            // 
            // Company_txt
            // 
            this.Company_txt.Location = new System.Drawing.Point(112, 112);
            this.Company_txt.Name = "Company_txt";
            this.Company_txt.Size = new System.Drawing.Size(121, 21);
            this.Company_txt.TabIndex = 5;
            // 
            // Outputnum_txt
            // 
            this.Outputnum_txt.Location = new System.Drawing.Point(112, 186);
            this.Outputnum_txt.Name = "Outputnum_txt";
            this.Outputnum_txt.Size = new System.Drawing.Size(121, 21);
            this.Outputnum_txt.TabIndex = 6;
            // 
            // Serialnum_txt
            // 
            this.Serialnum_txt.Location = new System.Drawing.Point(112, 148);
            this.Serialnum_txt.Name = "Serialnum_txt";
            this.Serialnum_txt.Size = new System.Drawing.Size(121, 21);
            this.Serialnum_txt.TabIndex = 7;
            // 
            // Product_combo
            // 
            this.Product_combo.FormattingEnabled = true;
            this.Product_combo.Location = new System.Drawing.Point(112, 72);
            this.Product_combo.Name = "Product_combo";
            this.Product_combo.Size = new System.Drawing.Size(121, 20);
            this.Product_combo.TabIndex = 8;
            this.Product_combo.SelectedIndexChanged += new System.EventHandler(this.Product_combo_SelectedIndexChanged);
            // 
            // Start_btn
            // 
            this.Start_btn.Location = new System.Drawing.Point(437, 243);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(114, 44);
            this.Start_btn.TabIndex = 9;
            this.Start_btn.Text = "작업 시작";
            this.Start_btn.UseVisualStyleBackColor = true;
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(437, 293);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(114, 44);
            this.Cancel_btn.TabIndex = 10;
            this.Cancel_btn.Text = "취    소";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // product_png
            // 
            this.product_png.Location = new System.Drawing.Point(275, 72);
            this.product_png.Name = "product_png";
            this.product_png.Size = new System.Drawing.Size(136, 135);
            this.product_png.TabIndex = 11;
            this.product_png.TabStop = false;
            // 
            // Start_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.product_png);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Start_btn);
            this.Controls.Add(this.Product_combo);
            this.Controls.Add(this.Serialnum_txt);
            this.Controls.Add(this.Outputnum_txt);
            this.Controls.Add(this.Company_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Start_panel";
            this.Size = new System.Drawing.Size(589, 352);            
            ((System.ComponentModel.ISupportInitialize)(this.product_png)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Company_txt;
        private System.Windows.Forms.TextBox Outputnum_txt;
        private System.Windows.Forms.TextBox Serialnum_txt;
        private System.Windows.Forms.ComboBox Product_combo;
        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.PictureBox product_png;
    }
}

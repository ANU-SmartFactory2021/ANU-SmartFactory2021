namespace WindowsFormsApp2
{
    partial class fmMainMenu
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
            this.user_set_button = new System.Windows.Forms.Button();
            this.model_set_button = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.line_button = new System.Windows.Forms.Button();
            this.lot_direct_button = new System.Windows.Forms.Button();
            this.fail_prod_button = new System.Windows.Forms.Button();
            this.finish_m_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // user_set_button
            // 
            this.user_set_button.Location = new System.Drawing.Point(12, 67);
            this.user_set_button.Name = "user_set_button";
            this.user_set_button.Size = new System.Drawing.Size(236, 67);
            this.user_set_button.TabIndex = 0;
            this.user_set_button.Text = "[관리자] 사용자 회원가입시켜주기";
            this.user_set_button.UseVisualStyleBackColor = true;
            this.user_set_button.Click += new System.EventHandler(this.user_set_button_Click);
            // 
            // model_set_button
            // 
            this.model_set_button.Location = new System.Drawing.Point(12, 140);
            this.model_set_button.Name = "model_set_button";
            this.model_set_button.Size = new System.Drawing.Size(236, 67);
            this.model_set_button.TabIndex = 0;
            this.model_set_button.Text = "[관리자] 모델 빵 만들어주는 곳";
            this.model_set_button.UseVisualStyleBackColor = true;
            this.model_set_button.Click += new System.EventHandler(this.model_set_button_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 594);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(236, 67);
            this.button4.TabIndex = 0;
            this.button4.Text = "[관리자] 라인 관리(생성,삭제)";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // line_button
            // 
            this.line_button.Location = new System.Drawing.Point(12, 314);
            this.line_button.Name = "line_button";
            this.line_button.Size = new System.Drawing.Size(236, 67);
            this.line_button.TabIndex = 0;
            this.line_button.Text = "[모두] 라인 현황 확인하는곳";
            this.line_button.UseVisualStyleBackColor = true;
            this.line_button.Click += new System.EventHandler(this.line_button_Click);
            // 
            // lot_direct_button
            // 
            this.lot_direct_button.Location = new System.Drawing.Point(12, 241);
            this.lot_direct_button.Name = "lot_direct_button";
            this.lot_direct_button.Size = new System.Drawing.Size(236, 67);
            this.lot_direct_button.TabIndex = 0;
            this.lot_direct_button.Text = "[모두] 작업지시 내리는곳";
            this.lot_direct_button.UseVisualStyleBackColor = true;
            this.lot_direct_button.Click += new System.EventHandler(this.lot_direct_button_Click);
            // 
            // fail_prod_button
            // 
            this.fail_prod_button.Location = new System.Drawing.Point(12, 432);
            this.fail_prod_button.Name = "fail_prod_button";
            this.fail_prod_button.Size = new System.Drawing.Size(236, 67);
            this.fail_prod_button.TabIndex = 0;
            this.fail_prod_button.Text = "[모두] 불량재고 확인하는 곳";
            this.fail_prod_button.UseVisualStyleBackColor = true;
            this.fail_prod_button.Click += new System.EventHandler(this.fail_prod_button_Click);
            // 
            // finish_m_button
            // 
            this.finish_m_button.Location = new System.Drawing.Point(12, 505);
            this.finish_m_button.Name = "finish_m_button";
            this.finish_m_button.Size = new System.Drawing.Size(236, 67);
            this.finish_m_button.TabIndex = 0;
            this.finish_m_button.Text = "[모두] 완성품 재고 관리(재고, 판매완료)";
            this.finish_m_button.UseVisualStyleBackColor = true;
            this.finish_m_button.Click += new System.EventHandler(this.finish_m_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(269, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(710, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "사용자 id, pass, e-mail, f-name, l-name ( 검색, 삭제, 수정, 삽입 )";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(584, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "기능";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(94, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "메뉴";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(269, 613);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1196, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "관리자 id, model-name, 작업현황, 작업중인 모델, 공장 온도,습도 (라인 검색, 삽입, 삭제, 수정-10초마다 갱신)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(269, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(912, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "모델의 id, 적정 온도,습도, 이름 ( 검색, 삽입, 삭제, 수정 - 모델 아이디는 수정 불가)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(269, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 24);
            this.label6.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(269, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1458, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "lot_id, model_id, line_id, 수량, 스피드, 불량률, 색깔, 온습도, 지시자 아이디, 작업상태, 지시가 만들어진 시간, 행해진" +
    " 시간, 완료된 시간";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(269, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(851, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "[실시간 모니터링] 라인id, 작업자 이름, 작업현황, 작업중인 모델, 공장 온습도";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(269, 378);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(634, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "프로덕트에서 내려온 값중에서 불량만 뽑아서 테이블 검색";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(269, 451);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(874, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "프로덕트에서 내려온 값중에서 완료된 제품을 옮겨서 버튼으로 판매 및 재고관리";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 667);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 67);
            this.button2.TabIndex = 0;
            this.button2.Text = "[하드웨어] 어떤 하드웨어가 연결되어있나요?";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1670, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 15);
            this.label11.TabIndex = 4;
            this.label11.Text = "종료";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1612, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 15);
            this.label12.TabIndex = 4;
            this.label12.Text = "최소화";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1569, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 15);
            this.label13.TabIndex = 4;
            this.label13.Text = "설정";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1526, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 15);
            this.label14.TabIndex = 4;
            this.label14.Text = "알림";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1296, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 15);
            this.label15.TabIndex = 4;
            this.label15.Text = "관리자 id : ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(269, 686);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(874, 24);
            this.label16.TabIndex = 1;
            this.label16.Text = "프로덕트에서 내려온 값중에서 완료된 제품을 옮겨서 버튼으로 판매 및 재고관리";
            // 
            // fmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1728, 926);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.finish_m_button);
            this.Controls.Add(this.fail_prod_button);
            this.Controls.Add(this.lot_direct_button);
            this.Controls.Add(this.line_button);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.model_set_button);
            this.Controls.Add(this.user_set_button);
            this.Name = "fmMainMenu";
            this.Text = "menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Shown += new System.EventHandler(this.FmMainMenu_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button user_set_button;
        private System.Windows.Forms.Button model_set_button;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button line_button;
        private System.Windows.Forms.Button lot_direct_button;
        private System.Windows.Forms.Button fail_prod_button;
        private System.Windows.Forms.Button finish_m_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}
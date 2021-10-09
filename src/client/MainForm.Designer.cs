
namespace Client
{
    partial class MainForm
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Menu_btn = new System.Windows.Forms.Button();
            this.Start_btn = new System.Windows.Forms.Button();
            this.Monitor_btn = new System.Windows.Forms.Button();
            this.Def_btn = new System.Windows.Forms.Button();
            this.Fairqual_btn = new System.Windows.Forms.Button();
            this.Stop_btn = new System.Windows.Forms.Button();
            this.Main_panel = new System.Windows.Forms.Panel();
            this.Time_label = new System.Windows.Forms.Label();
            this.State_label = new System.Windows.Forms.Label();
            this.st_start = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.st_stop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.st_finish = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Menu_btn
            // 
            this.Menu_btn.BackColor = System.Drawing.Color.SlateBlue;
            this.Menu_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Menu_btn.FlatAppearance.BorderSize = 0;
            this.Menu_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Menu_btn.Location = new System.Drawing.Point(14, 74);
            this.Menu_btn.Name = "Menu_btn";
            this.Menu_btn.Size = new System.Drawing.Size(165, 45);
            this.Menu_btn.TabIndex = 0;
            this.Menu_btn.Text = "메뉴";
            this.Menu_btn.UseVisualStyleBackColor = false;
            this.Menu_btn.Click += new System.EventHandler(this.Menu_btn_Click);
            // 
            // Start_btn
            // 
            this.Start_btn.Location = new System.Drawing.Point(14, 134);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(165, 45);
            this.Start_btn.TabIndex = 1;
            this.Start_btn.Text = "구별 작업 시작";
            this.Start_btn.UseVisualStyleBackColor = true;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // Monitor_btn
            // 
            this.Monitor_btn.Location = new System.Drawing.Point(14, 195);
            this.Monitor_btn.Name = "Monitor_btn";
            this.Monitor_btn.Size = new System.Drawing.Size(165, 45);
            this.Monitor_btn.TabIndex = 2;
            this.Monitor_btn.Text = "라인 모니터링";
            this.Monitor_btn.UseVisualStyleBackColor = true;
            this.Monitor_btn.Click += new System.EventHandler(this.Monitor_btn_Click);
            // 
            // Def_btn
            // 
            this.Def_btn.Location = new System.Drawing.Point(14, 258);
            this.Def_btn.Name = "Def_btn";
            this.Def_btn.Size = new System.Drawing.Size(165, 45);
            this.Def_btn.TabIndex = 3;
            this.Def_btn.Text = "불량품 현황";
            this.Def_btn.UseVisualStyleBackColor = true;
            this.Def_btn.Click += new System.EventHandler(this.Def_btn_Click);
            // 
            // Fairqual_btn
            // 
            this.Fairqual_btn.Location = new System.Drawing.Point(14, 320);
            this.Fairqual_btn.Name = "Fairqual_btn";
            this.Fairqual_btn.Size = new System.Drawing.Size(165, 45);
            this.Fairqual_btn.TabIndex = 4;
            this.Fairqual_btn.Text = "양품 현황";
            this.Fairqual_btn.UseVisualStyleBackColor = true;
            this.Fairqual_btn.Click += new System.EventHandler(this.Fairqual_btn_Click);
            // 
            // Stop_btn
            // 
            this.Stop_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Stop_btn.FlatAppearance.BorderSize = 0;
            this.Stop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop_btn.Location = new System.Drawing.Point(14, 382);
            this.Stop_btn.Name = "Stop_btn";
            this.Stop_btn.Size = new System.Drawing.Size(165, 45);
            this.Stop_btn.TabIndex = 5;
            this.Stop_btn.Text = "라인 긴급 중지";
            this.Stop_btn.UseVisualStyleBackColor = false;
            this.Stop_btn.Click += new System.EventHandler(this.Stop_btn_Click);
            // 
            // Main_panel
            // 
            this.Main_panel.BackColor = System.Drawing.SystemColors.Control;
            this.Main_panel.Location = new System.Drawing.Point(185, 74);
            this.Main_panel.Name = "Main_panel";
            this.Main_panel.Size = new System.Drawing.Size(726, 474);
            this.Main_panel.TabIndex = 7;
            // 
            // Time_label
            // 
            this.Time_label.AutoSize = true;
            this.Time_label.Location = new System.Drawing.Point(736, 42);
            this.Time_label.Name = "Time_label";
            this.Time_label.Size = new System.Drawing.Size(29, 12);
            this.Time_label.TabIndex = 8;
            this.Time_label.Text = "time";
            // 
            // State_label
            // 
            this.State_label.AutoSize = true;
            this.State_label.Location = new System.Drawing.Point(12, 41);
            this.State_label.Name = "State_label";
            this.State_label.Size = new System.Drawing.Size(32, 12);
            this.State_label.TabIndex = 9;
            this.State_label.Text = "state";
            this.State_label.TextChanged += new System.EventHandler(this.State_label_TextChanged);
            // 
            // st_start
            // 
            this.st_start.BackColor = System.Drawing.Color.White;
            this.st_start.Location = new System.Drawing.Point(250, 28);
            this.st_start.Multiline = true;
            this.st_start.Name = "st_start";
            this.st_start.Size = new System.Drawing.Size(35, 35);
            this.st_start.TabIndex = 10;
            this.st_start.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "정지 / 대기";
            // 
            // st_stop
            // 
            this.st_stop.BackColor = System.Drawing.Color.Red;
            this.st_stop.Location = new System.Drawing.Point(410, 28);
            this.st_stop.Multiline = true;
            this.st_stop.Name = "st_stop";
            this.st_stop.Size = new System.Drawing.Size(35, 35);
            this.st_stop.TabIndex = 13;
            this.st_stop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "작업 중";
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // st_finish
            // 
            this.st_finish.BackColor = System.Drawing.Color.White;
            this.st_finish.Location = new System.Drawing.Point(591, 28);
            this.st_finish.Multiline = true;
            this.st_finish.Name = "st_finish";
            this.st_finish.Size = new System.Drawing.Size(35, 35);
            this.st_finish.TabIndex = 17;
            this.st_finish.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(556, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "완료";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(933, 560);
            this.Controls.Add(this.st_finish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.st_stop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.st_start);
            this.Controls.Add(this.State_label);
            this.Controls.Add(this.Time_label);
            this.Controls.Add(this.Main_panel);
            this.Controls.Add(this.Stop_btn);
            this.Controls.Add(this.Fairqual_btn);
            this.Controls.Add(this.Def_btn);
            this.Controls.Add(this.Monitor_btn);
            this.Controls.Add(this.Start_btn);
            this.Controls.Add(this.Menu_btn);
            this.Name = "MainForm";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Menu_btn;
        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.Button Monitor_btn;
        private System.Windows.Forms.Button Def_btn;
        private System.Windows.Forms.Button Fairqual_btn;
        private System.Windows.Forms.Button Stop_btn;
        private System.Windows.Forms.Panel Main_panel;
        private System.Windows.Forms.Label Time_label;
        private System.Windows.Forms.TextBox st_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox st_stop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox st_finish;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label State_label;
    }
}


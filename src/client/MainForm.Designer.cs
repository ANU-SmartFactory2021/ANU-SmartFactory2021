
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.Menu_btn.Size = new System.Drawing.Size(144, 45);
            this.Menu_btn.TabIndex = 0;
            this.Menu_btn.Text = "메뉴";
            this.Menu_btn.UseVisualStyleBackColor = false;
            this.Menu_btn.Click += new System.EventHandler(this.Menu_btn_Click);
            // 
            // Start_btn
            // 
            this.Start_btn.Location = new System.Drawing.Point(14, 134);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(144, 45);
            this.Start_btn.TabIndex = 1;
            this.Start_btn.Text = "구별 작업 시작";
            this.Start_btn.UseVisualStyleBackColor = true;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // Monitor_btn
            // 
            this.Monitor_btn.Location = new System.Drawing.Point(14, 195);
            this.Monitor_btn.Name = "Monitor_btn";
            this.Monitor_btn.Size = new System.Drawing.Size(144, 45);
            this.Monitor_btn.TabIndex = 2;
            this.Monitor_btn.Text = "라인 모니터링";
            this.Monitor_btn.UseVisualStyleBackColor = true;
            this.Monitor_btn.Click += new System.EventHandler(this.Monitor_btn_Click);
            // 
            // Def_btn
            // 
            this.Def_btn.Location = new System.Drawing.Point(14, 258);
            this.Def_btn.Name = "Def_btn";
            this.Def_btn.Size = new System.Drawing.Size(144, 45);
            this.Def_btn.TabIndex = 3;
            this.Def_btn.Text = "불량품 현황";
            this.Def_btn.UseVisualStyleBackColor = true;
            this.Def_btn.Click += new System.EventHandler(this.Def_btn_Click);
            // 
            // Fairqual_btn
            // 
            this.Fairqual_btn.Location = new System.Drawing.Point(14, 320);
            this.Fairqual_btn.Name = "Fairqual_btn";
            this.Fairqual_btn.Size = new System.Drawing.Size(144, 45);
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
            this.Stop_btn.Size = new System.Drawing.Size(144, 45);
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
            this.Main_panel.Size = new System.Drawing.Size(589, 352);
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
            this.State_label.Location = new System.Drawing.Point(185, 41);
            this.State_label.Name = "State_label";
            this.State_label.Size = new System.Drawing.Size(32, 12);
            this.State_label.TabIndex = 9;
            this.State_label.Text = "state";
            this.State_label.TextChanged += new System.EventHandler(this.State_label_TextChanged);
            // 
            // timer1
            // 
            
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.Label State_label;
        private System.Windows.Forms.Timer timer1;
    }
}


namespace TCPIP_Sample_CSharp {
	partial class main {
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose( bool disposing ) {
			if( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent() {
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_server_setting_start = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tb_server_setting_port = new System.Windows.Forms.TextBox();
			this.rbtn_server = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btn_client_setting_connect = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.tb_client_setting_port = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_client_setting_ip = new System.Windows.Forms.TextBox();
			this.rbtn_client = new System.Windows.Forms.RadioButton();
			this.lbox_dialog = new System.Windows.Forms.ListBox();
			this.tb_input = new System.Windows.Forms.TextBox();
			this.btn_send = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_server_setting_start);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.tb_server_setting_port);
			this.groupBox1.Controls.Add(this.rbtn_server);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
			this.groupBox1.Size = new System.Drawing.Size(172, 108);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Server Setting";
			// 
			// btn_server_setting_start
			// 
			this.btn_server_setting_start.Location = new System.Drawing.Point(10, 76);
			this.btn_server_setting_start.Name = "btn_server_setting_start";
			this.btn_server_setting_start.Size = new System.Drawing.Size(150, 23);
			this.btn_server_setting_start.TabIndex = 4;
			this.btn_server_setting_start.Text = "Server Start";
			this.btn_server_setting_start.UseVisualStyleBackColor = true;
			this.btn_server_setting_start.Click += new System.EventHandler(this.btn_server_setting_start_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "Server Port";
			// 
			// tb_server_setting_port
			// 
			this.tb_server_setting_port.Location = new System.Drawing.Point(81, 49);
			this.tb_server_setting_port.Name = "tb_server_setting_port";
			this.tb_server_setting_port.Size = new System.Drawing.Size(79, 21);
			this.tb_server_setting_port.TabIndex = 2;
			// 
			// rbtn_server
			// 
			this.rbtn_server.AutoSize = true;
			this.rbtn_server.Checked = true;
			this.rbtn_server.Location = new System.Drawing.Point(8, 22);
			this.rbtn_server.Name = "rbtn_server";
			this.rbtn_server.Size = new System.Drawing.Size(59, 16);
			this.rbtn_server.TabIndex = 1;
			this.rbtn_server.TabStop = true;
			this.rbtn_server.Text = "Server";
			this.rbtn_server.UseVisualStyleBackColor = true;
			this.rbtn_server.Click += new System.EventHandler(this.on_click_server_client);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btn_client_setting_connect);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.tb_client_setting_port);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.tb_client_setting_ip);
			this.groupBox2.Controls.Add(this.rbtn_client);
			this.groupBox2.Location = new System.Drawing.Point(12, 126);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
			this.groupBox2.Size = new System.Drawing.Size(175, 136);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Client Setting";
			// 
			// btn_client_setting_connect
			// 
			this.btn_client_setting_connect.Enabled = false;
			this.btn_client_setting_connect.Location = new System.Drawing.Point(10, 103);
			this.btn_client_setting_connect.Name = "btn_client_setting_connect";
			this.btn_client_setting_connect.Size = new System.Drawing.Size(153, 23);
			this.btn_client_setting_connect.TabIndex = 11;
			this.btn_client_setting_connect.Text = "Connect to server";
			this.btn_client_setting_connect.UseVisualStyleBackColor = true;
			this.btn_client_setting_connect.Click += new System.EventHandler(this.btn_client_setting_connect_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 12);
			this.label3.TabIndex = 10;
			this.label3.Text = "Server Port";
			// 
			// tb_client_setting_port
			// 
			this.tb_client_setting_port.Enabled = false;
			this.tb_client_setting_port.Location = new System.Drawing.Point(84, 76);
			this.tb_client_setting_port.Name = "tb_client_setting_port";
			this.tb_client_setting_port.Size = new System.Drawing.Size(79, 21);
			this.tb_client_setting_port.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 12);
			this.label2.TabIndex = 8;
			this.label2.Text = "Server IP";
			// 
			// tb_client_setting_ip
			// 
			this.tb_client_setting_ip.Enabled = false;
			this.tb_client_setting_ip.Location = new System.Drawing.Point(84, 49);
			this.tb_client_setting_ip.Name = "tb_client_setting_ip";
			this.tb_client_setting_ip.Size = new System.Drawing.Size(79, 21);
			this.tb_client_setting_ip.TabIndex = 7;
			// 
			// rbtn_client
			// 
			this.rbtn_client.AutoSize = true;
			this.rbtn_client.Location = new System.Drawing.Point(8, 22);
			this.rbtn_client.Name = "rbtn_client";
			this.rbtn_client.Size = new System.Drawing.Size(55, 16);
			this.rbtn_client.TabIndex = 1;
			this.rbtn_client.TabStop = true;
			this.rbtn_client.Text = "Client";
			this.rbtn_client.UseVisualStyleBackColor = true;
			this.rbtn_client.Click += new System.EventHandler(this.on_click_server_client);
			// 
			// lbox_dialog
			// 
			this.lbox_dialog.FormattingEnabled = true;
			this.lbox_dialog.ItemHeight = 12;
			this.lbox_dialog.Location = new System.Drawing.Point(190, 12);
			this.lbox_dialog.Name = "lbox_dialog";
			this.lbox_dialog.Size = new System.Drawing.Size(593, 400);
			this.lbox_dialog.TabIndex = 4;
			// 
			// tb_input
			// 
			this.tb_input.Location = new System.Drawing.Point(226, 420);
			this.tb_input.Name = "tb_input";
			this.tb_input.Size = new System.Drawing.Size(464, 21);
			this.tb_input.TabIndex = 5;
			this.tb_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_input_KeyPress);
			// 
			// btn_send
			// 
			this.btn_send.Location = new System.Drawing.Point(696, 418);
			this.btn_send.Name = "btn_send";
			this.btn_send.Size = new System.Drawing.Size(87, 23);
			this.btn_send.TabIndex = 6;
			this.btn_send.Text = "Send";
			this.btn_send.UseVisualStyleBackColor = true;
			this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(188, 423);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 12);
			this.label4.TabIndex = 7;
			this.label4.Text = "Input";
			// 
			// main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(794, 452);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btn_send);
			this.Controls.Add(this.tb_input);
			this.Controls.Add(this.lbox_dialog);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "main";
			this.Text = "TCP/IP Sample";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
			this.Shown += new System.EventHandler(this.main_Shown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_server_setting_port;
		private System.Windows.Forms.RadioButton rbtn_server;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btn_client_setting_connect;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tb_client_setting_port;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_client_setting_ip;
		private System.Windows.Forms.RadioButton rbtn_client;
		private System.Windows.Forms.Button btn_server_setting_start;
		private System.Windows.Forms.ListBox lbox_dialog;
		private System.Windows.Forms.TextBox tb_input;
		private System.Windows.Forms.Button btn_send;
		private System.Windows.Forms.Label label4;
	}
}


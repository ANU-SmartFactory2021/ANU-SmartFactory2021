namespace WindowsFormsApp2
{
    partial class Model_set
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbox_model_temp = new System.Windows.Forms.TextBox();
            this.rtxtbox_models = new System.Windows.Forms.RichTextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.txtbox_model_name = new System.Windows.Forms.TextBox();
            this.txtbox_model_humidity = new System.Windows.Forms.TextBox();
            this.txtbox_model_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridView_Model = new System.Windows.Forms.DataGridView();
            this.txtbox_model_id_sch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Model)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1023, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 41;
            this.label10.Text = "모델목록";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(485, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(283, 15);
            this.label9.TabIndex = 40;
            this.label9.Text = "수정과 삭제는 모델 id 입력 후 버튼 클릭.";
            // 
            // txtbox_model_temp
            // 
            this.txtbox_model_temp.Location = new System.Drawing.Point(277, 238);
            this.txtbox_model_temp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_model_temp.Name = "txtbox_model_temp";
            this.txtbox_model_temp.Size = new System.Drawing.Size(172, 25);
            this.txtbox_model_temp.TabIndex = 37;
            // 
            // rtxtbox_models
            // 
            this.rtxtbox_models.Location = new System.Drawing.Point(899, 50);
            this.rtxtbox_models.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtxtbox_models.Name = "rtxtbox_models";
            this.rtxtbox_models.Size = new System.Drawing.Size(441, 263);
            this.rtxtbox_models.TabIndex = 36;
            this.rtxtbox_models.Text = "";
            this.rtxtbox_models.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(1265, 552);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 22);
            this.btn_search.TabIndex = 35;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.Search_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(538, 441);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 22);
            this.btn_Update.TabIndex = 34;
            this.btn_Update.Text = "변경";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(350, 441);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 22);
            this.btn_Delete.TabIndex = 33;
            this.btn_Delete.Text = "삭제";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(177, 441);
            this.btn_Insert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 22);
            this.btn_Insert.TabIndex = 32;
            this.btn_Insert.Text = "생성";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // txtbox_model_name
            // 
            this.txtbox_model_name.Location = new System.Drawing.Point(277, 370);
            this.txtbox_model_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_model_name.Name = "txtbox_model_name";
            this.txtbox_model_name.Size = new System.Drawing.Size(172, 25);
            this.txtbox_model_name.TabIndex = 31;
            // 
            // txtbox_model_humidity
            // 
            this.txtbox_model_humidity.Location = new System.Drawing.Point(277, 306);
            this.txtbox_model_humidity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_model_humidity.Name = "txtbox_model_humidity";
            this.txtbox_model_humidity.Size = new System.Drawing.Size(172, 25);
            this.txtbox_model_humidity.TabIndex = 30;
            // 
            // txtbox_model_id
            // 
            this.txtbox_model_id.Location = new System.Drawing.Point(277, 170);
            this.txtbox_model_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_model_id.Name = "txtbox_model_id";
            this.txtbox_model_id.Size = new System.Drawing.Size(172, 25);
            this.txtbox_model_id.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "제품명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "적정습도";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "적정온도";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "모델 id";
            // 
            // DataGridView_Model
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Model.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView_Model.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView_Model.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView_Model.Location = new System.Drawing.Point(899, 339);
            this.DataGridView_Model.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridView_Model.Name = "DataGridView_Model";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView_Model.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView_Model.RowHeadersWidth = 51;
            this.DataGridView_Model.RowTemplate.Height = 27;
            this.DataGridView_Model.Size = new System.Drawing.Size(441, 208);
            this.DataGridView_Model.TabIndex = 42;
            this.DataGridView_Model.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Model_view_CellClick);
            this.DataGridView_Model.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // txtbox_model_id_sch
            // 
            this.txtbox_model_id_sch.Location = new System.Drawing.Point(1087, 551);
            this.txtbox_model_id_sch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtbox_model_id_sch.Name = "txtbox_model_id_sch";
            this.txtbox_model_id_sch.Size = new System.Drawing.Size(172, 25);
            this.txtbox_model_id_sch.TabIndex = 27;
            // 
            // Model_set
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 690);
            this.Controls.Add(this.DataGridView_Model);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtbox_model_temp);
            this.Controls.Add(this.rtxtbox_models);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.txtbox_model_name);
            this.Controls.Add(this.txtbox_model_humidity);
            this.Controls.Add(this.txtbox_model_id_sch);
            this.Controls.Add(this.txtbox_model_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Model_set";
            this.Text = "m2";
            this.Load += new System.EventHandler(this.Model_set_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Model)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbox_model_temp;
        private System.Windows.Forms.RichTextBox rtxtbox_models;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.TextBox txtbox_model_name;
        private System.Windows.Forms.TextBox txtbox_model_humidity;
        private System.Windows.Forms.TextBox txtbox_model_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridView_Model;
        private System.Windows.Forms.TextBox txtbox_model_id_sch;
    }
}
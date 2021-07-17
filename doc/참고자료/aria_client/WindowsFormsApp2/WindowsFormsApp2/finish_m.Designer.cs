namespace WindowsFormsApp2
{
    partial class Finish_m
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
            this.DataGridView2 = new System.Windows.Forms.DataGridView();
            this.insert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.prod_color_box = new System.Windows.Forms.CheckBox();
            this.prod_color_text = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.line_text = new System.Windows.Forms.ComboBox();
            this.model_name_text = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.line_box = new System.Windows.Forms.CheckBox();
            this.lot_id_text = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.date_time_box = new System.Windows.Forms.CheckBox();
            this.model_name_box = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lot_id_box = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView2
            // 
            this.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView2.Location = new System.Drawing.Point(12, 245);
            this.DataGridView2.Name = "DataGridView2";
            this.DataGridView2.RowHeadersWidth = 51;
            this.DataGridView2.RowTemplate.Height = 27;
            this.DataGridView2.Size = new System.Drawing.Size(995, 456);
            this.DataGridView2.TabIndex = 3;
            // 
            // insert
            // 
            this.insert.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.insert.Location = new System.Drawing.Point(909, 12);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(98, 227);
            this.insert.TabIndex = 5;
            this.insert.Text = "검색";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.prod_color_box);
            this.groupBox1.Controls.Add(this.prod_color_text);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.line_text);
            this.groupBox1.Controls.Add(this.model_name_text);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.line_box);
            this.groupBox1.Controls.Add(this.lot_id_text);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.date_time_box);
            this.groupBox1.Controls.Add(this.model_name_box);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.lot_id_box);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(891, 227);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "완료재고";
            // 
            // prod_color_box
            // 
            this.prod_color_box.AutoSize = true;
            this.prod_color_box.Location = new System.Drawing.Point(446, 92);
            this.prod_color_box.Name = "prod_color_box";
            this.prod_color_box.Size = new System.Drawing.Size(18, 17);
            this.prod_color_box.TabIndex = 8;
            this.prod_color_box.UseVisualStyleBackColor = true;
            // 
            // prod_color_text
            // 
            this.prod_color_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prod_color_text.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.prod_color_text.FormattingEnabled = true;
            this.prod_color_text.Location = new System.Drawing.Point(537, 87);
            this.prod_color_text.Name = "prod_color_text";
            this.prod_color_text.Size = new System.Drawing.Size(156, 31);
            this.prod_color_text.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(447, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "~";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(73, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "제품 명";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(471, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "색상";
            // 
            // line_text
            // 
            this.line_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.line_text.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.line_text.FormattingEnabled = true;
            this.line_text.Location = new System.Drawing.Point(537, 42);
            this.line_text.Name = "line_text";
            this.line_text.Size = new System.Drawing.Size(156, 31);
            this.line_text.TabIndex = 10;
            // 
            // model_name_text
            // 
            this.model_name_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.model_name_text.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.model_name_text.FormattingEnabled = true;
            this.model_name_text.Location = new System.Drawing.Point(173, 46);
            this.model_name_text.Name = "model_name_text";
            this.model_name_text.Size = new System.Drawing.Size(156, 31);
            this.model_name_text.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(470, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "라인";
            // 
            // line_box
            // 
            this.line_box.AutoSize = true;
            this.line_box.Location = new System.Drawing.Point(446, 55);
            this.line_box.Name = "line_box";
            this.line_box.Size = new System.Drawing.Size(18, 17);
            this.line_box.TabIndex = 7;
            this.line_box.UseVisualStyleBackColor = true;
            // 
            // lot_id_text
            // 
            this.lot_id_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lot_id_text.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lot_id_text.FormattingEnabled = true;
            this.lot_id_text.Location = new System.Drawing.Point(219, 87);
            this.lot_id_text.Name = "lot_id_text";
            this.lot_id_text.Size = new System.Drawing.Size(156, 31);
            this.lot_id_text.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("굴림", 13.8F);
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 124);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 34);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(73, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "작업지시 ID";
            // 
            // date_time_box
            // 
            this.date_time_box.AutoSize = true;
            this.date_time_box.Location = new System.Drawing.Point(43, 139);
            this.date_time_box.Name = "date_time_box";
            this.date_time_box.Size = new System.Drawing.Size(18, 17);
            this.date_time_box.TabIndex = 7;
            this.date_time_box.UseVisualStyleBackColor = true;
            // 
            // model_name_box
            // 
            this.model_name_box.AutoSize = true;
            this.model_name_box.Location = new System.Drawing.Point(41, 59);
            this.model_name_box.Name = "model_name_box";
            this.model_name_box.Size = new System.Drawing.Size(18, 17);
            this.model_name_box.TabIndex = 7;
            this.model_name_box.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(67, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "날짜";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("굴림", 13.8F);
            this.dateTimePicker2.Font = new System.Drawing.Font("굴림", 13.8F);
            this.dateTimePicker2.Location = new System.Drawing.Point(474, 124);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(294, 34);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // lot_id_box
            // 
            this.lot_id_box.AutoSize = true;
            this.lot_id_box.Location = new System.Drawing.Point(41, 96);
            this.lot_id_box.Name = "lot_id_box";
            this.lot_id_box.Size = new System.Drawing.Size(18, 17);
            this.lot_id_box.TabIndex = 7;
            this.lot_id_box.UseVisualStyleBackColor = true;
            // 
            // Finish_m
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 713);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DataGridView2);
            this.Name = "Finish_m";
            this.Text = "finish_m";
            this.Load += new System.EventHandler(this.Finish_m_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGridView2;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox prod_color_box;
        private System.Windows.Forms.ComboBox prod_color_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox line_text;
        private System.Windows.Forms.ComboBox model_name_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox line_box;
        private System.Windows.Forms.ComboBox lot_id_text;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox date_time_box;
        private System.Windows.Forms.CheckBox model_name_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.CheckBox lot_id_box;
    }
}
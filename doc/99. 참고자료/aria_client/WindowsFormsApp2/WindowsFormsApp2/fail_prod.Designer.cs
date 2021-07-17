namespace WindowsFormsApp2
{
    partial class Fail_prod
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
            this.DataGrid_md_fail_View = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.prod_color_box = new System.Windows.Forms.CheckBox();
            this.combox_prod_color = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.combox_line_id = new System.Windows.Forms.ComboBox();
            this.combox_model_name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.line_box = new System.Windows.Forms.CheckBox();
            this.combox_lot_id = new System.Windows.Forms.ComboBox();
            this.dateTime_start = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.date_time_box = new System.Windows.Forms.CheckBox();
            this.model_name_box = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTime_end = new System.Windows.Forms.DateTimePicker();
            this.lot_id_box = new System.Windows.Forms.CheckBox();
            this.btn_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_md_fail_View)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGrid_md_fail_View
            // 
            this.DataGrid_md_fail_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_md_fail_View.Location = new System.Drawing.Point(12, 245);
            this.DataGrid_md_fail_View.Name = "DataGrid_md_fail_View";
            this.DataGrid_md_fail_View.RowHeadersWidth = 51;
            this.DataGrid_md_fail_View.RowTemplate.Height = 27;
            this.DataGrid_md_fail_View.Size = new System.Drawing.Size(932, 585);
            this.DataGrid_md_fail_View.TabIndex = 0;
            this.DataGrid_md_fail_View.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.prod_color_box);
            this.groupBox1.Controls.Add(this.combox_prod_color);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.combox_line_id);
            this.groupBox1.Controls.Add(this.combox_model_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.line_box);
            this.groupBox1.Controls.Add(this.combox_lot_id);
            this.groupBox1.Controls.Add(this.dateTime_start);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.date_time_box);
            this.groupBox1.Controls.Add(this.model_name_box);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTime_end);
            this.groupBox1.Controls.Add(this.lot_id_box);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(828, 227);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "불량재고";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // prod_color_box
            // 
            this.prod_color_box.AutoSize = true;
            this.prod_color_box.Location = new System.Drawing.Point(438, 96);
            this.prod_color_box.Name = "prod_color_box";
            this.prod_color_box.Size = new System.Drawing.Size(18, 17);
            this.prod_color_box.TabIndex = 8;
            this.prod_color_box.UseVisualStyleBackColor = true;
            // 
            // combox_prod_color
            // 
            this.combox_prod_color.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combox_prod_color.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.combox_prod_color.FormattingEnabled = true;
            this.combox_prod_color.Location = new System.Drawing.Point(529, 91);
            this.combox_prod_color.Name = "combox_prod_color";
            this.combox_prod_color.Size = new System.Drawing.Size(156, 31);
            this.combox_prod_color.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(444, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "~";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(65, 53);
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
            this.label5.Location = new System.Drawing.Point(463, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "색상";
            this.label5.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // combox_line_id
            // 
            this.combox_line_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combox_line_id.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.combox_line_id.FormattingEnabled = true;
            this.combox_line_id.Location = new System.Drawing.Point(529, 46);
            this.combox_line_id.Name = "combox_line_id";
            this.combox_line_id.Size = new System.Drawing.Size(156, 31);
            this.combox_line_id.TabIndex = 10;
            // 
            // combox_model_name
            // 
            this.combox_model_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combox_model_name.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.combox_model_name.FormattingEnabled = true;
            this.combox_model_name.Location = new System.Drawing.Point(165, 50);
            this.combox_model_name.Name = "combox_model_name";
            this.combox_model_name.Size = new System.Drawing.Size(156, 31);
            this.combox_model_name.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(462, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "라인";
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // line_box
            // 
            this.line_box.AutoSize = true;
            this.line_box.Location = new System.Drawing.Point(438, 59);
            this.line_box.Name = "line_box";
            this.line_box.Size = new System.Drawing.Size(18, 17);
            this.line_box.TabIndex = 7;
            this.line_box.UseVisualStyleBackColor = true;
            // 
            // combox_lot_id
            // 
            this.combox_lot_id.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combox_lot_id.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.combox_lot_id.FormattingEnabled = true;
            this.combox_lot_id.Location = new System.Drawing.Point(211, 91);
            this.combox_lot_id.Name = "combox_lot_id";
            this.combox_lot_id.Size = new System.Drawing.Size(156, 31);
            this.combox_lot_id.TabIndex = 6;
            // 
            // dateTime_start
            // 
            this.dateTime_start.Font = new System.Drawing.Font("굴림", 13.8F);
            this.dateTime_start.Location = new System.Drawing.Point(140, 142);
            this.dateTime_start.Name = "dateTime_start";
            this.dateTime_start.Size = new System.Drawing.Size(298, 34);
            this.dateTime_start.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(65, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "작업지시 ID";
            // 
            // date_time_box
            // 
            this.date_time_box.AutoSize = true;
            this.date_time_box.Location = new System.Drawing.Point(40, 157);
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
            this.label4.Location = new System.Drawing.Point(64, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "날짜";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // dateTime_end
            // 
            this.dateTime_end.CalendarFont = new System.Drawing.Font("굴림", 13.8F);
            this.dateTime_end.Font = new System.Drawing.Font("굴림", 13.8F);
            this.dateTime_end.Location = new System.Drawing.Point(471, 142);
            this.dateTime_end.Name = "dateTime_end";
            this.dateTime_end.Size = new System.Drawing.Size(294, 34);
            this.dateTime_end.TabIndex = 4;
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
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_search.Location = new System.Drawing.Point(846, 21);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(98, 218);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Fail_prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 842);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DataGrid_md_fail_View);
            this.Name = "Fail_prod";
            this.Text = "fail_prod";
            this.Load += new System.EventHandler(this.Fail_prod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_md_fail_View)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGrid_md_fail_View;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox combox_model_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTime_start;
        private System.Windows.Forms.DateTimePicker dateTime_end;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox model_name_box;
        private System.Windows.Forms.CheckBox prod_color_box;
        private System.Windows.Forms.ComboBox combox_line_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox line_box;
        private System.Windows.Forms.CheckBox date_time_box;
        private System.Windows.Forms.CheckBox lot_id_box;
        private System.Windows.Forms.ComboBox combox_lot_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combox_prod_color;
        private System.Windows.Forms.Label label5;
    }
}
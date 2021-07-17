namespace WindowsFormsApp2
{
    partial class Lot_direct
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.numbox_humid_margin = new System.Windows.Forms.NumericUpDown();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbox_model_id = new System.Windows.Forms.Label();
            this.numbox_temp_margin = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.numbox_prod_fail = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.combox_model_color = new System.Windows.Forms.ComboBox();
            this.combox_model_name = new System.Windows.Forms.ComboBox();
            this.txtbox_lot_id = new System.Windows.Forms.TextBox();
            this.numbox_prod_count = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbox_pd_speed = new System.Windows.Forms.Label();
            this.txtbox_model_humid = new System.Windows.Forms.Label();
            this.txtbox_model_temp = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combox_line_id = new System.Windows.Forms.ComboBox();
            this.DataGrid_lots_list_view = new System.Windows.Forms.DataGridView();
            this.txtbox_lot_list = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbox_humid_margin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbox_temp_margin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbox_prod_fail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbox_prod_count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_lots_list_view)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.numbox_humid_margin);
            this.groupBox1.Controls.Add(this.btn_insert);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtbox_model_id);
            this.groupBox1.Controls.Add(this.numbox_temp_margin);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.numbox_prod_fail);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.combox_model_color);
            this.groupBox1.Controls.Add(this.combox_model_name);
            this.groupBox1.Controls.Add(this.txtbox_lot_id);
            this.groupBox1.Controls.Add(this.numbox_prod_count);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtbox_pd_speed);
            this.groupBox1.Controls.Add(this.txtbox_model_humid);
            this.groupBox1.Controls.Add(this.txtbox_model_temp);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.combox_line_id);
            this.groupBox1.Location = new System.Drawing.Point(10, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 691);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "작업 지시";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(427, 632);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(150, 44);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = "작업 취소";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // numbox_humid_margin
            // 
            this.numbox_humid_margin.Location = new System.Drawing.Point(184, 435);
            this.numbox_humid_margin.Name = "numbox_humid_margin";
            this.numbox_humid_margin.Size = new System.Drawing.Size(120, 25);
            this.numbox_humid_margin.TabIndex = 22;
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(427, 580);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(150, 46);
            this.btn_insert.TabIndex = 0;
            this.btn_insert.Text = "작업 지시";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label22.Location = new System.Drawing.Point(20, 436);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(147, 24);
            this.label22.TabIndex = 23;
            this.label22.Text = "습도 margin :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(401, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "제품 코드 :";
            // 
            // txtbox_model_id
            // 
            this.txtbox_model_id.AutoSize = true;
            this.txtbox_model_id.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_model_id.Location = new System.Drawing.Point(561, 407);
            this.txtbox_model_id.Name = "txtbox_model_id";
            this.txtbox_model_id.Size = new System.Drawing.Size(23, 24);
            this.txtbox_model_id.TabIndex = 4;
            this.txtbox_model_id.Text = "-";
            this.txtbox_model_id.Click += new System.EventHandler(this.Label4_Click);
            // 
            // numbox_temp_margin
            // 
            this.numbox_temp_margin.Location = new System.Drawing.Point(184, 375);
            this.numbox_temp_margin.Name = "numbox_temp_margin";
            this.numbox_temp_margin.Size = new System.Drawing.Size(120, 25);
            this.numbox_temp_margin.TabIndex = 20;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.Location = new System.Drawing.Point(20, 376);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(147, 24);
            this.label21.TabIndex = 21;
            this.label21.Text = "온도 margin :";
            // 
            // numbox_prod_fail
            // 
            this.numbox_prod_fail.Location = new System.Drawing.Point(184, 314);
            this.numbox_prod_fail.Name = "numbox_prod_fail";
            this.numbox_prod_fail.Size = new System.Drawing.Size(120, 25);
            this.numbox_prod_fail.TabIndex = 18;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label20.Location = new System.Drawing.Point(20, 315);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(154, 24);
            this.label20.TabIndex = 19;
            this.label20.Text = "불량율 제한 :";
            // 
            // combox_model_color
            // 
            this.combox_model_color.FormattingEnabled = true;
            this.combox_model_color.Location = new System.Drawing.Point(183, 212);
            this.combox_model_color.Name = "combox_model_color";
            this.combox_model_color.Size = new System.Drawing.Size(121, 23);
            this.combox_model_color.TabIndex = 17;
            // 
            // combox_model_name
            // 
            this.combox_model_name.FormattingEnabled = true;
            this.combox_model_name.Location = new System.Drawing.Point(184, 141);
            this.combox_model_name.Name = "combox_model_name";
            this.combox_model_name.Size = new System.Drawing.Size(121, 23);
            this.combox_model_name.TabIndex = 17;
            // 
            // txtbox_lot_id
            // 
            this.txtbox_lot_id.Location = new System.Drawing.Point(442, 81);
            this.txtbox_lot_id.Name = "txtbox_lot_id";
            this.txtbox_lot_id.Size = new System.Drawing.Size(135, 25);
            this.txtbox_lot_id.TabIndex = 16;
            // 
            // numbox_prod_count
            // 
            this.numbox_prod_count.Location = new System.Drawing.Point(183, 262);
            this.numbox_prod_count.Name = "numbox_prod_count";
            this.numbox_prod_count.Size = new System.Drawing.Size(120, 25);
            this.numbox_prod_count.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(366, 357);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 24);
            this.label11.TabIndex = 11;
            this.label11.Text = "예상 소요 시간 :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(20, 262);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 24);
            this.label12.TabIndex = 8;
            this.label12.Text = "수 량 :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(401, 519);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 24);
            this.label9.TabIndex = 6;
            this.label9.Text = "적정 습도 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(401, 465);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "적정 온도 :";
            // 
            // txtbox_pd_speed
            // 
            this.txtbox_pd_speed.AutoSize = true;
            this.txtbox_pd_speed.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_pd_speed.Location = new System.Drawing.Point(558, 357);
            this.txtbox_pd_speed.Name = "txtbox_pd_speed";
            this.txtbox_pd_speed.Size = new System.Drawing.Size(23, 24);
            this.txtbox_pd_speed.TabIndex = 4;
            this.txtbox_pd_speed.Text = "-";
            this.txtbox_pd_speed.Click += new System.EventHandler(this.Label4_Click);
            // 
            // txtbox_model_humid
            // 
            this.txtbox_model_humid.AutoSize = true;
            this.txtbox_model_humid.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_model_humid.Location = new System.Drawing.Point(561, 519);
            this.txtbox_model_humid.Name = "txtbox_model_humid";
            this.txtbox_model_humid.Size = new System.Drawing.Size(23, 24);
            this.txtbox_model_humid.TabIndex = 4;
            this.txtbox_model_humid.Text = "-";
            this.txtbox_model_humid.Click += new System.EventHandler(this.Label4_Click);
            // 
            // txtbox_model_temp
            // 
            this.txtbox_model_temp.AutoSize = true;
            this.txtbox_model_temp.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbox_model_temp.Location = new System.Drawing.Point(561, 465);
            this.txtbox_model_temp.Name = "txtbox_model_temp";
            this.txtbox_model_temp.Size = new System.Drawing.Size(23, 24);
            this.txtbox_model_temp.TabIndex = 4;
            this.txtbox_model_temp.Text = "-";
            this.txtbox_model_temp.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label19.Location = new System.Drawing.Point(20, 212);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(130, 24);
            this.label19.TabIndex = 4;
            this.label19.Text = "제품 색상 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(20, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "제품명 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(314, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "작업지시 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(20, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "라인 :";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // combox_line_id
            // 
            this.combox_line_id.FormattingEnabled = true;
            this.combox_line_id.Location = new System.Drawing.Point(183, 80);
            this.combox_line_id.Name = "combox_line_id";
            this.combox_line_id.Size = new System.Drawing.Size(121, 23);
            this.combox_line_id.TabIndex = 2;
            this.combox_line_id.SelectedIndexChanged += new System.EventHandler(this.Line_text_SelectedIndexChanged);
            // 
            // DataGrid_lots_list_view
            // 
            this.DataGrid_lots_list_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_lots_list_view.Location = new System.Drawing.Point(616, 248);
            this.DataGrid_lots_list_view.Name = "DataGrid_lots_list_view";
            this.DataGrid_lots_list_view.RowHeadersWidth = 51;
            this.DataGrid_lots_list_view.RowTemplate.Height = 27;
            this.DataGrid_lots_list_view.Size = new System.Drawing.Size(926, 511);
            this.DataGrid_lots_list_view.TabIndex = 2;
            this.DataGrid_lots_list_view.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_lots_list_view_CellClick);
            this.DataGrid_lots_list_view.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_lots_list_view_CellContentDoubleClick);
            this.DataGrid_lots_list_view.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_lots_list_view_CellDoubleClick);
            // 
            // txtbox_lot_list
            // 
            this.txtbox_lot_list.Location = new System.Drawing.Point(616, 77);
            this.txtbox_lot_list.Multiline = true;
            this.txtbox_lot_list.Name = "txtbox_lot_list";
            this.txtbox_lot_list.Size = new System.Drawing.Size(926, 165);
            this.txtbox_lot_list.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(616, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "TBL_LINE";
            // 
            // Lot_direct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 771);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbox_lot_list);
            this.Controls.Add(this.DataGrid_lots_list_view);
            this.Controls.Add(this.groupBox1);
            this.Name = "Lot_direct";
            this.Text = "Model";
            this.Load += new System.EventHandler(this.Lot_direct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbox_humid_margin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbox_temp_margin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbox_prod_fail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbox_prod_count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_lots_list_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox combox_line_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.NumericUpDown numbox_prod_count;
        private System.Windows.Forms.Label txtbox_pd_speed;
        private System.Windows.Forms.Label txtbox_model_humid;
        private System.Windows.Forms.Label txtbox_model_temp;
        private System.Windows.Forms.Label txtbox_model_id;
        private System.Windows.Forms.ComboBox combox_model_name;
        private System.Windows.Forms.TextBox txtbox_lot_id;
        private System.Windows.Forms.NumericUpDown numbox_prod_fail;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox combox_model_color;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown numbox_humid_margin;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown numbox_temp_margin;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView DataGrid_lots_list_view;
        private System.Windows.Forms.TextBox txtbox_lot_list;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_delete;
    }
}
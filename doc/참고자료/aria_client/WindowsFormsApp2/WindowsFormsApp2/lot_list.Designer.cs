namespace WindowsFormsApp2
{
    partial class Lot_list
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datetime_box = new System.Windows.Forms.CheckBox();
            this.oper_id_box = new System.Windows.Forms.CheckBox();
            this.model_name_box = new System.Windows.Forms.CheckBox();
            this.line_box = new System.Windows.Forms.CheckBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTime_end = new System.Windows.Forms.DateTimePicker();
            this.dateTime_start = new System.Windows.Forms.DateTimePicker();
            this.combox_model_name = new System.Windows.Forms.ComboBox();
            this.combox_line_id = new System.Windows.Forms.ComboBox();
            this.txtbox_oper_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid_line_view = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_line_view)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datetime_box);
            this.groupBox1.Controls.Add(this.oper_id_box);
            this.groupBox1.Controls.Add(this.model_name_box);
            this.groupBox1.Controls.Add(this.line_box);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateTime_end);
            this.groupBox1.Controls.Add(this.dateTime_start);
            this.groupBox1.Controls.Add(this.combox_model_name);
            this.groupBox1.Controls.Add(this.combox_line_id);
            this.groupBox1.Controls.Add(this.txtbox_oper_id);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 446);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "작업 이력 list";
            // 
            // datetime_box
            // 
            this.datetime_box.AutoSize = true;
            this.datetime_box.Location = new System.Drawing.Point(29, 231);
            this.datetime_box.Name = "datetime_box";
            this.datetime_box.Size = new System.Drawing.Size(18, 17);
            this.datetime_box.TabIndex = 6;
            this.datetime_box.UseVisualStyleBackColor = true;
            this.datetime_box.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // oper_id_box
            // 
            this.oper_id_box.AutoSize = true;
            this.oper_id_box.Location = new System.Drawing.Point(29, 185);
            this.oper_id_box.Name = "oper_id_box";
            this.oper_id_box.Size = new System.Drawing.Size(18, 17);
            this.oper_id_box.TabIndex = 6;
            this.oper_id_box.UseVisualStyleBackColor = true;
            this.oper_id_box.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // model_name_box
            // 
            this.model_name_box.AutoSize = true;
            this.model_name_box.Location = new System.Drawing.Point(29, 134);
            this.model_name_box.Name = "model_name_box";
            this.model_name_box.Size = new System.Drawing.Size(18, 17);
            this.model_name_box.TabIndex = 6;
            this.model_name_box.UseVisualStyleBackColor = true;
            // 
            // line_box
            // 
            this.line_box.AutoSize = true;
            this.line_box.Location = new System.Drawing.Point(29, 85);
            this.line_box.Name = "line_box";
            this.line_box.Size = new System.Drawing.Size(18, 17);
            this.line_box.TabIndex = 6;
            this.line_box.UseVisualStyleBackColor = true;
            this.line_box.CheckedChanged += new System.EventHandler(this.Line_box_CheckedChanged);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(29, 318);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(539, 102);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(333, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "~";
            // 
            // dateTime_end
            // 
            this.dateTime_end.Location = new System.Drawing.Point(368, 224);
            this.dateTime_end.Name = "dateTime_end";
            this.dateTime_end.Size = new System.Drawing.Size(200, 25);
            this.dateTime_end.TabIndex = 3;
            // 
            // dateTime_start
            // 
            this.dateTime_start.Location = new System.Drawing.Point(127, 225);
            this.dateTime_start.Name = "dateTime_start";
            this.dateTime_start.Size = new System.Drawing.Size(200, 25);
            this.dateTime_start.TabIndex = 3;
            // 
            // combox_model_name
            // 
            this.combox_model_name.FormattingEnabled = true;
            this.combox_model_name.Location = new System.Drawing.Point(159, 130);
            this.combox_model_name.Name = "combox_model_name";
            this.combox_model_name.Size = new System.Drawing.Size(121, 23);
            this.combox_model_name.TabIndex = 2;
            // 
            // combox_line_id
            // 
            this.combox_line_id.FormattingEnabled = true;
            this.combox_line_id.Location = new System.Drawing.Point(121, 79);
            this.combox_line_id.Name = "combox_line_id";
            this.combox_line_id.Size = new System.Drawing.Size(121, 23);
            this.combox_line_id.TabIndex = 2;
            // 
            // txtbox_oper_id
            // 
            this.txtbox_oper_id.Location = new System.Drawing.Point(183, 184);
            this.txtbox_oper_id.Name = "txtbox_oper_id";
            this.txtbox_oper_id.Size = new System.Drawing.Size(121, 25);
            this.txtbox_oper_id.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(63, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "날짜";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(63, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "작업자 명";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(63, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "모델 명";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(63, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Line";
            // 
            // dataGrid_line_view
            // 
            this.dataGrid_line_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_line_view.Location = new System.Drawing.Point(617, 12);
            this.dataGrid_line_view.Name = "dataGrid_line_view";
            this.dataGrid_line_view.RowHeadersWidth = 51;
            this.dataGrid_line_view.RowTemplate.Height = 27;
            this.dataGrid_line_view.Size = new System.Drawing.Size(532, 446);
            this.dataGrid_line_view.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Lot_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 470);
            this.Controls.Add(this.dataGrid_line_view);
            this.Controls.Add(this.groupBox1);
            this.Name = "Lot_list";
            this.Text = "lot_list";
            this.Load += new System.EventHandler(this.Lot_list_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_line_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGrid_line_view;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTime_end;
        private System.Windows.Forms.DateTimePicker dateTime_start;
        private System.Windows.Forms.ComboBox combox_model_name;
        private System.Windows.Forms.ComboBox combox_line_id;
        private System.Windows.Forms.TextBox txtbox_oper_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox oper_id_box;
        private System.Windows.Forms.CheckBox model_name_box;
        private System.Windows.Forms.CheckBox line_box;
        private System.Windows.Forms.CheckBox datetime_box;
    }
}
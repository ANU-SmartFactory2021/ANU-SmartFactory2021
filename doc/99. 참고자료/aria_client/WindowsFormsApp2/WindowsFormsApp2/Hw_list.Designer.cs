namespace WindowsFormsApp2
{
    partial class Hw_list
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
            this.btn_search = new System.Windows.Forms.Button();
            this.DataGrid_hw_View = new System.Windows.Forms.DataGridView();
            this.txtbox_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_hw_View)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(258, 92);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(73, 25);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // DataGrid_hw_View
            // 
            this.DataGrid_hw_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid_hw_View.Location = new System.Drawing.Point(12, 132);
            this.DataGrid_hw_View.Name = "DataGrid_hw_View";
            this.DataGrid_hw_View.RowHeadersWidth = 51;
            this.DataGrid_hw_View.RowTemplate.Height = 27;
            this.DataGrid_hw_View.Size = new System.Drawing.Size(1004, 614);
            this.DataGrid_hw_View.TabIndex = 1;
            // 
            // txtbox_search
            // 
            this.txtbox_search.Location = new System.Drawing.Point(32, 92);
            this.txtbox_search.Name = "txtbox_search";
            this.txtbox_search.Size = new System.Drawing.Size(211, 25);
            this.txtbox_search.TabIndex = 2;
            // 
            // Hw_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 757);
            this.Controls.Add(this.txtbox_search);
            this.Controls.Add(this.DataGrid_hw_View);
            this.Controls.Add(this.btn_search);
            this.Name = "Hw_list";
            this.Text = "Hw_list";
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid_hw_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView DataGrid_hw_View;
        private System.Windows.Forms.TextBox txtbox_search;
    }
}
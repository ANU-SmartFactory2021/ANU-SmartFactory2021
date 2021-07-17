using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Finish_m : Form
    {
        public Finish_m()
        {
            InitializeComponent();
            SetupDataGridView();
            PopulateDataGridView();
        }

        private void Finish_m_Load(object sender, EventArgs e)
        {

        }
        private void SetupDataGridView()
        {
            this.Controls.Add(DataGridView2);

            // DataGridView의 컬럼 갯수를 6개로 설정합니다.
            DataGridView2.ColumnCount = 6;

            // DataGridView에 컬럼을 추가합니다.
            DataGridView2.Columns[0].Name = "No";
            DataGridView2.Columns[1].Name = "모델명";
            DataGridView2.Columns[2].Name = "라인 ID";
            DataGridView2.Columns[3].Name = "작업지시 ID";
            DataGridView2.Columns[4].Name = "재고량";
            DataGridView2.Columns[5].Name = "가격(1EA)";
        }

        /*
         * PopulateDataGridView()
         * DataGridView에 데이터를 삽입합니다.
         */
        private void PopulateDataGridView()
        {
            // DataGridView에 삽입할 데이터를 설정합니다.
            string[] row0 = { "1", "초코빵", "#1", "1234", "20", "1500"};
            string[] row1 = { "2", "메론빵", "#2", "5678", "15", "1200"};
     

            // DataGridView에 한 줄씩 삽입합니다.
            DataGridView2.Rows.Add(row0);
            DataGridView2.Rows.Add(row1);

            // DataGridView에 들어갈 컬럼의 순서를 지정합니다.
            DataGridView2.Columns[0].DisplayIndex = 0;
            DataGridView2.Columns[1].DisplayIndex = 1;
            DataGridView2.Columns[2].DisplayIndex = 2;
            DataGridView2.Columns[3].DisplayIndex = 3;
            DataGridView2.Columns[4].DisplayIndex = 4;
            DataGridView2.Columns[5].DisplayIndex = 5;
        }

        private void Insert_Click(object sender, EventArgs e)
        {

        }
    }
}

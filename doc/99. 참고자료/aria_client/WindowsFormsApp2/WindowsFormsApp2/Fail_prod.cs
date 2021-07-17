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
    public partial class Fail_prod : Form
    {
        string fail_sMessage = "";
        string fail_sServerIp = "220.69.249.232";
        const int fail_nServerPort = 4000;
        const int fail_nCilentPort = 4000;


        public Fail_prod()
        {
            InitializeComponent();
            SetupDataGridView();
            PopulateDataGridView();
        }


        private void Fail_prod_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void SetupDataGridView()
        {
            this.Controls.Add(DataGrid_md_fail_View);

            // DataGridView의 컬럼 갯수를 5개로 설정합니다.
            DataGrid_md_fail_View.ColumnCount = 7;

            // DataGridView에 컬럼을 추가합니다.
            DataGrid_md_fail_View.Columns[0].Name = "No";
            DataGrid_md_fail_View.Columns[1].Name = "제품 고유번호";
            DataGrid_md_fail_View.Columns[2].Name = "모델명";
            DataGrid_md_fail_View.Columns[3].Name = "온도";
            DataGrid_md_fail_View.Columns[4].Name = "습도";
            DataGrid_md_fail_View.Columns[5].Name = "불량원인";
            DataGrid_md_fail_View.Columns[6].Name = "불량검출시간";
        }

        /*
         * PopulateDataGridView()
         * DataGridView에 데이터를 삽입합니다.
         */
        private void PopulateDataGridView()
        {
            // DataGridView에 삽입할 데이터를 설정합니다.
            string[] row0 = { "1","101_4", "초코빵", "50", "20", "부적절한온도", "15:26:33" };
            string[] row1 = { "2", "101_5", "초코빵", "49", "20", "부적절한온도","15:27:33" };
            string[] row2 = { "3", "101_6", "초코빵", "51", "20", "부적절한온도","15:28:33" };
            string[] row3 = { "4", "102_8", "메론빵", "15", "60", "부적절한습도", "18:55:22" };
            string[] row4 = { "5", "102_9", "메론빵", "15", "61", "부적절한습도", "18:56:26" };

            // DataGridView에 한 줄씩 삽입합니다.
            DataGrid_md_fail_View.Rows.Add(row0);
            DataGrid_md_fail_View.Rows.Add(row1);
            DataGrid_md_fail_View.Rows.Add(row2);
            DataGrid_md_fail_View.Rows.Add(row3);
            DataGrid_md_fail_View.Rows.Add(row4);

            // DataGridView에 들어갈 컬럼의 순서를 지정합니다.
            DataGrid_md_fail_View.Columns[0].DisplayIndex = 0;
            DataGrid_md_fail_View.Columns[1].DisplayIndex = 1;
            DataGrid_md_fail_View.Columns[2].DisplayIndex = 2;
            DataGrid_md_fail_View.Columns[3].DisplayIndex = 3;
            DataGrid_md_fail_View.Columns[4].DisplayIndex = 4;
            DataGrid_md_fail_View.Columns[5].DisplayIndex = 5;
            DataGrid_md_fail_View.Columns[6].DisplayIndex = 6;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

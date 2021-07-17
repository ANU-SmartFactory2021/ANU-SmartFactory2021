using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using MESComm;
using WindowsFormsApp2.Class_lot;

namespace WindowsFormsApp2
{
    public partial class Lot_direct : Form
    {
        string                  l_sMessage = "";
        string                  l_sServerIp = "220.69.249.232";
        const int               l_nServerPort = 4000;
        const int               l_nClientPort = 4000;
        private List<Aria_lot_line>  l_listReceivedLot;
        DataTable               l_dtLot = new DataTable();
        ServerComm              server_comm = new ServerComm(true);

        public Lot_direct()
        {
            InitializeComponent();

            l_listReceivedLot = new List<Aria_lot_line>();

            l_dtLot.Columns.Add("작업 지시 id", typeof(string));
            l_dtLot.Columns.Add("작업자 이름", typeof(string));
            l_dtLot.Columns.Add("작업 상태", typeof(string));
            l_dtLot.Columns.Add("제품 명", typeof(string));
            l_dtLot.Columns.Add("내부 온도", typeof(decimal));
            l_dtLot.Columns.Add("내부 습도", typeof(decimal));
            l_dtLot.Columns.Add("예약 현황", typeof(int));

            DataGrid_lots_list_view.DataSource = l_dtLot;

        }


        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        // 작업 지시
        private void insert_Click(object sender, EventArgs e)
        {
            try
            {
                // 텍스트 데이터
                string   line      = combox_line_id.Text;
                string   lot_id    = txtbox_lot_id.Text;
                string   md_name   = combox_model_name.Text;
                string   md_color  = combox_model_color.Text;
                decimal  pd_cnt    = numbox_prod_count.Value;
                decimal  pd_fail   = numbox_prod_fail.Value;
                decimal  temp_mag  = numbox_temp_margin.Value;
                decimal  hum_mag   = numbox_humid_margin.Value;
                
                /* 지시를 예약으로 쌓는 함수
                if(Int32.Parse(this.DataGrid_lots_list_view.CurrentRow.Cells[2].Value.ToString()) > 0)
                {

                }
                */
                
                // 데이터를 하나의 메세지로 묶는다.

                l_sMessage = "{{##!," + line + "," + lot_id + "," + md_name + "," + md_color + ","
                                   + pd_cnt + "," + pd_fail + "," + temp_mag + "," + hum_mag + ",#}}";


                server_comm.Connect();

                server_comm.req_lot_list(ref l_listReceivedLot, l_sMessage);

                server_comm.Close();

                MessageBox.Show("작업지시를 시행합니다.");
            }
            catch
            {
                MessageBox.Show("작업생성에 실패했습니다.");
            }
            ShowLotInfoToGridCtrl();

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Line_text_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Lot_direct_Load(object sender, EventArgs e)
        {

        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            
        }
        public void ShowLotInfoToGridCtrl()
        {
            l_dtLot.Clear();
            l_listReceivedLot.Clear();

            l_sMessage = "{{##%,,#}}";

            server_comm.Connect();

            server_comm.req_lot_list(ref l_listReceivedLot, l_sMessage);

            server_comm.Close();
        }

        // cell one click
        private void DataGrid_lots_list_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void DataGrid_lots_list_view_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        // cell double click
        private void DataGrid_lots_list_view_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Line line = new Line();

            line.Show();
        }
    }
}

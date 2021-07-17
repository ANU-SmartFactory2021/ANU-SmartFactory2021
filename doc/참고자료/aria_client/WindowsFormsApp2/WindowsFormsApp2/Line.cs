using MESComm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApp2.Class_lot;

namespace WindowsFormsApp2
{
    public partial class Line : Form
    {
        string                       ln_sMessage = "";
        string                       ln_sServerIp = "220.69.249.232";
        const int                    ln_nServerPort = 4000;
        const int                    ln_nClientPort = 4000;
        private List<Aria_lot_line>  ln_listReceivedLine;
        DataTable                    ln_dtLine = new DataTable();
        ServerComm                   server_comm = new ServerComm(true);


        public Line()
        {
            InitializeComponent();

            ln_listReceivedLine = new List<Aria_lot_line>();

            ln_dtLine.Columns.Add("작업 지시 id", typeof(string));
            ln_dtLine.Columns.Add("작업자 이름", typeof(string));
            ln_dtLine.Columns.Add("작업 상태", typeof(string));
            ln_dtLine.Columns.Add("제품 명", typeof(string));
            ln_dtLine.Columns.Add("내부 온도", typeof(decimal));
            ln_dtLine.Columns.Add("내부 습도", typeof(decimal));
            ln_dtLine.Columns.Add("예약 현황", typeof(int));

            DataGrid_lots_list_view.DataSource = ln_dtLine;

        }

        private void Line_Load(object sender, EventArgs e)
        {

            int x = 1;
            //차트
            chart1.Series.Clear(); //default series 삭제
            Series strue = chart1.Series.Add("정상");
            strue.ChartType = SeriesChartType.Line;

            for(double k=0; k<5;k+=0.1)
            {
                
                strue.Points.AddXY(k, x);
                x += 1;
            }

            Series sfalse = chart1.Series.Add("불량");
            sfalse.ChartType = SeriesChartType.Line;

            for (double k = 0; k < 5; k += 1)
            {
                sfalse.Points.AddXY(k, x);
                x += 1;
            }
        }

        private void GroupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Lot_direct model = new Lot_direct();
            model.ShowDialog();
        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}

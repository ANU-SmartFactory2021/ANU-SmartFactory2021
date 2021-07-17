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
using Newtonsoft.Json;
using MESComm;
using System.IO;
using WindowsFormsApp2.Class_Model;

namespace WindowsFormsApp2
{
    public partial class Model_set : Form
    {
        string m_sMessage = "";
        DataTable m_dtModel = new DataTable();
        ServerComm server_comm = new ServerComm(true);
        Aria_model md = new Aria_model();
        List<Aria_model> md_list = new List<Aria_model>();
        // txtbox clear
        public void Txtboxmodel_clear()
        {
            txtbox_model_id.Clear();
            txtbox_model_temp.Clear();
            txtbox_model_humidity.Clear();
            txtbox_model_name.Clear();
            txtbox_model_id_sch.Clear();
        }

        public Model_set()
        {
            InitializeComponent();

            //DataTable table = new DataTable();

            m_dtModel.Columns.Add("모델 id", typeof(string));
            m_dtModel.Columns.Add("적정 온도", typeof(int));
            m_dtModel.Columns.Add("적정 습도", typeof(int));
            m_dtModel.Columns.Add("모델 명", typeof(string));

            DataGridView_Model.DataSource = m_dtModel;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // 생성
        private void Insert_Click(object sender, EventArgs e)
        {
            try
            {

                md_list.Clear();
                // 메세지 프로토콜
                string btn_evnt = "!";
                // clear model_info table ctrl
                m_dtModel.Clear();

                // 텍스트 데이터 (컨트롤로 부터 데이터를 가져옴.)
                md.model_id = txtbox_model_id.Text;
                md.temp_margin = float.Parse(txtbox_model_temp.Text);
                md.model_id = txtbox_model_id.Text;
                md.temp_margin = float.Parse(txtbox_model_temp.Text);
                md.humid_margin = float.Parse(txtbox_model_humidity.Text);
                md.model_name = txtbox_model_name.Text;
                md.model_name = txtbox_model_name.Text;


                // 데이터를 하나의 메세지로 묶는다.
                server_comm.Connect();

                // insert를 하는 함수가 추가적으로 필요하다. (req_model_add로 서버에 db추가 명령)

                md_list = server_comm.req_model_send(md, btn_evnt, md_list);

                ShowModelInfoToGridView(md_list);

                // 필요 기능
                // servercomm 의 nAck, sReason, m_listReceivedModel 를 받아와야 함
                // 받아온 3가지를 이용하여 nAck = "ok"일 경우 메세지 박스를 띄운 뒤 m_listReceicedModel를 그리드뷰의 셀에 하나씩 쌓는 함수를 호출 함.
                // 결국 텍스트박스의 글과 버튼만 클릭해주면 서버에서 던져준 메세지만 틀에 넣어주면 됨.

                server_comm.Close();

                Txtboxmodel_clear();

                MessageBox.Show("값이 추가되었습니다.");

            }
            catch
            {
                MessageBox.Show("값을 입력해주세요.");
            }

            // 객체 종료

        }

        // 삭제
        private void Delete_Click(object sender, EventArgs e)
        {
            // id만 있어도 될듯, 수정과 insert
            try
            {
                // 컨테이너, m_listReceivedModel(List< >) 초기화 단계.(DB값을 받아 새로 값을 할당해주기 위해.)
                md_list.Clear();
                m_dtModel.Clear();
                // 메세지 프로토콜
                string btn_evnt = "@";


                // 텍스트 데이터
                md.model_id = txtbox_model_id.Text;

                server_comm.Connect();

                md_list = server_comm.req_model_send(md, btn_evnt, md_list);

                m_dtModel.Rows.Add(md_list[0].model_id, md_list[0].temp_margin, md_list[0].humid_margin, md_list[0].model_name);

                server_comm.Close();

                Txtboxmodel_clear();

                MessageBox.Show("값이 삭제되었습니다.");

            }
            catch
            {
                MessageBox.Show("값을 입력해주세요.");
            }

            ShowModelInfoToGridCtrl();

        }

        // 수정
        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                // 컨테이너, m_listReceivedModel(List< >) 초기화 단계.(DB값을 받아 새로 값을 할당해주기 위해.)
                md_list.Clear();
                m_dtModel.Clear();
                // 메세지 프로토콜
                string btn_evnt = "#";

                // 텍스트 데이터 (컨트롤로 부터 데이터를 가져옴.)
                md.model_id = txtbox_model_id.Text;
                md.temp_margin = float.Parse(txtbox_model_temp.Text);
                md.humid_margin = float.Parse(txtbox_model_humidity.Text);
                md.model_name = txtbox_model_name.Text;

                // 데이터를 하나의 메세지로 묶는다.
                server_comm.Connect();

                md_list = server_comm.req_model_send(md, btn_evnt, md_list);

                m_dtModel.Rows.Add(md_list[0].model_id, md_list[0].temp_margin, md_list[0].humid_margin, md_list[0].model_name);

                server_comm.Close();

                Txtboxmodel_clear();

                MessageBox.Show("값이 수정되었습니다.");

            }
            catch
            {
                MessageBox.Show("값을 입력해주세요.");

            }

            ShowModelInfoToGridCtrl();

        }


        // 부분 검색
        private void Search_Click(object sender, EventArgs e)
        {
            // 텍스트 데이터
            try
            {
                // 컨테이너, m_listReceivedModel(List< >) 초기화 단계.(DB값을 받아 새로 값을 할당해주기 위해.)
                md_list.Clear();
                m_dtModel.Clear();

                // 메세지 프로토콜
                string btn_evnt = "$";

                md.model_id = txtbox_model_id_sch.Text;

                server_comm.Connect();

                md_list = server_comm.req_model_send(md, btn_evnt, md_list);

                m_dtModel.Rows.Add(md_list[0].model_id, md_list[0].temp_margin, md_list[0].humid_margin, md_list[0].model_name);

                server_comm.Close();

                Txtboxmodel_clear();

                MessageBox.Show("값이 검색되었습니다.");

                // 객체 종료
            }
            catch
            {
                MessageBox.Show("총 검색.");
            }

            ShowModelInfoToGridCtrl();
        }


        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        // 그리드 뷰의 셀 클릭시 셀의 데이터가 텍스트박스에 생성
        private void Model_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtbox_model_id.Text = this.DataGridView_Model.CurrentRow.Cells[0].Value.ToString();
            txtbox_model_temp.Text = this.DataGridView_Model.CurrentRow.Cells[1].Value.ToString();
            txtbox_model_humidity.Text = this.DataGridView_Model.CurrentRow.Cells[2].Value.ToString();
            txtbox_model_name.Text = this.DataGridView_Model.CurrentRow.Cells[3].Value.ToString();

        }

        private void Model_set_Load(object sender, EventArgs e)
        {

        }

        // 총 검색
        public void ShowModelInfoToGridCtrl()
        {
            // 컨테이너, m_listReceivedModel(List< >) 초기화 단계.(DB값을 받아 새로 값을 할당해주기 위해.)
            md_list.Clear();
            m_dtModel.Clear();

            // 메세지 프로토콜
            string btn_evnt = "%";

            server_comm.Connect();

            md_list = server_comm.req_model_send(md, btn_evnt, md_list);

            m_dtModel.Rows.Add(md_list[0].model_id, md_list[0].temp_margin, md_list[0].humid_margin, md_list[0].model_name);

            server_comm.Close();

            Txtboxmodel_clear();
        }

        private void ShowModelInfoToGridView(List<Aria_model> _md_list)
        {
            for (int i = 0; i < _md_list.Count; i++)
            {
                m_dtModel.Rows.Add(_md_list[i].model_id, _md_list[i].temp_margin, _md_list[i].humid_margin, _md_list[i].model_name);
            }

        }


    }
}
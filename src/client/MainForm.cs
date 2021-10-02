using System;
using System.Collections.Generic;
using System.ComponentModel;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using TCPIP_Sample_CSharp;
using System.Threading;
using System.Diagnostics;

namespace Client
{
    
    public partial class MainForm : Form
    {        

        //각 panel 선언
        panel.Start_panel start_pan = new panel.Start_panel();
        panel.Monitor_panel monitor_pan = new panel.Monitor_panel();
        panel.Fairqual_panel fairqual_pan = new panel.Fairqual_panel();
        panel.Def_panel def_pan = new panel.Def_panel();
       

        public static socket_client sc = new socket_client();
        public int state;
        string time= "0";

        Stopwatch stopwatch = new Stopwatch();
        
        public MainForm()
        {
            InitializeComponent();           
            start_pan.DataPassEvent += new panel.Start_panel.DataPassEventHandler(factory_state);
            monitor_pan.DataPassEvent += new panel.Monitor_panel.DataPassEventHandler(factory_state);

            sc.connect("192.168.41.92", 5451);
            sc.send("<CLIENT_TYPE=WINFORM>");

            this.FormClosed += Form_Closing;
        }
        

        private void Menu_btn_Click(object sender, EventArgs e)
        {
            Main_panel.Controls.Clear();
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            Main_panel.Controls.Clear(); //Main_panel을 초기화
            Main_panel.Controls.Add(start_pan); //Main_panel에 start_pan 추가
            if(State_label.Text == "0")
            {
                start_pan.FieldClear();
            }
            
        }

        private void Monitor_btn_Click(object sender, EventArgs e)
        {
            Main_panel.Controls.Clear();  
            Main_panel.Controls.Add(monitor_pan);
            if (State_label.Text == "0")
            {
                monitor_pan.FieldClear();
            }

        }
      
        private void Def_btn_Click(object sender, EventArgs e)
        {
            Main_panel.Controls.Clear();
            Main_panel.Controls.Add(def_pan);
        }

        private void Fairqual_btn_Click(object sender, EventArgs e)
        {
            Main_panel.Controls.Clear();
            Main_panel.Controls.Add(fairqual_pan);

            fairqual_pan.read();
        }

        private void Stop_btn_Click(object sender, EventArgs e)
        {
            State_label.Text = "0";
            Main_panel.Controls.Clear();
        }

        public void factory_state(object sender)
        {
            state = (int)sender;
            State_label.Text = state.ToString();
        }

        private void State_label_TextChanged(object sender, EventArgs e)
        {
            monitor_pan.M_Serialnum_txt.Text = start_pan.Serialnum_txt.Text;

            //작업시작 state = 1
            if (State_label.Text == "1")
            {
                time = "0";
                stopwatch.Reset();

                st_start.BackColor = Color.Green;
                st_stop.BackColor = Color.White;
                st_finish.BackColor = Color.White;

                stopwatch.Start();
                time = (stopwatch.Elapsed.Seconds).ToString();

                Time_label.Text = time + "초";
                timer1.Enabled = true;
                
            }
            //대기중 state = 0
            else if (State_label.Text == "0")
            {
                st_stop.BackColor = Color.Red;
                st_start.BackColor = Color.White;
                st_finish.BackColor = Color.White;

                stopwatch.Stop();
                time = (stopwatch.Elapsed.Seconds).ToString();

                Time_label.Text = time;
                timer1.Enabled = false;
            }
            //작업완료 후 대기 state = 3
            else if (State_label.Text == "3")
            {
                st_finish.BackColor = Color.Green;
                st_start.BackColor = Color.White;
                st_stop.BackColor = Color.White;

                stopwatch.Stop();
                time = (stopwatch.Elapsed.Seconds).ToString();

                Time_label.Text = time;
                timer1.Enabled = false;
            }
            //긴급정지 state = 11
            else if (State_label.Text =="11")
            {
                st_finish.BackColor = Color.Red;
                st_start.BackColor = Color.Red;
                st_stop.BackColor = Color.Red;

                Stop_btn.BackColor = Color.White;
                Delay(1000);
                Stop_btn.BackColor = Color.FromArgb(255, 128, 128);
                Delay(1000);
                Stop_btn.BackColor = Color.White;
                Delay(1000);
                Stop_btn.BackColor = Color.FromArgb(255, 128, 128);
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = (stopwatch.Elapsed.Seconds).ToString();
            Time_label.Text = time + "초";
        }

        //딜레이 함수
        private static DateTime Delay(int MS)

        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }

            return DateTime.Now;
        }

        public void Form_Closing(object sender, FormClosedEventArgs e)
        {
            
            sc.disconnect();
            MessageBox.Show("폼이 닫힙니다.");
        }
    }
}

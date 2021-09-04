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

namespace Client
{
    public class CircularButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath g = new GraphicsPath();
            g.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(g);
            base.OnPaint(pevent);
        }
    }
    public partial class MainForm : Form
    {
        
        //각 panel 선언
        panel.Start_panel start_pan = new panel.Start_panel();
        panel.Monitor_panel monitor_pan = new panel.Monitor_panel();
        panel.Fairqual_panel fairqual_pan = new panel.Fairqual_panel();
        panel.Def_panel def_pan = new panel.Def_panel();

        int state;
        
        public MainForm()
        {
            InitializeComponent();           
            start_pan.DataPassEvent += new panel.Start_panel.DataPassEventHandler(factory_state);
            
        }

        private void Menu_btn_Click(object sender, EventArgs e)
        {
            Main_panel.Controls.Clear();           
        }

        private void Start_btn_Click(object sender, EventArgs e)
        {
            Main_panel.Controls.Clear(); //Main_panel을 초기화
            Main_panel.Controls.Add(start_pan); //Main_panel에 start_pan 추가
            if(state == 0)
            {
                start_pan.FieldClear();
            }
            
        }

        private void Monitor_btn_Click(object sender, EventArgs e)
        {
            Main_panel.Controls.Clear();  
            Main_panel.Controls.Add(monitor_pan);
            if (state == 0)
            {
                monitor_pan.FieldClear();
            }
            else
            {
                monitor_pan.M_Serialnum_txt.Text = start_pan.Serialnum_txt.Text;
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
        }

        private void Stop_btn_Click(object sender, EventArgs e)
        {
            State_label.Text = "0";
        }

        public void factory_state(object sender)
        {
            state = (int)sender;
            State_label.Text = state.ToString();
        }

        
    }
}

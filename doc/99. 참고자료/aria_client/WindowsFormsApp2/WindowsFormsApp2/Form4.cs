using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.label1.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 hh시 mm분 ss초");
            timer1.Tick += Timer1_Tick;
            timer1.Interval = 1000;
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 hh시 mm분 ss초");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

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
    public partial class fmMainMenu : Form
    {
        public fmMainMenu()
        {
/*            Login log_in = new Login();
            log_in.ShowDialog();
*/
            InitializeComponent();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Fail_prod fail = new Fail_prod();               //생성자 함수로 fail만듬
            fail.Show();                                        // Show 함수 불러옴
        }

        private void finish_m_button_Click(object sender, EventArgs e)
        {
            Finish_m fin = new Finish_m();
            fin.Show();
        }

        private void line_button_Click(object sender, EventArgs e)
        {
            Line line = new Line();
            line.Show();
        }

        private void user_set_button_Click(object sender, EventArgs e)
        {
            User_set user = new User_set();
            user.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lot_direct_button_Click(object sender, EventArgs e)
        {
            Lot_direct M1 = new Lot_direct();
            M1.Show();
        }

        private void model_set_button_Click(object sender, EventArgs e)
        {
            Model_set M2 = new Model_set();
            M2.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            User_set login = new User_set();
            login.ShowDialog();
        }

        private void fail_prod_button_Click(object sender, EventArgs e)
        {
            Fail_prod mo2 = new Fail_prod();
            mo2.ShowDialog();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void FmMainMenu_Shown(object sender, EventArgs e)
        {
        }
    }
}

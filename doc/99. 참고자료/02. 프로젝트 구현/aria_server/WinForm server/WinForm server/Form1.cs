using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_server
{
    public partial class Form1 : Form
    {
        public static int bb = Convert.ToInt32(611);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bindIp = "220.69.249.231";
            string serverIp = "220.69.249.231";
            const int serverPort = 4000;

            Form1.bb += 1;
            string message;

            message = textBox1.Text;
            IPEndPoint clientAddress = new IPEndPoint(IPAddress.Parse(bindIp), Form1.bb);
            IPEndPoint serverAddress = new IPEndPoint(IPAddress.Parse(serverIp), serverPort);

            // 클라이언트 IP, 포트번호로 객체 생성 후 연결(Connect)
            TcpClient client = new TcpClient(clientAddress);
            client.Connect(serverAddress);


            byte[] data = System.Text.Encoding.Default.GetBytes(message);
            NetworkStream stream = client.GetStream();
            stream.Write(data, 0, data.Length);
            textBox2.Text = "송신 : " + message;
            data = new byte[256];
            string responseData = "";

            int bytes = stream.Read(data, 0, data.Length);
            responseData = Encoding.Default.GetString(data, 0, bytes);
            textBox3.Text = "수신 : " + responseData;


            stream.Close();
            client.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

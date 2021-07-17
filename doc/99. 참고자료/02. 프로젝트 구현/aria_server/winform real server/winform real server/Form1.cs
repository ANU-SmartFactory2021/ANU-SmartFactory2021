using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_real_server
{
    public partial class Form1 : Form
    {
        UserDAO userDao = new UserDAO();


        public Form1()
        {
            InitializeComponent();
            Thread c = new Thread(hh);
            c.IsBackground = true;
            c.Start();
        }
        public void hh()
        {
            string bintIp = "220.69.249.231";
            const int bindPort = 4000;
            TcpListener server = null;

            //서버주소 바인딩(ip번호, port번호)
            IPEndPoint localAddress = new IPEndPoint(IPAddress.Parse(bintIp), bindPort);
            //서버 만들기, 주소바인딩~!!!
            server = new TcpListener(localAddress);

            server.Start();
            textBox1.Text = "ARIA 프로젝트 서버";

            while (true)
            {
                TcpClient client = server.AcceptTcpClient();
                ((IPEndPoint)client.Client.RemoteEndPoint).ToString();
                NetworkStream stream = client.GetStream();

                int length;
                string data = null;
                byte[] bytes = new byte[256];
                length = stream.Read(bytes, 0, bytes.Length);

                StringBuilder sb = new StringBuilder();
                StringBuilder sb2 = new StringBuilder();
                ArrayList sss = new ArrayList();
                ArrayList sss2 = new ArrayList();
                string[] data_arr;  // data 스트링을 잘라서 배열에 넣는 변수
                string update_user_id = "wnqkfwnqkf";   // 임의의 변수

                // data = {{#! ... #}}의 형식
                // user_id, pass_word, level, e_mail, first_name, last_name
                // ex) {{#!!, ju ,1111 ,1 ,ju@naver.com ,Lee ,Ju ,#}}
                data = Encoding.Default.GetString(bytes, 0, length);// 데이터 수신
                //sss.Add(string.Format("수신 : {0} ", data));
                textBox2.Text = data;

                string Ddta, Ddta2;
                Ddta = data.Substring(0, 4);
                Ddta2 = data.Substring(4, 1);

                // data_arr [1] = user_id, [2] = pass_word, [3] = level, [4] = e_mail, [5] = first_name, [6] = last_name
                data_arr = data.Split(',');

                UserDto userDto = new UserDto();
                userDto.user_id = data_arr[1];
                userDto.pass_word = data_arr[2];
                userDto.level = data_arr[3];
                userDto.e_mail = data_arr[4];
                userDto.first_name = data_arr[5];
                userDto.last_name = data_arr[6];

                if (Ddta == "{{#!") // 모델 프로토콜
                {
                    if (Ddta2 == "!") // 모델 insert
                    {
                        //UserDto userDto = new UserDto(data_arr[1], data_arr[2], data_arr[3], data_arr[4], data_arr[5], data_arr[6]);
                        userDao.Insert(userDto);
                        data = "insert 받았습니다~";
                        byte[] msg = Encoding.Default.GetBytes(data);
                        stream.Write(msg, 0, msg.Length); // 데이터 송신
                        textBox3.Text = data;
                    }
                    else if (Ddta2 == "@") // 모델 delete
                    {
                        // user_id 기준 삭제
                        userDao.Delete(data_arr[1]);
                        data = "delete 받았습니다~";
                        byte[] msg = Encoding.Default.GetBytes(data);
                        stream.Write(msg, 0, msg.Length); // 데이터 송신
                        textBox3.Text = data;
                    }
                    else if (Ddta2 == "#") // 모델 update
                    {
                        // data_arr[1] = 수정하기 전이름, update_user_id = 수정한 후 이름
                        userDao.Update(data_arr[1], update_user_id);
                        data = "update 받았습니다~";
                        byte[] msg = Encoding.Default.GetBytes(data);
                        stream.Write(msg, 0, msg.Length); // 데이터 송신
                        textBox3.Text = data;
                    }
                    else if (Ddta2 == "$") // 모델 select
                    {
                        userDao.Selection();
                        data = "select 받았습니다~";
                        byte[] msg = Encoding.Default.GetBytes(data);
                        stream.Write(msg, 0, msg.Length); // 데이터 송신
                        textBox3.Text = data;
                    }
                }
                else if (data == "ㅂㅇ")
                {
                    data = "는 바이";
                    byte[] msg = Encoding.Default.GetBytes(data);
                    stream.Write(msg, 0, msg.Length); // 데이터 송신
                    textBox3.Text = data;
                }
                else if (data == "ㅂㅇㄹ")
                {
                    data = "는 바이루";
                    byte[] msg = Encoding.Default.GetBytes(data);
                    stream.Write(msg, 0, msg.Length); // 데이터 송신
                    textBox3.Text = data;
                }
                byte[] msg2 = Encoding.Default.GetBytes(data);
                stream.Write(msg2, 0, msg2.Length); // 데이터 송신
                textBox3.Text = data;



            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

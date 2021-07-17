using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Collections;

namespace MES_COMM_PI.SECS2
{   
    class SECS2_Parse
    {
        public string MakeXml(SECS2_XML_MESSAGE _msg)
        {
            string sXml = "";

            if (_msg.HEAD.Stream == 2 && _msg.HEAD.Function == 41) sXml = MakeXml_S2F41(_msg);
            else if (_msg.HEAD.Stream == 6 && _msg.HEAD.Function == 12) sXml = MakeXml_S6F12(_msg);
            else {
               // error message 출력.
            }

            return sXml;
        }



        private string MakeXml_S2F41(SECS2_XML_MESSAGE _packet) // @김동우
        {
            string sXml = "";

            // 쓰기
            XmlDocument S2F41 = new XmlDocument();
            XmlNode root = S2F41.CreateElement("SECS2_XML_MESSAGE"); //PACKET

            XmlNode HEAD = S2F41.CreateElement("HEAD"); // HEAD
            root.AppendChild(HEAD);
            XmlNode BODY = S2F41.CreateElement("BODY"); // BODY
            root.AppendChild(BODY);

            XmlNode SystemByte = S2F41.CreateElement("SystemByte"); // HEAD1
            SystemByte.InnerText = Convert.ToString(_packet.HEAD.SystemByte);
            XmlNode Cmd = S2F41.CreateElement("CMD"); // HEAD2
            Cmd.InnerText = Convert.ToString(_packet.HEAD.CMD);
            XmlNode Stream = S2F41.CreateElement("Stream"); // HEAD3
            Stream.InnerText = Convert.ToString(_packet.HEAD.Stream);
            XmlNode Function = S2F41.CreateElement("Function"); // HEAD4
            Function.InnerText = Convert.ToString(_packet.HEAD.Function);

            HEAD.AppendChild(SystemByte);
            HEAD.AppendChild(Cmd);
            HEAD.AppendChild(Stream);
            HEAD.AppendChild(Function);

            XmlNode RCMD = S2F41.CreateElement("RCMD"); // BODY1
            RCMD.InnerText = Convert.ToString(_packet.BODY.RCMD);
            XmlNode PARAMETERS = S2F41.CreateElement("PARAMETERS"); // BODY2
            BODY.AppendChild(RCMD);
            BODY.AppendChild(PARAMETERS);


            string Receive_Data = ""; // PARAMETERS.DATA
            Receive_Data = "4"; // 데이터 길이
            ArrayList ab = new ArrayList();
            for (int i = 0; i < Convert.ToInt32(Receive_Data); i++) // PARAMETERS_IN
            {
                XmlNode CMD_PARAMi = S2F41.CreateElement("CMD_PARAM"); // PARAMETER
                PARAMETERS.AppendChild(CMD_PARAMi);
                XmlNode CPNAME = S2F41.CreateElement("CPNAME"); // CMD_PARAM 1
                CPNAME.InnerText = _packet.BODY.PARAMETERS[i].CPNAME;
                XmlNode CPVALUE = S2F41.CreateElement("CPVALUE"); // CMD_PARAM2
                CPVALUE.InnerText = _packet.BODY.PARAMETERS[i].CPVALUE;
                CMD_PARAMi.AppendChild(CPNAME);
                CMD_PARAMi.AppendChild(CPVALUE);
                ab.Add(CPNAME.InnerText);
                ab.Add(CPVALUE.InnerText);
            }

            S2F41.AppendChild(root);
            string S2F41_XML = S2F41.DocumentElement.OuterXml;


            // 읽기
            // PacketS
            XmlNodeList HEAD_IN = S2F41.GetElementsByTagName("HEAD");
            XmlNodeList BODY_IN = S2F41.GetElementsByTagName("BODY");
            XmlNodeList PARAMETERSS = S2F41.GetElementsByTagName("PARAMETERS");

            string Sys = "";
            string CMd = "";
            string Str = "";
            string Fun = "";
            string Rcm = "";
            List<string> Param = new List<string>();

            // Head
            foreach (XmlNode node in HEAD_IN)
            {
                Sys = node["SystemByte"].InnerText; // SystemBytem
                CMd = node["CMD"].InnerText; // CMD
                Str = node["Stream"].InnerText; // Stream
                Fun = node["Function"].InnerText; // Fucntion
            }

            // Body
            foreach (XmlNode node in BODY_IN)
            {
                Rcm = node["RCMD"].InnerText; // RCMD
            }
            foreach (XmlNode node in PARAMETERS) // PARAMETERS
            {
                // CMD_PARAM n개
                Param.Add(node["CPNAME"].InnerText); // CPNAME
                Param.Add(node["CPVALUE"].InnerText); // CPVALUE
            }
            for (int w = 0; w < Param.Count; w++)
            {
                Console.WriteLine(Param[w]);
            }

            // PacketS
            {
                // Head
                {
                    // SystemBytem
                    // CMD
                    // Stream
                    // Fucntion
                }
                // Body
                {
                    // RCMD
                    // PARAMETERS
                    {
                        // CMD_PARAM n개
                        {
                            // CPNAME
                            // CPVALUE
                        }
                    }
                }
            }
            // return S2F41_XML;
            return sXml;
        }

        private string MakeXml_S6F12(SECS2_XML_MESSAGE _msg) // @신수영
        {
            string sXml = "";

            //쓰기
            XmlDocument S6F12 = new XmlDocument();

            XmlNode root = S6F12.CreateElement("SECS2_XML_MESSAGE");

            XmlNode HEAD = S6F12.CreateElement("HEAD");
            root.AppendChild(HEAD);
            XmlNode BODY = S6F12.CreateElement("BODY");
            root.AppendChild(BODY);

            XmlNode SystemByte = S6F12.CreateElement("SystemByte");
            SystemByte.InnerText = Convert.ToString(_msg.HEAD.SystemByte);
            XmlNode Cmd = S6F12.CreateElement("CMD");
            Cmd.InnerText = Convert.ToString(_msg.HEAD.CMD);
            XmlNode Stream = S6F12.CreateElement("Stream");
            Stream.InnerText = Convert.ToString(_msg.HEAD.Stream);
            XmlNode Function = S6F12.CreateElement("Function");
            Function.InnerText = Convert.ToString(_msg.HEAD.Stream);



            HEAD.AppendChild(SystemByte);
            HEAD.AppendChild(Cmd);
            HEAD.AppendChild(Stream);
            HEAD.AppendChild(Function);

            XmlNode Ackc6 = S6F12.CreateElement("ACKC6");
            Ackc6.InnerText = Convert.ToString(_msg.BODY.ACKC6);
            BODY.AppendChild(Ackc6);


            S6F12.AppendChild(root);

            string S6F12_XML = S6F12.DocumentElement.OuterXml;

            //읽기
            XmlNodeList HEAD_IN = S6F12.GetElementsByTagName("HEAD");
            XmlNodeList BODY_IN = S6F12.GetElementsByTagName("BODY");

            string Sys = "";
            string CMd = "";
            string Str = "";
            string Fun = "";
            string ACKC6 = "";

            // Head
            foreach (XmlNode node in HEAD_IN)
            {
                Sys = node["SystemByte"].InnerText; // SystemBytem
                CMd = node["CMD"].InnerText; // CMD
                Str = node["Stream"].InnerText; // Stream
                Fun = node["Function"].InnerText; // Fucntion
            }

            // Body
            foreach (XmlNode node in BODY_IN)
            {
                ACKC6 = node["ACKC6"].InnerText; // ACKC6
            }


            return sXml;
        }

        public int LoadXml(string _sXml, ref SECS2_XML_MESSAGE _rVal)
        {
            int nErr = 0;

            XmlDocument xml = new XmlDocument();
            xml.LoadXml(_sXml);

            XmlNodeList HEAD_IN = xml.GetElementsByTagName("HEAD");
            XmlNodeList BODY_IN = xml.GetElementsByTagName("BODY");
            XmlNodeList REPORT_IN = xml.GetElementsByTagName("REPORT");
            XmlNodeList VARIABLES_IN = xml.GetElementsByTagName("VARIABLES");

            List<string> Vs = new List<string>();

            int nS = 0, nF = 0;
            foreach (XmlNode node in HEAD_IN)
            {
                _rVal.HEAD.SystemByte = Convert.ToInt32(node["SystemByte"].InnerText);
                // systembyte
                _rVal.HEAD.CMD = Convert.ToInt32(node["CMD"].InnerText);
                // cmd
                _rVal.HEAD.Stream = Convert.ToInt32(node["Stream"].InnerText);
                // stream
                _rVal.HEAD.Function = Convert.ToInt32(node["Function"].InnerText);
                // function
            }
            // Head (@김성현)


            // Body
            // s2f42, host command ack (@김성현)
            if( nS == 2 && nF == 42)
            {
                foreach (XmlNode node in BODY_IN)
                {
                    _rVal.BODY.HCACK = Convert.ToInt32(node["HCACK"].InnerText);
                }
                // HCACK
            }

            // s6f11, event report (@김동우)
            if( nS == 6 && nF == 11)
            {
                
                // CEID
                foreach (XmlNode node in REPORT_IN)
                {
                   // _rVal.BODY.REPORTS = node["REPORTID"].InnerText; // string을 class로 변환?
                }
                // RPTID
                foreach (XmlNode node in VARIABLES_IN)
                {
                    Vs.Add(node["V"].InnerText);
                }
                if (Vs.Count > 0)
                {
                    for (int e = 0; e < Vs.Count; e++)
                    {
                        //_rVal.BODY.REPORTS.REPORT.VARIABLES[e].V = Vs[e]; // v는 없으면 생성?
                    }
                }
                // Vs
            }
            return nErr;
        }
    }
}

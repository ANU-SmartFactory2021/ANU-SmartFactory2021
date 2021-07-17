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
        public static string eq = "";

        public SECS2_Parse()
        {
        }

        public string MakeXml(SECS2_XML_MESSAGE _packet)
        {
            string sXml = "";

            XmlSerializer serializer = new XmlSerializer(typeof(SECS2_XML_MESSAGE));
            TextWriter writer = new StringWriter();
            serializer.Serialize(writer, _packet);
            sXml = writer.ToString();

            return sXml;
        }


        public void ParseXml(string _sXml, ref SECS2_XML_MESSAGE _rPacket)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(SECS2_XML_MESSAGE));
            TextReader reader = new StringReader(_sXml);
            _rPacket = (SECS2_XML_MESSAGE)serializer.Deserialize(reader);

            /*
                        SECS2_XML_MESSAGE aa = new SECS2_XML_MESSAGE();

                        _sXml = do_MakeXml_S2F41(aa);


                        XmlDocument xml = new XmlDocument();

                        xml.LoadXml(_sXml);



                        XmlNodeList HEAD_IN = xml.GetElementsByTagName("HEAD");
                        XmlNodeList BODY_IN = xml.GetElementsByTagName("BODY");

                        List<string> Vs = new List<string>();

                        int nS = 0, nF = 0;
                        foreach (XmlNode node in HEAD_IN)
                        {
                            nS = Convert.ToInt32(node["Stream"].InnerText);
                            // stream
                            nF = Convert.ToInt32(node["Function"].InnerText);
                            // function
                        }
                        // Head (@김성현)

                        // Body
                        // s2f42, host command ack (@김성현)
                        if (nS == 2 && nF == 42)
                        {
                            foreach (XmlNode node in BODY_IN)
                            {
                                _rPacket.BODY.HCACK = Convert.ToInt32(node["HCACK"].InnerText);
                            }
                            // HCACK
                        }

                        int CEID = 0;
                        List<int> CPNAME = new List<int>();
                        List<int> CPVALUE = new List<int>();
                        List<int> REPORTID = new List<int>();
                        // s6f11, event report (@김동우)
                        if (nS == 6 && nF == 11)
                        {

                            // BODY
                            foreach (XmlNode node in BODY_IN)
                            {
                                // CEID
                                CEID = int.Parse(node["CEID"].InnerText);
                            }
                            // REPORTS
                            XmlNodeList REPORT_IN = xml.GetElementsByTagName("REPORT");
                            foreach (XmlNode nodeReport in REPORT_IN)
                            {
                                REPORTID.Add(Convert.ToInt32(nodeReport["REPORTID"].InnerText));
                            }
                            // REPORT
                            {
                                // REPORTID
                                XmlNode nodeRPTID = nodeReport.SelectSingleNode("REPORTID");
                                _rPacket.BODY.REPORTS.REPORT.REPORTID = ushort.Parse(nodeRPTID.InnerText);

                                // VARIABLES
                                XmlNodeList VARIABLS = nodeReport.SelectNodes("VARIABLES");
                                _rPacket.BODY.REPORTS.REPORT.VARIABLES = new string[VARIABLS.Count];
                                int _ii = 0;
                                foreach (XmlNode nodeV in VARIABLS)
                                {
                                    // V
                                    _rPacket.BODY.REPORTS.REPORT.VARIABLES[_ii++] = nodeV.InnerText;
                                }
                            }
                        }
                     */

        }


        /*
                public string do_MakeXml_S2F41(SECS2_XML_MESSAGE _packet) // @김동우
                {
                    string sXml = "";

                    // 쓰기
                    XmlDocument doc = new XmlDocument();
                    XmlNode root    = doc.CreateElement("SECS2_XML_MESSAGE"); //PACKET

                    XmlNode HEAD = doc.CreateElement("HEAD"); // HEAD
                    root.AppendChild(HEAD);

                    _packet.HEAD.SystemByte = 33;

                    XmlNode SystemByte   = doc.CreateElement("SystemByte"); // HEAD1
                    SystemByte.InnerText = "1";

                    XmlNode Cmd          = doc.CreateElement("CMD"); // HEAD2
                    Cmd.InnerText        = "2";


                    XmlNode Stream       = doc.CreateElement("Stream"); // HEAD3
                    Stream.InnerText = "6";
                    XmlNode Function     = doc.CreateElement("Function"); // HEAD4
                    Function.InnerText   = "11";

                    HEAD.AppendChild(SystemByte);
                    HEAD.AppendChild(Cmd);
                    HEAD.AppendChild(Stream);
                    HEAD.AppendChild(Function);

                    XmlNode BODY = doc.CreateElement("BODY"); // BODY
                    root.AppendChild(BODY);

                    XmlNode RCMD       = doc.CreateElement("RCMD"); // BODY1
                    RCMD.InnerText         =   "7" ;
                    XmlNode PARAMETERS     = doc.CreateElement("PARAMETERS"); // BODY2

                    BODY.AppendChild(RCMD);
                    BODY.AppendChild(PARAMETERS);

                    int Receive_Data_Count = 4; // 데이터 길이

                        XmlNode CMD_PARAMi = doc.CreateElement("CMD_PARAM"); // PARAMETER
                        PARAMETERS.AppendChild(CMD_PARAMi);

                        XmlNode CPNAME = doc.CreateElement("CPNAME"); // CMD_PARAM 1
                        CPNAME.InnerText = "5";

                        XmlNode CPVALUE = doc.CreateElement("CPVALUE"); // CMD_PARAM2
                        CPVALUE.InnerText = "6";

                        CMD_PARAMi.AppendChild(CPNAME);
                        CMD_PARAMi.AppendChild(CPVALUE);


                    doc.AppendChild(root);
                    eq = doc.DocumentElement.OuterXml;
                    sXml = doc.DocumentElement.OuterXml;
                    return sXml;

                    string e = "e";


                    // 읽기
                    // PacketS
                    //XmlNodeList HEAD_IN = S2F41.GetElementsByTagName("HEAD");
                    //XmlNodeList BODY_IN = S2F41.GetElementsByTagName("BODY");
                    //XmlNodeList PARAMETERSS = S2F41.GetElementsByTagName("PARAMETERS");

                    //string Sys = "";
                    //string CMd = "";
                    //string Str = "";
                    //string Fun = "";
                    //string Rcm = "";
                    //List<string> Param = new List<string>();

                    //// Head
                    //foreach (XmlNode node in HEAD_IN)
                    //{
                    //    Sys = node["SystemByte"].InnerText; // SystemBytem
                    //    CMd = node["CMD"].InnerText; // CMD
                    //    Str = node["Stream"].InnerText; // Stream
                    //    Fun = node["Function"].InnerText; // Fucntion
                    //}

                    //// Body
                    //foreach (XmlNode node in BODY_IN)
                    //{
                    //    Rcm = node["RCMD"].InnerText; // RCMD
                    //}
                    //foreach (XmlNode node in PARAMETERS) // PARAMETERS
                    //{
                    //    // CMD_PARAM n개
                    //    Param.Add(node["CPNAME"].InnerText); // CPNAME
                    //    Param.Add(node["CPVALUE"].InnerText); // CPVALUE
                    //}
                    //for (int w = 0; w < Param.Count; w++)
                    //{
                    //    Console.WriteLine(Param[w]);
                    //}

                    //// PacketS
                    //{
                    //    // Head
                    //    {
                    //        // SystemBytem
                    //        // CMD
                    //        // Stream
                    //        // Fucntion
                    //    }
                    //    // Body
                    //    {
                    //        // RCMD
                    //        // PARAMETERS
                    //        {
                    //            // CMD_PARAM n개
                    //            {
                    //                // CPNAME
                    //                // CPVALUE
                    //            }
                    //        }
                    //    }
                    //}
                    // return S2F41_XML;
                    return eq;
                }

                private string do_MakeXml_S6F12(SECS2_XML_MESSAGE _msg) // @신수영
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

                    sXml = S6F12.DocumentElement.OuterXml;


                    return sXml;

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
                }
                */

    }
}


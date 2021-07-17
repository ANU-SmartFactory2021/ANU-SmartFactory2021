using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MES_COMM_PI.SECS2;

namespace MES_COMM_PI
{
    public enum eACKC6 { Accepted = 0, NotAccepted = 1}
    public enum eHCACK { Acknowledge = 0, Command_does_not_exist = 1,
        Cannot_perform_now = 2, parameter_is_invalid = 3, Acknowledge_will_be_performed = 4,
        Rejected = 5, No_object_exists = 6
    }

    public enum eCMD { link_test_req = 1, link_test_rsp = 2, user = 3, separate_req = 5   };

    class Server_PI
    {
        private static int m_nSystemByte = 0;

        private SECS2_Parse m_parser = new SECS2_Parse();

        public void Server_Open()
        {

        }

        public void Server_Close()
        {

        }

        public int MakeSystemByte()
        {
            if (m_nSystemByte > 9999999) m_nSystemByte = 0;
            return m_nSystemByte++;
        }
        public void OnReceive(string _rcv_msg, ref SECS2_XML_MESSAGE _it)
        {
            /*
             * _rcv_msg =   
             * <SECS2_XML_MESSAGE>
             *   <HEAD>
             *     <SystemByte> 00002 </SystemByte>
             *     <CMD> 3 </CMD>
             *     <Stream> 6 </Stream>
             *     <Function> 11 </Function>
             *   </HEAD>
             *   <BODY>
             *     <CEID> 1 </CEID>
             *     <REPORTS>
             *       <REPORT>
             *         <REPORTID> 1000 </REPORTID>
             *         <VARIABLES>
             *           <V> 25.0 </V>
             *           <V> 50.0 </V>
             *           <V> PASS </V>
             *         </VARIABLES>
             *       </REPORT>
             *     </REPORTS>
             *   </BODY>
             * </SECS2_XML_MESSAGE>
             */
            m_parser.ParseXml(_rcv_msg, ref _it);  
        }

        private int do_Send(SECS2_XML_MESSAGE _packet)
        {
            int nErr = 0;

            string sMsg = m_parser.MakeXml(_packet);

            // socket stream writer로 write 해준다.
            // client_stream.Wirte( sMsg );

            return nErr;
        }

        public int Send_S2F41_HostCommand(string _HostCmd, List<SECS2_XML_MESSAGEBODYCMD_PARAM> _CmdParams)
        {
            int nErr = 0;

            SECS2_XML_MESSAGE Packet = new SECS2_XML_MESSAGE(MakeSystemByte(), (byte)eCMD.user, 2, 41);

            Packet.BODY.RCMD = _HostCmd;

            Packet.BODY.PARAMETERS = new SECS2_XML_MESSAGEBODYCMD_PARAM[_CmdParams.Count()];
            int i = 0;
            foreach (SECS2_XML_MESSAGEBODYCMD_PARAM it in _CmdParams )
            {
                // Packet.BODY.PARAMETERS[i].CPNAME  = it.CPNAME;
                // Packet.BODY.PARAMETERS[i].CPVALUE = it.CPVALUE;
                Packet.BODY.PARAMETERS[i] = it;
                i++;
            }

            nErr = do_Send(Packet);

            return nErr;
        }

        public int Send_S6F12_EventReportAck(eACKC6 _nACKC6)
        {
            int nErr = 0;
            SECS2_XML_MESSAGE Packet = new SECS2_XML_MESSAGE(MakeSystemByte(), (byte)eCMD.user, 6, 12);

            Packet.BODY.ACKC6 = (int)_nACKC6;

            nErr = do_Send(Packet);
            return nErr;
        }
    }
}



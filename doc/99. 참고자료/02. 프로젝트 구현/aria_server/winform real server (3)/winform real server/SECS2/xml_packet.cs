using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MES_COMM_PI.SECS2
{

    // 참고: 생성된 코드에 .NET Framework 4.5 또는 .NET Core/Standard 2.0이(가) 필요할 수 있습니다.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class SECS2_XML_MESSAGE
    {
        public SECS2_XML_MESSAGE()
        {
            this.HEAD = new SECS2_XML_MESSAGEHEAD();
            this.BODY = new SECS2_XML_MESSAGEBODY();
        }

        public SECS2_XML_MESSAGE(int _nSystemByte, byte _nCmd, byte _nS, byte _nF)
        {
            this.HEAD = new SECS2_XML_MESSAGEHEAD();
            this.BODY = new SECS2_XML_MESSAGEBODY();

            this.HEAD.SystemByte = _nSystemByte;
            this.HEAD.CMD        = _nCmd;
            this.HEAD.Stream     = _nS;
            this.HEAD.Function   = _nF;
        }

        private SECS2_XML_MESSAGEHEAD HEADField;

        private SECS2_XML_MESSAGEBODY BODYField;

        /// <remarks/>
        public SECS2_XML_MESSAGEHEAD HEAD
        {
            get
            {
                return this.HEADField;
            }
            set
            {
                this.HEADField = value;
            }
        }

        /// <remarks/>
        public SECS2_XML_MESSAGEBODY BODY
        {
            get
            {
                return this.BODYField;
            }
            set
            {
                this.BODYField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class SECS2_XML_MESSAGEHEAD
    {

        private int SystemByteField;

        private int CMDField;

        private int StreamField;

        private int FunctionField;

        /// <remarks/>
        public int SystemByte
        {
            get
            {
                return this.SystemByteField;
            }
            set
            {
                this.SystemByteField = value;
            }
        }

        /// <remarks/>
        public int CMD
        {
            get
            {
                return this.CMDField;
            }
            set
            {
                this.CMDField = value;
            }
        }

        /// <remarks/>
        public int Stream
        {
            get
            {
                return this.StreamField;
            }
            set
            {
                this.StreamField = value;
            }
        }

        /// <remarks/>
        public int Function
        {
            get
            {
                return this.FunctionField;
            }
            set
            {
                this.FunctionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class SECS2_XML_MESSAGEBODY
    {

        private int ACKC6Field;

        private bool ACKC6FieldSpecified;

        private byte CEIDField;

        private bool CEIDFieldSpecified;

        private SECS2_XML_MESSAGEBODYREPORTS REPORTSField;

        private int HCACKField;

        private bool HCACKFieldSpecified;

        private string RCMDField;

        private SECS2_XML_MESSAGEBODYCMD_PARAM[] PARAMETERSField;

        /// <remarks/>
        public int ACKC6
        {
            get
            {
                return this.ACKC6Field;
            }
            set
            {
                this.ACKC6Field = value;
                this.ACKC6FieldSpecified = true;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ACKC6Specified
        {
            get
            {
                return this.ACKC6FieldSpecified;
            }
            set
            {
                this.ACKC6FieldSpecified = value;
            }
        }

        /// <remarks/>
        public byte CEID
        {
            get
            {
                return this.CEIDField;
            }
            set
            {
                this.CEIDField = value;
                this.CEIDFieldSpecified = true;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CEIDSpecified
        {
            get
            {
                return this.CEIDFieldSpecified;
            }
            set
            {
                this.CEIDFieldSpecified = value;
            }
        }

        /// <remarks/>
        public SECS2_XML_MESSAGEBODYREPORTS REPORTS
        {
            get
            {
                return this.REPORTSField;
            }
            set
            {
                this.REPORTSField = value;
            }
        }

        /// <remarks/>
        public int HCACK
        {
            get
            {
                return this.HCACKField;
            }
            set
            {
                this.HCACKField = value;
                this.HCACKFieldSpecified = true;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HCACKSpecified
        {
            get
            {
                return this.HCACKFieldSpecified;
            }
            set
            {
                this.HCACKFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string RCMD
        {
            get
            {
                return this.RCMDField;
            }
            set
            {
                this.RCMDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CMD_PARAM", IsNullable = false)]
        public SECS2_XML_MESSAGEBODYCMD_PARAM[] PARAMETERS
        {
            get
            {
                return this.PARAMETERSField;
            }
            set
            {
                this.PARAMETERSField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class SECS2_XML_MESSAGEBODYREPORTS
    {

        private SECS2_XML_MESSAGEBODYREPORTSREPORT REPORTField;

        /// <remarks/>
        public SECS2_XML_MESSAGEBODYREPORTSREPORT REPORT
        {
            get
            {
                return this.REPORTField;
            }
            set
            {
                this.REPORTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class SECS2_XML_MESSAGEBODYREPORTSREPORT
    {

        private ushort REPORTIDField;

        private string[] VARIABLESField;

        /// <remarks/>
        public ushort REPORTID
        {
            get
            {
                return this.REPORTIDField;
            }
            set
            {
                this.REPORTIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("V", IsNullable = false)]
        public string[] VARIABLES
        {
            get
            {
                return this.VARIABLESField;
            }
            set
            {
                this.VARIABLESField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class SECS2_XML_MESSAGEBODYCMD_PARAM
    {

        private string CPNAMEField;

        private string CPVALUEField;

        /// <remarks/>
        public string CPNAME
        {
            get
            {
                return this.CPNAMEField;
            }
            set
            {
                this.CPNAMEField = value;
            }
        }

        /// <remarks/>
        public string CPVALUE
        {
            get
            {
                return this.CPVALUEField;
            }
            set
            {
                this.CPVALUEField = value;
            }
        }
    }


}

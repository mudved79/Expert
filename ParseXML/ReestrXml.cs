using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseXML
{
    class ReestrXml
    {
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class ZL_LIST
        {

            private ZL_LISTZGLV zGLVField;

            private ZL_LISTSCHET sCHETField;

            private ZL_LISTZAP[] zAPField;

            /// <remarks/>
            public ZL_LISTZGLV ZGLV
            {
                get
                {
                    return this.zGLVField;
                }
                set
                {
                    this.zGLVField = value;
                }
            }

            /// <remarks/>
            public ZL_LISTSCHET SCHET
            {
                get
                {
                    return this.sCHETField;
                }
                set
                {
                    this.sCHETField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("ZAP")]
            public ZL_LISTZAP[] ZAP
            {
                get
                {
                    return this.zAPField;
                }
                set
                {
                    this.zAPField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ZL_LISTZGLV
        {

            private decimal vERSIONField;

            private System.DateTime dATAField;

            private string fILENAMEField;

            /// <remarks/>
            public decimal VERSION
            {
                get
                {
                    return this.vERSIONField;
                }
                set
                {
                    this.vERSIONField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime DATA
            {
                get
                {
                    return this.dATAField;
                }
                set
                {
                    this.dATAField = value;
                }
            }

            /// <remarks/>
            public string FILENAME
            {
                get
                {
                    return this.fILENAMEField;
                }
                set
                {
                    this.fILENAMEField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ZL_LISTSCHET
        {

            private byte cODEField;

            private uint cODE_MOField;

            private ushort yEARField;

            private byte mONTHField;

            private string nSCHETField;

            private System.DateTime dSCHETField;

            private ushort pLATField;

            private decimal sUMMAVField;

            private object cOMENTSField;

            /// <remarks/>
            public byte CODE
            {
                get
                {
                    return this.cODEField;
                }
                set
                {
                    this.cODEField = value;
                }
            }

            /// <remarks/>
            public uint CODE_MO
            {
                get
                {
                    return this.cODE_MOField;
                }
                set
                {
                    this.cODE_MOField = value;
                }
            }

            /// <remarks/>
            public ushort YEAR
            {
                get
                {
                    return this.yEARField;
                }
                set
                {
                    this.yEARField = value;
                }
            }

            /// <remarks/>
            public byte MONTH
            {
                get
                {
                    return this.mONTHField;
                }
                set
                {
                    this.mONTHField = value;
                }
            }

            /// <remarks/>
            public string NSCHET
            {
                get
                {
                    return this.nSCHETField;
                }
                set
                {
                    this.nSCHETField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime DSCHET
            {
                get
                {
                    return this.dSCHETField;
                }
                set
                {
                    this.dSCHETField = value;
                }
            }

            /// <remarks/>
            public ushort PLAT
            {
                get
                {
                    return this.pLATField;
                }
                set
                {
                    this.pLATField = value;
                }
            }

            /// <remarks/>
            public decimal SUMMAV
            {
                get
                {
                    return this.sUMMAVField;
                }
                set
                {
                    this.sUMMAVField = value;
                }
            }

            /// <remarks/>
            public object COMENTS
            {
                get
                {
                    return this.cOMENTSField;
                }
                set
                {
                    this.cOMENTSField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ZL_LISTZAP
        {

            private ushort n_ZAPField;

            private byte pR_NOVField;

            private string nSCHET_PField;

            private System.DateTime dSCHET_PField;

            private bool dSCHET_PFieldSpecified;

            private ushort n_ZAP_PField;

            private bool n_ZAP_PFieldSpecified;

            private ZL_LISTZAPPACIENT pACIENTField;

            private ZL_LISTZAPZ_SL z_SLField;

            /// <remarks/>
            public ushort N_ZAP
            {
                get
                {
                    return this.n_ZAPField;
                }
                set
                {
                    this.n_ZAPField = value;
                }
            }

            /// <remarks/>
            public byte PR_NOV
            {
                get
                {
                    return this.pR_NOVField;
                }
                set
                {
                    this.pR_NOVField = value;
                }
            }

            /// <remarks/>
            public string NSCHET_P
            {
                get
                {
                    return this.nSCHET_PField;
                }
                set
                {
                    this.nSCHET_PField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime DSCHET_P
            {
                get
                {
                    return this.dSCHET_PField;
                }
                set
                {
                    this.dSCHET_PField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool DSCHET_PSpecified
            {
                get
                {
                    return this.dSCHET_PFieldSpecified;
                }
                set
                {
                    this.dSCHET_PFieldSpecified = value;
                }
            }

            /// <remarks/>
            public ushort N_ZAP_P
            {
                get
                {
                    return this.n_ZAP_PField;
                }
                set
                {
                    this.n_ZAP_PField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool N_ZAP_PSpecified
            {
                get
                {
                    return this.n_ZAP_PFieldSpecified;
                }
                set
                {
                    this.n_ZAP_PFieldSpecified = value;
                }
            }

            /// <remarks/>
            public ZL_LISTZAPPACIENT PACIENT
            {
                get
                {
                    return this.pACIENTField;
                }
                set
                {
                    this.pACIENTField = value;
                }
            }

            /// <remarks/>
            public ZL_LISTZAPZ_SL Z_SL
            {
                get
                {
                    return this.z_SLField;
                }
                set
                {
                    this.z_SLField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ZL_LISTZAPPACIENT
        {

            private string iD_PACField;

            private byte vPOLISField;

            private string sPOLISField;

            private ulong nPOLISField;

            private ushort sMOField;

            private ulong sMO_OGRNField;

            private ushort sMO_OKField;

            private uint nOVORField;

            private ushort vNOV_DField;

            private bool vNOV_DFieldSpecified;

            /// <remarks/>
            public string ID_PAC
            {
                get
                {
                    return this.iD_PACField;
                }
                set
                {
                    this.iD_PACField = value;
                }
            }

            /// <remarks/>
            public byte VPOLIS
            {
                get
                {
                    return this.vPOLISField;
                }
                set
                {
                    this.vPOLISField = value;
                }
            }

            /// <remarks/>
            public string SPOLIS
            {
                get
                {
                    return this.sPOLISField;
                }
                set
                {
                    this.sPOLISField = value;
                }
            }

            /// <remarks/>
            public ulong NPOLIS
            {
                get
                {
                    return this.nPOLISField;
                }
                set
                {
                    this.nPOLISField = value;
                }
            }

            /// <remarks/>
            public ushort SMO
            {
                get
                {
                    return this.sMOField;
                }
                set
                {
                    this.sMOField = value;
                }
            }

            /// <remarks/>
            public ulong SMO_OGRN
            {
                get
                {
                    return this.sMO_OGRNField;
                }
                set
                {
                    this.sMO_OGRNField = value;
                }
            }

            /// <remarks/>
            public ushort SMO_OK
            {
                get
                {
                    return this.sMO_OKField;
                }
                set
                {
                    this.sMO_OKField = value;
                }
            }

            /// <remarks/>
            public uint NOVOR
            {
                get
                {
                    return this.nOVORField;
                }
                set
                {
                    this.nOVORField = value;
                }
            }

            /// <remarks/>
            public ushort VNOV_D
            {
                get
                {
                    return this.vNOV_DField;
                }
                set
                {
                    this.vNOV_DField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool VNOV_DSpecified
            {
                get
                {
                    return this.vNOV_DFieldSpecified;
                }
                set
                {
                    this.vNOV_DFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ZL_LISTZAPZ_SL
        {

            private ushort z_SL_IDField;

            private byte iSTOCHIK_OPLField;

            private byte uSL_OKField;

            private byte vIDPOMField;

            private byte fOR_POMField;

            private uint lPUField;

            private uint nPR_MOField;

            private bool nPR_MOFieldSpecified;

            private uint npField;

            private bool npFieldSpecified;

            private System.DateTime nPR_DATEField;

            private bool nPR_DATEFieldSpecified;

            private System.DateTime dATE_Z_1Field;

            private System.DateTime dATE_Z_2Field;

            private byte kD_ZField;

            private bool kD_ZFieldSpecified;

            private ushort rSLTField;

            private ushort iSHODField;

            private byte oS_SLUCHField;

            private bool oS_SLUCHFieldSpecified;

            private byte vB_PField;

            private bool vB_PFieldSpecified;

            private byte iDSPField;

            private decimal sUMV_ZField;

            private byte oPLATAField;

            private decimal sUMP_ZField;

            private byte vBRField;

            private byte rSLT_DField;

            private bool rSLT_DFieldSpecified;

            private byte p_OTKField;

            private bool p_OTKFieldSpecified;

            private ZL_LISTZAPZ_SLSLUCH sLUCHField;

            /// <remarks/>
            public ushort Z_SL_ID
            {
                get
                {
                    return this.z_SL_IDField;
                }
                set
                {
                    this.z_SL_IDField = value;
                }
            }

            /// <remarks/>
            public byte ISTOCHIK_OPL
            {
                get
                {
                    return this.iSTOCHIK_OPLField;
                }
                set
                {
                    this.iSTOCHIK_OPLField = value;
                }
            }

            /// <remarks/>
            public byte USL_OK
            {
                get
                {
                    return this.uSL_OKField;
                }
                set
                {
                    this.uSL_OKField = value;
                }
            }

            /// <remarks/>
            public byte VIDPOM
            {
                get
                {
                    return this.vIDPOMField;
                }
                set
                {
                    this.vIDPOMField = value;
                }
            }

            /// <remarks/>
            public byte FOR_POM
            {
                get
                {
                    return this.fOR_POMField;
                }
                set
                {
                    this.fOR_POMField = value;
                }
            }

            /// <remarks/>
            public uint LPU
            {
                get
                {
                    return this.lPUField;
                }
                set
                {
                    this.lPUField = value;
                }
            }

            /// <remarks/>
            public uint NPR_MO
            {
                get
                {
                    return this.nPR_MOField;
                }
                set
                {
                    this.nPR_MOField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool NPR_MOSpecified
            {
                get
                {
                    return this.nPR_MOFieldSpecified;
                }
                set
                {
                    this.nPR_MOFieldSpecified = value;
                }
            }

            /// <remarks/>
            public uint NP
            {
                get
                {
                    return this.npField;
                }
                set
                {
                    this.npField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool NPSpecified
            {
                get
                {
                    return this.npFieldSpecified;
                }
                set
                {
                    this.npFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime NPR_DATE
            {
                get
                {
                    return this.nPR_DATEField;
                }
                set
                {
                    this.nPR_DATEField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool NPR_DATESpecified
            {
                get
                {
                    return this.nPR_DATEFieldSpecified;
                }
                set
                {
                    this.nPR_DATEFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime DATE_Z_1
            {
                get
                {
                    return this.dATE_Z_1Field;
                }
                set
                {
                    this.dATE_Z_1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime DATE_Z_2
            {
                get
                {
                    return this.dATE_Z_2Field;
                }
                set
                {
                    this.dATE_Z_2Field = value;
                }
            }

            /// <remarks/>
            public byte KD_Z
            {
                get
                {
                    return this.kD_ZField;
                }
                set
                {
                    this.kD_ZField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool KD_ZSpecified
            {
                get
                {
                    return this.kD_ZFieldSpecified;
                }
                set
                {
                    this.kD_ZFieldSpecified = value;
                }
            }

            /// <remarks/>
            public ushort RSLT
            {
                get
                {
                    return this.rSLTField;
                }
                set
                {
                    this.rSLTField = value;
                }
            }

            /// <remarks/>
            public ushort ISHOD
            {
                get
                {
                    return this.iSHODField;
                }
                set
                {
                    this.iSHODField = value;
                }
            }

            /// <remarks/>
            public byte OS_SLUCH
            {
                get
                {
                    return this.oS_SLUCHField;
                }
                set
                {
                    this.oS_SLUCHField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool OS_SLUCHSpecified
            {
                get
                {
                    return this.oS_SLUCHFieldSpecified;
                }
                set
                {
                    this.oS_SLUCHFieldSpecified = value;
                }
            }

            /// <remarks/>
            public byte VB_P
            {
                get
                {
                    return this.vB_PField;
                }
                set
                {
                    this.vB_PField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool VB_PSpecified
            {
                get
                {
                    return this.vB_PFieldSpecified;
                }
                set
                {
                    this.vB_PFieldSpecified = value;
                }
            }

            /// <remarks/>
            public byte IDSP
            {
                get
                {
                    return this.iDSPField;
                }
                set
                {
                    this.iDSPField = value;
                }
            }

            /// <remarks/>
            public decimal SUMV_Z
            {
                get
                {
                    return this.sUMV_ZField;
                }
                set
                {
                    this.sUMV_ZField = value;
                }
            }

            /// <remarks/>
            public byte OPLATA
            {
                get
                {
                    return this.oPLATAField;
                }
                set
                {
                    this.oPLATAField = value;
                }
            }

            /// <remarks/>
            public decimal SUMP_Z
            {
                get
                {
                    return this.sUMP_ZField;
                }
                set
                {
                    this.sUMP_ZField = value;
                }
            }

            /// <remarks/>
            public byte VBR
            {
                get
                {
                    return this.vBRField;
                }
                set
                {
                    this.vBRField = value;
                }
            }

            /// <remarks/>
            public byte RSLT_D
            {
                get
                {
                    return this.rSLT_DField;
                }
                set
                {
                    this.rSLT_DField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool RSLT_DSpecified
            {
                get
                {
                    return this.rSLT_DFieldSpecified;
                }
                set
                {
                    this.rSLT_DFieldSpecified = value;
                }
            }

            /// <remarks/>
            public byte P_OTK
            {
                get
                {
                    return this.p_OTKField;
                }
                set
                {
                    this.p_OTKField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool P_OTKSpecified
            {
                get
                {
                    return this.p_OTKFieldSpecified;
                }
                set
                {
                    this.p_OTKFieldSpecified = value;
                }
            }

            /// <remarks/>
            public ZL_LISTZAPZ_SLSLUCH SLUCH
            {
                get
                {
                    return this.sLUCHField;
                }
                set
                {
                    this.sLUCHField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ZL_LISTZAPZ_SLSLUCH
        {

            private ushort iDCASEField;

            private ulong cASEGUIDField;

            private string vID_HMPField;

            private ushort mETOD_HMPField;

            private bool mETOD_HMPFieldSpecified;

            private string dISPField;

            private ushort lPU_1Field;

            private ushort pODRField;

            private byte pROFILField;

            private byte pROFIL_KField;

            private bool pROFIL_KFieldSpecified;

            private byte dETField;

            private System.DateTime tAL_DField;

            private bool tAL_DFieldSpecified;

            private string tAL_NUMField;

            private System.DateTime tAL_PField;

            private bool tAL_PFieldSpecified;

            private string nHISTORYField;

            private decimal oBRField;

            private bool oBRFieldSpecified;

            private byte p_PERField;

            private bool p_PERFieldSpecified;

            private System.DateTime dATE_1Field;

            private System.DateTime dATE_2Field;

            private byte kdField;

            private bool kdFieldSpecified;

            private string dS1Field;

            private byte dS1_PRField;

            private bool dS1_PRFieldSpecified;

            private byte dS1_DNField;

            private bool dS1_DNFieldSpecified;

            private ZL_LISTZAPZ_SLSLUCHDS2_N[] dS2_NField;

            private byte c_ZABField;

            private bool c_ZABFieldSpecified;

            private byte dS_ONKField;

            private ZL_LISTZAPZ_SLSLUCHNAZ_DISP[] nAZ_DISPField;

            private ZL_LISTZAPZ_SLSLUCHNAPR[] nAPRField;

            private ZL_LISTZAPZ_SLSLUCHCONS cONSField;

            private ZL_LISTZAPZ_SLSLUCHONK_SL oNK_SLField;

            private ZL_LISTZAPZ_SLSLUCHKSG_KPG kSG_KPGField;

            private byte pRVSField;

            private ulong iDDOKTField;

            private decimal eD_COLField;

            private decimal tARIFField;

            private decimal sUMVField;

            private decimal sUMPField;

            private ushort iDCASE_PField;

            private bool iDCASE_PFieldSpecified;

            private ZL_LISTZAPZ_SLSLUCHUSL[] uSLField;

            /// <remarks/>
            public ushort IDCASE
            {
                get
                {
                    return this.iDCASEField;
                }
                set
                {
                    this.iDCASEField = value;
                }
            }

            /// <remarks/>
            public ulong CASEGUID
            {
                get
                {
                    return this.cASEGUIDField;
                }
                set
                {
                    this.cASEGUIDField = value;
                }
            }

            /// <remarks/>
            public string VID_HMP
            {
                get
                {
                    return this.vID_HMPField;
                }
                set
                {
                    this.vID_HMPField = value;
                }
            }

            /// <remarks/>
            public ushort METOD_HMP
            {
                get
                {
                    return this.mETOD_HMPField;
                }
                set
                {
                    this.mETOD_HMPField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool METOD_HMPSpecified
            {
                get
                {
                    return this.mETOD_HMPFieldSpecified;
                }
                set
                {
                    this.mETOD_HMPFieldSpecified = value;
                }
            }

            /// <remarks/>
            public string DISP
            {
                get
                {
                    return this.dISPField;
                }
                set
                {
                    this.dISPField = value;
                }
            }

            /// <remarks/>
            public ushort LPU_1
            {
                get
                {
                    return this.lPU_1Field;
                }
                set
                {
                    this.lPU_1Field = value;
                }
            }

            /// <remarks/>
            public ushort PODR
            {
                get
                {
                    return this.pODRField;
                }
                set
                {
                    this.pODRField = value;
                }
            }

            /// <remarks/>
            public byte PROFIL
            {
                get
                {
                    return this.pROFILField;
                }
                set
                {
                    this.pROFILField = value;
                }
            }

            /// <remarks/>
            public byte PROFIL_K
            {
                get
                {
                    return this.pROFIL_KField;
                }
                set
                {
                    this.pROFIL_KField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool PROFIL_KSpecified
            {
                get
                {
                    return this.pROFIL_KFieldSpecified;
                }
                set
                {
                    this.pROFIL_KFieldSpecified = value;
                }
            }

            /// <remarks/>
            public byte DET
            {
                get
                {
                    return this.dETField;
                }
                set
                {
                    this.dETField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime TAL_D
            {
                get
                {
                    return this.tAL_DField;
                }
                set
                {
                    this.tAL_DField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool TAL_DSpecified
            {
                get
                {
                    return this.tAL_DFieldSpecified;
                }
                set
                {
                    this.tAL_DFieldSpecified = value;
                }
            }

            /// <remarks/>
            public string TAL_NUM
            {
                get
                {
                    return this.tAL_NUMField;
                }
                set
                {
                    this.tAL_NUMField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime TAL_P
            {
                get
                {
                    return this.tAL_PField;
                }
                set
                {
                    this.tAL_PField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool TAL_PSpecified
            {
                get
                {
                    return this.tAL_PFieldSpecified;
                }
                set
                {
                    this.tAL_PFieldSpecified = value;
                }
            }

            /// <remarks/>
            public string NHISTORY
            {
                get
                {
                    return this.nHISTORYField;
                }
                set
                {
                    this.nHISTORYField = value;
                }
            }

            /// <remarks/>
            public decimal OBR
            {
                get
                {
                    return this.oBRField;
                }
                set
                {
                    this.oBRField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool OBRSpecified
            {
                get
                {
                    return this.oBRFieldSpecified;
                }
                set
                {
                    this.oBRFieldSpecified = value;
                }
            }

            /// <remarks/>
            public byte P_PER
            {
                get
                {
                    return this.p_PERField;
                }
                set
                {
                    this.p_PERField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool P_PERSpecified
            {
                get
                {
                    return this.p_PERFieldSpecified;
                }
                set
                {
                    this.p_PERFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime DATE_1
            {
                get
                {
                    return this.dATE_1Field;
                }
                set
                {
                    this.dATE_1Field = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime DATE_2
            {
                get
                {
                    return this.dATE_2Field;
                }
                set
                {
                    this.dATE_2Field = value;
                }
            }

            /// <remarks/>
            public byte KD
            {
                get
                {
                    return this.kdField;
                }
                set
                {
                    this.kdField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool KDSpecified
            {
                get
                {
                    return this.kdFieldSpecified;
                }
                set
                {
                    this.kdFieldSpecified = value;
                }
            }

            /// <remarks/>
            public string DS1
            {
                get
                {
                    return this.dS1Field;
                }
                set
                {
                    this.dS1Field = value;
                }
            }

            /// <remarks/>
            public byte DS1_PR
            {
                get
                {
                    return this.dS1_PRField;
                }
                set
                {
                    this.dS1_PRField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool DS1_PRSpecified
            {
                get
                {
                    return this.dS1_PRFieldSpecified;
                }
                set
                {
                    this.dS1_PRFieldSpecified = value;
                }
            }

            /// <remarks/>
            public byte DS1_DN
            {
                get
                {
                    return this.dS1_DNField;
                }
                set
                {
                    this.dS1_DNField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool DS1_DNSpecified
            {
                get
                {
                    return this.dS1_DNFieldSpecified;
                }
                set
                {
                    this.dS1_DNFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("DS2_N")]
            public ZL_LISTZAPZ_SLSLUCHDS2_N[] DS2_N
            {
                get
                {
                    return this.dS2_NField;
                }
                set
                {
                    this.dS2_NField = value;
                }
            }

            /// <remarks/>
            public byte C_ZAB
            {
                get
                {
                    return this.c_ZABField;
                }
                set
                {
                    this.c_ZABField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool C_ZABSpecified
            {
                get
                {
                    return this.c_ZABFieldSpecified;
                }
                set
                {
                    this.c_ZABFieldSpecified = value;
                }
            }

            /// <remarks/>
            public byte DS_ONK
            {
                get
                {
                    return this.dS_ONKField;
                }
                set
                {
                    this.dS_ONKField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("NAZ_DISP")]
            public ZL_LISTZAPZ_SLSLUCHNAZ_DISP[] NAZ_DISP
            {
                get
                {
                    return this.nAZ_DISPField;
                }
                set
                {
                    this.nAZ_DISPField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("NAPR")]
            public ZL_LISTZAPZ_SLSLUCHNAPR[] NAPR
            {
                get
                {
                    return this.nAPRField;
                }
                set
                {
                    this.nAPRField = value;
                }
            }

            /// <remarks/>
            public ZL_LISTZAPZ_SLSLUCHCONS CONS
            {
                get
                {
                    return this.cONSField;
                }
                set
                {
                    this.cONSField = value;
                }
            }

            /// <remarks/>
            public ZL_LISTZAPZ_SLSLUCHONK_SL ONK_SL
            {
                get
                {
                    return this.oNK_SLField;
                }
                set
                {
                    this.oNK_SLField = value;
                }
            }

            /// <remarks/>
            public ZL_LISTZAPZ_SLSLUCHKSG_KPG KSG_KPG
            {
                get
                {
                    return this.kSG_KPGField;
                }
                set
                {
                    this.kSG_KPGField = value;
                }
            }

            /// <remarks/>
            public byte PRVS
            {
                get
                {
                    return this.pRVSField;
                }
                set
                {
                    this.pRVSField = value;
                }
            }

            /// <remarks/>
            public ulong IDDOKT
            {
                get
                {
                    return this.iDDOKTField;
                }
                set
                {
                    this.iDDOKTField = value;
                }
            }

            /// <remarks/>
            public decimal ED_COL
            {
                get
                {
                    return this.eD_COLField;
                }
                set
                {
                    this.eD_COLField = value;
                }
            }

            /// <remarks/>
            public decimal TARIF
            {
                get
                {
                    return this.tARIFField;
                }
                set
                {
                    this.tARIFField = value;
                }
            }

            /// <remarks/>
            public decimal SUMV
            {
                get
                {
                    return this.sUMVField;
                }
                set
                {
                    this.sUMVField = value;
                }
            }

            /// <remarks/>
            public decimal SUMP
            {
                get
                {
                    return this.sUMPField;
                }
                set
                {
                    this.sUMPField = value;
                }
            }

            /// <remarks/>
            public ushort IDCASE_P
            {
                get
                {
                    return this.iDCASE_PField;
                }
                set
                {
                    this.iDCASE_PField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool IDCASE_PSpecified
            {
                get
                {
                    return this.iDCASE_PFieldSpecified;
                }
                set
                {
                    this.iDCASE_PFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("USL")]
            public ZL_LISTZAPZ_SLSLUCHUSL[] USL
            {
                get
                {
                    return this.uSLField;
                }
                set
                {
                    this.uSLField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ZL_LISTZAPZ_SLSLUCHDS2_N
        {

            private string dS2Field;

            private byte dS2_PRField;

            private bool dS2_PRFieldSpecified;

            private byte dS2_DNField;

            private bool dS2_DNFieldSpecified;

            /// <remarks/>
            public string DS2
            {
                get
                {
                    return this.dS2Field;
                }
                set
                {
                    this.dS2Field = value;
                }
            }

            /// <remarks/>
            public byte DS2_PR
            {
                get
                {
                    return this.dS2_PRField;
                }
                set
                {
                    this.dS2_PRField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool DS2_PRSpecified
            {
                get
                {
                    return this.dS2_PRFieldSpecified;
                }
                set
                {
                    this.dS2_PRFieldSpecified = value;
                }
            }

            /// <remarks/>
            public byte DS2_DN
            {
                get
                {
                    return this.dS2_DNField;
                }
                set
                {
                    this.dS2_DNField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool DS2_DNSpecified
            {
                get
                {
                    return this.dS2_DNFieldSpecified;
                }
                set
                {
                    this.dS2_DNFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ZL_LISTZAPZ_SLSLUCHNAZ_DISP
        {

            private byte nAZRField;

            private byte nAZ_VField;

            private bool nAZ_VFieldSpecified;

            private byte nAZ_SPField;

            private bool nAZ_SPFieldSpecified;

            /// <remarks/>
            public byte NAZR
            {
                get
                {
                    return this.nAZRField;
                }
                set
                {
                    this.nAZRField = value;
                }
            }

            /// <remarks/>
            public byte NAZ_V
            {
                get
                {
                    return this.nAZ_VField;
                }
                set
                {
                    this.nAZ_VField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool NAZ_VSpecified
            {
                get
                {
                    return this.nAZ_VFieldSpecified;
                }
                set
                {
                    this.nAZ_VFieldSpecified = value;
                }
            }

            /// <remarks/>
            public byte NAZ_SP
            {
                get
                {
                    return this.nAZ_SPField;
                }
                set
                {
                    this.nAZ_SPField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool NAZ_SPSpecified
            {
                get
                {
                    return this.nAZ_SPFieldSpecified;
                }
                set
                {
                    this.nAZ_SPFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ZL_LISTZAPZ_SLSLUCHNAPR
        {

            private System.DateTime nAPR_DATEField;

            private byte nAPR_VField;

            private byte mET_ISSLField;

            private bool mET_ISSLFieldSpecified;

            private string nAPR_USLField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime NAPR_DATE
            {
                get
                {
                    return this.nAPR_DATEField;
                }
                set
                {
                    this.nAPR_DATEField = value;
                }
            }

            /// <remarks/>
            public byte NAPR_V
            {
                get
                {
                    return this.nAPR_VField;
                }
                set
                {
                    this.nAPR_VField = value;
                }
            }

            /// <remarks/>
            public byte MET_ISSL
            {
                get
                {
                    return this.mET_ISSLField;
                }
                set
                {
                    this.mET_ISSLField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool MET_ISSLSpecified
            {
                get
                {
                    return this.mET_ISSLFieldSpecified;
                }
                set
                {
                    this.mET_ISSLFieldSpecified = value;
                }
            }

            /// <remarks/>
            public string NAPR_USL
            {
                get
                {
                    return this.nAPR_USLField;
                }
                set
                {
                    this.nAPR_USLField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ZL_LISTZAPZ_SLSLUCHCONS
        {

            private byte pR_CONSField;

            private System.DateTime dT_CONSField;

            private bool dT_CONSFieldSpecified;

            /// <remarks/>
            public byte PR_CONS
            {
                get
                {
                    return this.pR_CONSField;
                }
                set
                {
                    this.pR_CONSField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime DT_CONS
            {
                get
                {
                    return this.dT_CONSField;
                }
                set
                {
                    this.dT_CONSField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool DT_CONSSpecified
            {
                get
                {
                    return this.dT_CONSFieldSpecified;
                }
                set
                {
                    this.dT_CONSFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ZL_LISTZAPZ_SLSLUCHONK_SL
        {

            private byte dS1_TField;

            private ushort sTADField;

            private ushort oNK_TField;

            private byte oNK_NField;

            private byte oNK_MField;

            private byte mTSTZField;

            private bool mTSTZFieldSpecified;

            private ZL_LISTZAPZ_SLSLUCHONK_SLB_DIAG[] b_DIAGField;

            private ZL_LISTZAPZ_SLSLUCHONK_SLONK_USL[] oNK_USLField;

            /// <remarks/>
            public byte DS1_T
            {
                get
                {
                    return this.dS1_TField;
                }
                set
                {
                    this.dS1_TField = value;
                }
            }

            /// <remarks/>
            public ushort STAD
            {
                get
                {
                    return this.sTADField;
                }
                set
                {
                    this.sTADField = value;
                }
            }

            /// <remarks/>
            public ushort ONK_T
            {
                get
                {
                    return this.oNK_TField;
                }
                set
                {
                    this.oNK_TField = value;
                }
            }

            /// <remarks/>
            public byte ONK_N
            {
                get
                {
                    return this.oNK_NField;
                }
                set
                {
                    this.oNK_NField = value;
                }
            }

            /// <remarks/>
            public byte ONK_M
            {
                get
                {
                    return this.oNK_MField;
                }
                set
                {
                    this.oNK_MField = value;
                }
            }

            /// <remarks/>
            public byte MTSTZ
            {
                get
                {
                    return this.mTSTZField;
                }
                set
                {
                    this.mTSTZField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool MTSTZSpecified
            {
                get
                {
                    return this.mTSTZFieldSpecified;
                }
                set
                {
                    this.mTSTZFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("B_DIAG")]
            public ZL_LISTZAPZ_SLSLUCHONK_SLB_DIAG[] B_DIAG
            {
                get
                {
                    return this.b_DIAGField;
                }
                set
                {
                    this.b_DIAGField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("ONK_USL")]
            public ZL_LISTZAPZ_SLSLUCHONK_SLONK_USL[] ONK_USL
            {
                get
                {
                    return this.oNK_USLField;
                }
                set
                {
                    this.oNK_USLField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ZL_LISTZAPZ_SLSLUCHONK_SLB_DIAG
        {

            private byte dIAG_TIPField;

            private byte dIAG_CODEField;

            private byte dIAG_RSLTField;

            /// <remarks/>
            public byte DIAG_TIP
            {
                get
                {
                    return this.dIAG_TIPField;
                }
                set
                {
                    this.dIAG_TIPField = value;
                }
            }

            /// <remarks/>
            public byte DIAG_CODE
            {
                get
                {
                    return this.dIAG_CODEField;
                }
                set
                {
                    this.dIAG_CODEField = value;
                }
            }

            /// <remarks/>
            public byte DIAG_RSLT
            {
                get
                {
                    return this.dIAG_RSLTField;
                }
                set
                {
                    this.dIAG_RSLTField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ZL_LISTZAPZ_SLSLUCHONK_SLONK_USL
        {

            private byte uSL_TIPField;

            private byte lEK_TIP_LField;

            private bool lEK_TIP_LFieldSpecified;

            private byte lEK_TIP_VField;

            private bool lEK_TIP_VFieldSpecified;

            private ZL_LISTZAPZ_SLSLUCHONK_SLONK_USLLEK_PR[] lEK_PRField;

            private byte hIR_TIPField;

            private bool hIR_TIPFieldSpecified;

            /// <remarks/>
            public byte USL_TIP
            {
                get
                {
                    return this.uSL_TIPField;
                }
                set
                {
                    this.uSL_TIPField = value;
                }
            }

            /// <remarks/>
            public byte LEK_TIP_L
            {
                get
                {
                    return this.lEK_TIP_LField;
                }
                set
                {
                    this.lEK_TIP_LField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool LEK_TIP_LSpecified
            {
                get
                {
                    return this.lEK_TIP_LFieldSpecified;
                }
                set
                {
                    this.lEK_TIP_LFieldSpecified = value;
                }
            }

            /// <remarks/>
            public byte LEK_TIP_V
            {
                get
                {
                    return this.lEK_TIP_VField;
                }
                set
                {
                    this.lEK_TIP_VField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool LEK_TIP_VSpecified
            {
                get
                {
                    return this.lEK_TIP_VFieldSpecified;
                }
                set
                {
                    this.lEK_TIP_VFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("LEK_PR")]
            public ZL_LISTZAPZ_SLSLUCHONK_SLONK_USLLEK_PR[] LEK_PR
            {
                get
                {
                    return this.lEK_PRField;
                }
                set
                {
                    this.lEK_PRField = value;
                }
            }

            /// <remarks/>
            public byte HIR_TIP
            {
                get
                {
                    return this.hIR_TIPField;
                }
                set
                {
                    this.hIR_TIPField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool HIR_TIPSpecified
            {
                get
                {
                    return this.hIR_TIPFieldSpecified;
                }
                set
                {
                    this.hIR_TIPFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ZL_LISTZAPZ_SLSLUCHONK_SLONK_USLLEK_PR
        {

            private string rEGNUMField;

            private System.DateTime[] dATE_INJField;

            /// <remarks/>
            public string REGNUM
            {
                get
                {
                    return this.rEGNUMField;
                }
                set
                {
                    this.rEGNUMField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("DATE_INJ", DataType = "date")]
            public System.DateTime[] DATE_INJ
            {
                get
                {
                    return this.dATE_INJField;
                }
                set
                {
                    this.dATE_INJField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ZL_LISTZAPZ_SLSLUCHKSG_KPG
        {

            private ushort kSGField;

            private decimal kOEF_ZField;

            private decimal kOEF_UPField;

            private decimal bZTSZField;

            private decimal kOEF_DField;

            private decimal kOEF_UField;

            private string kSG_DKField;

            private byte sL_KField;

            private decimal iT_SLField;

            private bool iT_SLFieldSpecified;

            private ZL_LISTZAPZ_SLSLUCHKSG_KPGSL_KOEF[] sL_KOEFField;

            /// <remarks/>
            public ushort KSG
            {
                get
                {
                    return this.kSGField;
                }
                set
                {
                    this.kSGField = value;
                }
            }

            /// <remarks/>
            public decimal KOEF_Z
            {
                get
                {
                    return this.kOEF_ZField;
                }
                set
                {
                    this.kOEF_ZField = value;
                }
            }

            /// <remarks/>
            public decimal KOEF_UP
            {
                get
                {
                    return this.kOEF_UPField;
                }
                set
                {
                    this.kOEF_UPField = value;
                }
            }

            /// <remarks/>
            public decimal BZTSZ
            {
                get
                {
                    return this.bZTSZField;
                }
                set
                {
                    this.bZTSZField = value;
                }
            }

            /// <remarks/>
            public decimal KOEF_D
            {
                get
                {
                    return this.kOEF_DField;
                }
                set
                {
                    this.kOEF_DField = value;
                }
            }

            /// <remarks/>
            public decimal KOEF_U
            {
                get
                {
                    return this.kOEF_UField;
                }
                set
                {
                    this.kOEF_UField = value;
                }
            }

            /// <remarks/>
            public string KSG_DK
            {
                get
                {
                    return this.kSG_DKField;
                }
                set
                {
                    this.kSG_DKField = value;
                }
            }

            /// <remarks/>
            public byte SL_K
            {
                get
                {
                    return this.sL_KField;
                }
                set
                {
                    this.sL_KField = value;
                }
            }

            /// <remarks/>
            public decimal IT_SL
            {
                get
                {
                    return this.iT_SLField;
                }
                set
                {
                    this.iT_SLField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool IT_SLSpecified
            {
                get
                {
                    return this.iT_SLFieldSpecified;
                }
                set
                {
                    this.iT_SLFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("SL_KOEF")]
            public ZL_LISTZAPZ_SLSLUCHKSG_KPGSL_KOEF[] SL_KOEF
            {
                get
                {
                    return this.sL_KOEFField;
                }
                set
                {
                    this.sL_KOEFField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ZL_LISTZAPZ_SLSLUCHKSG_KPGSL_KOEF
        {

            private byte iDSLField;

            private decimal sL_KOEF_ZNField;

            /// <remarks/>
            public byte IDSL
            {
                get
                {
                    return this.iDSLField;
                }
                set
                {
                    this.iDSLField = value;
                }
            }

            /// <remarks/>
            public decimal SL_KOEF_ZN
            {
                get
                {
                    return this.sL_KOEF_ZNField;
                }
                set
                {
                    this.sL_KOEF_ZNField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class ZL_LISTZAPZ_SLSLUCHUSL
        {

            private uint iDSERVField;

            private uint lPUField;

            private ushort lPU_1Field;

            private ushort pODRField;

            private byte pROFILField;

            private string vID_VMEField;

            private byte dETField;

            private System.DateTime dATE_INField;

            private System.DateTime dATE_OUTField;

            private byte p_OTKField;

            private bool p_OTKFieldSpecified;

            private string dsField;

            private string cODE_USLField;

            private decimal kOL_USLField;

            private decimal tARIFField;

            private decimal sUMV_USLField;

            private ushort pRVSField;

            private ulong cODE_MDField;

            private byte dENTAL_FField;

            private bool dENTAL_FFieldSpecified;

            private string dENT_SURFACEField;

            private string cOMENTUField;

            /// <remarks/>
            public uint IDSERV
            {
                get
                {
                    return this.iDSERVField;
                }
                set
                {
                    this.iDSERVField = value;
                }
            }

            /// <remarks/>
            public uint LPU
            {
                get
                {
                    return this.lPUField;
                }
                set
                {
                    this.lPUField = value;
                }
            }

            /// <remarks/>
            public ushort LPU_1
            {
                get
                {
                    return this.lPU_1Field;
                }
                set
                {
                    this.lPU_1Field = value;
                }
            }

            /// <remarks/>
            public ushort PODR
            {
                get
                {
                    return this.pODRField;
                }
                set
                {
                    this.pODRField = value;
                }
            }

            /// <remarks/>
            public byte PROFIL
            {
                get
                {
                    return this.pROFILField;
                }
                set
                {
                    this.pROFILField = value;
                }
            }

            /// <remarks/>
            public string VID_VME
            {
                get
                {
                    return this.vID_VMEField;
                }
                set
                {
                    this.vID_VMEField = value;
                }
            }

            /// <remarks/>
            public byte DET
            {
                get
                {
                    return this.dETField;
                }
                set
                {
                    this.dETField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime DATE_IN
            {
                get
                {
                    return this.dATE_INField;
                }
                set
                {
                    this.dATE_INField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime DATE_OUT
            {
                get
                {
                    return this.dATE_OUTField;
                }
                set
                {
                    this.dATE_OUTField = value;
                }
            }

            /// <remarks/>
            public byte P_OTK
            {
                get
                {
                    return this.p_OTKField;
                }
                set
                {
                    this.p_OTKField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool P_OTKSpecified
            {
                get
                {
                    return this.p_OTKFieldSpecified;
                }
                set
                {
                    this.p_OTKFieldSpecified = value;
                }
            }

            /// <remarks/>
            public string DS
            {
                get
                {
                    return this.dsField;
                }
                set
                {
                    this.dsField = value;
                }
            }

            /// <remarks/>
            public string CODE_USL
            {
                get
                {
                    return this.cODE_USLField;
                }
                set
                {
                    this.cODE_USLField = value;
                }
            }

            /// <remarks/>
            public decimal KOL_USL
            {
                get
                {
                    return this.kOL_USLField;
                }
                set
                {
                    this.kOL_USLField = value;
                }
            }

            /// <remarks/>
            public decimal TARIF
            {
                get
                {
                    return this.tARIFField;
                }
                set
                {
                    this.tARIFField = value;
                }
            }

            /// <remarks/>
            public decimal SUMV_USL
            {
                get
                {
                    return this.sUMV_USLField;
                }
                set
                {
                    this.sUMV_USLField = value;
                }
            }

            /// <remarks/>
            public ushort PRVS
            {
                get
                {
                    return this.pRVSField;
                }
                set
                {
                    this.pRVSField = value;
                }
            }

            /// <remarks/>
            public ulong CODE_MD
            {
                get
                {
                    return this.cODE_MDField;
                }
                set
                {
                    this.cODE_MDField = value;
                }
            }

            /// <remarks/>
            public byte DENTAL_F
            {
                get
                {
                    return this.dENTAL_FField;
                }
                set
                {
                    this.dENTAL_FField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool DENTAL_FSpecified
            {
                get
                {
                    return this.dENTAL_FFieldSpecified;
                }
                set
                {
                    this.dENTAL_FFieldSpecified = value;
                }
            }

            /// <remarks/>
            public string DENT_SURFACE
            {
                get
                {
                    return this.dENT_SURFACEField;
                }
                set
                {
                    this.dENT_SURFACEField = value;
                }
            }

            /// <remarks/>
            public string COMENTU
            {
                get
                {
                    return this.cOMENTUField;
                }
                set
                {
                    this.cOMENTUField = value;
                }
            }
        }


    }
}

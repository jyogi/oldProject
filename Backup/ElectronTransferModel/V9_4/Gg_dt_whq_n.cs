using System;
using ElectronTransferModel.Base;
using ElectronTransferModel.Geo;

namespace ElectronTransferModel.V9_4
{
    [Serializable]
    public class Gg_dt_whq_n : ElectronBase
    {
        public System.String CD_SSDW { get; set; }
        public System.String CD_WHDJ { get; set; }
        public System.String FSWSSGJS { get; set; }
        [Precision(10)]
        public System.Int64? G3E_CID { get; set; }
        [Precision(5)]
        public System.Int32? G3E_CNO { get; set; }
        [Precision(29)]
        public System.Decimal? GDO_GID { get; set; }
        [SelectOnly]
        public System.DateTime? LTT_DATE { get; set; }
        [SelectOnly]
        [Precision(29)]
        public System.Decimal? LTT_ID { get; set; }
        [SelectOnly]
        public System.String LTT_STATUS { get; set; }
        [SelectOnly]
        [Precision(29)]
        public System.Decimal? LTT_TID { get; set; }
        public System.String QXTJ { get; set; }
        public System.String SGTJ { get; set; }
        public System.String WHFW { get; set; }
        public System.String WSTZ { get; set; }
        public System.String WYFBZK { get; set; }
        public System.String YMDSL { get; set; }
    }
}
using System;
using ElectronTransferModel.Base;
using ElectronTransferModel.Geo;

namespace ElectronTransferModel.V9_4
{
    [Serializable]
    public class Gg_gh_xt_n : ElectronBase
    {
        public System.String BZ { get; set; }
        [Precision(7)]
        public System.Int32? CD_DYDJ { get; set; }
        public System.String CD_SSDW { get; set; }
        [Precision(10)]
        public System.Int64 G3E_CID { get; set; }
        [Precision(5)]
        public System.Int32 G3E_CNO { get; set; }
        [KeyField]
        public System.String GHBH { get; set; }
        [Precision(10)]
        public System.Int64? GHJXFID { get; set; }
        [SelectOnly]
        public System.DateTime? LTT_DATE { get; set; }
        [SelectOnly]
        [Precision(29)]
        public System.Decimal LTT_ID { get; set; }
        [SelectOnly]
        public System.String LTT_STATUS { get; set; }
        [SelectOnly]
        [Precision(29)]
        public System.Decimal? LTT_TID { get; set; }
        [Precision(29)]
        public System.Decimal? NF { get; set; }
        public System.String QS { get; set; }
        public System.String SBMC { get; set; }
    }
}

namespace AppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STD_WiegandFmt
    {
        public int id { get; set; }

        public int? DoorId { get; set; }

        [StringLength(100)]
        public string OutWiegandFmt { get; set; }

        public int? OutFailureId { get; set; }

        public int? OutAreaCode { get; set; }

        public int? OutPulseWidth { get; set; }

        public int? OutPulseInterval { get; set; }

        public int? OutContent { get; set; }

        [StringLength(100)]
        public string InWiegandFmt { get; set; }

        public int? InBitCount { get; set; }

        public int? InPulseWidth { get; set; }

        public int? InPulseInterval { get; set; }

        public int? InContent { get; set; }
    }
}

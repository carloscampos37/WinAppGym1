namespace ZKFingerSDKWindowsZK10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class iclock_oplog
    {
        public int id { get; set; }

        public int? SN { get; set; }

        public int admin { get; set; }

        public int OP { get; set; }

        public DateTime? OPTime { get; set; }

        public int? Object { get; set; }

        public int? Param1 { get; set; }

        public int? Param2 { get; set; }

        public int? Param3 { get; set; }
    }
}

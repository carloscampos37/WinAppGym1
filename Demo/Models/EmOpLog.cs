namespace ZKFingerSDKWindowsZK10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmOpLog")]
    public partial class EmOpLog
    {
        public int ID { get; set; }

        public int USERID { get; set; }

        public DateTime OperateTime { get; set; }

        public int? manipulationID { get; set; }

        public int? Params1 { get; set; }

        public int? Params2 { get; set; }

        public int? Params3 { get; set; }

        public int? Params4 { get; set; }

        [StringLength(5)]
        public string SensorId { get; set; }
    }
}

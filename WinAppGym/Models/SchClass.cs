namespace WinAppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SchClass")]
    public partial class SchClass
    {
        public int schClassid { get; set; }

        [Required]
        [StringLength(20)]
        public string schName { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public int? LateMinutes { get; set; }

        public int? EarlyMinutes { get; set; }

        public int? CheckIn { get; set; }

        public int? CheckOut { get; set; }

        public DateTime? CheckInTime1 { get; set; }

        public DateTime? CheckInTime2 { get; set; }

        public DateTime? CheckOutTime1 { get; set; }

        public DateTime? CheckOutTime2 { get; set; }

        public int? Color { get; set; }

        public short? AutoBind { get; set; }

        public float? WorkDay { get; set; }

        [StringLength(50)]
        public string SensorID { get; set; }

        public float? WorkMins { get; set; }
    }
}

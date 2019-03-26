namespace WinAppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServerLog")]
    public partial class ServerLog
    {
        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string EVENT { get; set; }

        public int USERID { get; set; }

        [StringLength(30)]
        public string EnrollNumber { get; set; }

        public short? parameter { get; set; }

        public DateTime EVENTTIME { get; set; }

        [StringLength(5)]
        public string SENSORID { get; set; }

        [StringLength(20)]
        public string OPERATOR { get; set; }
    }
}

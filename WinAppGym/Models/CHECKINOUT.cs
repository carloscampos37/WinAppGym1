namespace WinAppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHECKINOUT")]
    public partial class CHECKINOUT
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int USERID { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime CHECKTIME { get; set; }

        [StringLength(1)]
        public string CHECKTYPE { get; set; }

        public int? VERIFYCODE { get; set; }

        [StringLength(5)]
        public string SENSORID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LOGID { get; set; }

        public int? MachineId { get; set; }

        public int? UserExtFmt { get; set; }

        public int? WorkCode { get; set; }

        [StringLength(20)]
        public string Memoinfo { get; set; }

        [StringLength(20)]
        public string sn { get; set; }
    }
}

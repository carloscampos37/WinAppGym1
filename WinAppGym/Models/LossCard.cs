namespace WinAppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LossCard")]
    public partial class LossCard
    {
        public int id { get; set; }

        [StringLength(20)]
        public string Pin { get; set; }

        [StringLength(50)]
        public string CardNo { get; set; }

        public DateTime? LossDate { get; set; }
    }
}

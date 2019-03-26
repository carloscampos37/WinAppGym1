namespace WinAppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class base_option
    {
        public int id { get; set; }

        [StringLength(50)]
        public string change_operator { get; set; }

        public DateTime? change_time { get; set; }

        [StringLength(50)]
        public string create_operator { get; set; }

        public DateTime? create_time { get; set; }

        [StringLength(50)]
        public string delete_operator { get; set; }

        public DateTime? delete_time { get; set; }

        public int? status { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string app_label { get; set; }

        [StringLength(50)]
        public string catalog { get; set; }

        [StringLength(50)]
        public string group { get; set; }

        [StringLength(50)]
        public string widget { get; set; }

        public bool required { get; set; }

        [StringLength(50)]
        public string validator { get; set; }

        [StringLength(50)]
        public string verbose_name { get; set; }

        [StringLength(50)]
        public string help_text { get; set; }

        public bool visible { get; set; }

        [Column("default")]
        [StringLength(50)]
        public string _default { get; set; }

        public bool read_only { get; set; }

        public bool for_personal { get; set; }

        [Required]
        [StringLength(50)]
        public string type { get; set; }
    }
}

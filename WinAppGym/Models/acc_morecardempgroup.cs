namespace WinAppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class acc_morecardempgroup
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

        public int status { get; set; }

        [StringLength(50)]
        public string group_name { get; set; }

        [StringLength(50)]
        public string memo { get; set; }

        public int? StdGroupNo { get; set; }

        public int? StdGroupTz { get; set; }

        public int? StdGroupVT { get; set; }

        public bool? StdValidOnHoliday { get; set; }
    }
}

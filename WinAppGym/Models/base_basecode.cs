namespace WinAppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class base_basecode
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
        public string content { get; set; }

        public int? content_class { get; set; }

        [StringLength(50)]
        public string display { get; set; }

        [StringLength(50)]
        public string value { get; set; }

        [StringLength(50)]
        public string remark { get; set; }

        [StringLength(50)]
        public string is_add { get; set; }
    }
}

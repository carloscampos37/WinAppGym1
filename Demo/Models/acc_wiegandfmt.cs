namespace ZKFingerSDKWindowsZK10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class acc_wiegandfmt
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

        [Required]
        [StringLength(30)]
        public string wiegand_name { get; set; }

        public int? wiegand_count { get; set; }

        public int? odd_start { get; set; }

        public int? odd_count { get; set; }

        public int? even_start { get; set; }

        public int? even_count { get; set; }

        public int? cid_start { get; set; }

        public int? cid_count { get; set; }

        public int? comp_start { get; set; }

        public int? comp_count { get; set; }
    }
}

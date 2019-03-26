namespace AppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class base_operatortemplate
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

        public int? user_id { get; set; }

        [Column(TypeName = "image")]
        public byte[] template1 { get; set; }

        public int? finger_id { get; set; }

        public int? valid { get; set; }

        [StringLength(50)]
        public string fpversion { get; set; }

        public int? bio_type { get; set; }

        public DateTime? utime { get; set; }

        [Column(TypeName = "image")]
        public byte[] bitmap_picture { get; set; }

        [Column(TypeName = "image")]
        public byte[] bitmap_picture2 { get; set; }

        [Column(TypeName = "image")]
        public byte[] bitmap_picture3 { get; set; }

        [Column(TypeName = "image")]
        public byte[] bitmap_picture4 { get; set; }

        public int? use_type { get; set; }

        [Column(TypeName = "image")]
        public byte[] template2 { get; set; }

        [Column(TypeName = "image")]
        public byte[] template3 { get; set; }

        public bool template_flag { get; set; }
    }
}

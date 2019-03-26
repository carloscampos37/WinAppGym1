namespace ZKFingerSDKWindowsZK10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class acc_mapdoorpos
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

        public int? map_door_id { get; set; }

        public int? map_id { get; set; }

        public int? width { get; set; }

        public int? left { get; set; }

        public int? top { get; set; }
    }
}

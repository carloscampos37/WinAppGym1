namespace AppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class acc_interlock
    {
        public int id { get; set; }

        [StringLength(50)]
        public string change_operator { get; set; }

        public int? change_time { get; set; }

        [StringLength(50)]
        public string create_operator { get; set; }

        public DateTime? create_time { get; set; }

        [StringLength(50)]
        public string delete_operator { get; set; }

        public DateTime? delete_time { get; set; }

        public int status { get; set; }

        public int? device_id { get; set; }

        public bool one_mode { get; set; }

        public bool two_mode { get; set; }

        public bool three_mode { get; set; }

        public bool four_mode { get; set; }

        public int? InterlockType { get; set; }
    }
}

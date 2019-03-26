namespace WinAppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class acc_antiback
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

        public short status { get; set; }

        public int? device_id { get; set; }

        public bool one_mode { get; set; }

        public bool two_mode { get; set; }

        public bool three_mode { get; set; }

        public bool four_mode { get; set; }

        public bool five_mode { get; set; }

        public bool six_mode { get; set; }

        public bool seven_mode { get; set; }

        public bool eight_mode { get; set; }

        public bool nine_mode { get; set; }

        public int? AntibackType { get; set; }
    }
}

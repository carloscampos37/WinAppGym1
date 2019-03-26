namespace WinAppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class acc_levelset
    {
        public int id { get; set; }

        [StringLength(30)]
        public string change_operator { get; set; }

        public DateTime? change_time { get; set; }

        [StringLength(30)]
        public string create_operator { get; set; }

        public DateTime? create_time { get; set; }

        [StringLength(30)]
        public string delete_operator { get; set; }

        public DateTime? delete_time { get; set; }

        public short status { get; set; }

        [StringLength(30)]
        public string level_name { get; set; }

        public int? level_timeseg_id { get; set; }
    }
}

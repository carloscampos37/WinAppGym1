namespace AppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class worktable_msgtype
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
        public string msgtype_name { get; set; }

        [StringLength(50)]
        public string msgtype_value { get; set; }

        public int? msg_keep_time { get; set; }

        public int? msg_ahead_remind { get; set; }

        [StringLength(50)]
        public string type { get; set; }
    }
}

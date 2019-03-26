namespace AppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class acc_monitor_log
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

        public int? log_tag { get; set; }

        public DateTime? time { get; set; }

        [StringLength(50)]
        public string pin { get; set; }

        [StringLength(50)]
        public string card_no { get; set; }

        public int? device_id { get; set; }

        [StringLength(50)]
        public string device_sn { get; set; }

        [StringLength(50)]
        public string device_name { get; set; }

        public int? verified { get; set; }

        public int? state { get; set; }

        public int? event_type { get; set; }

        [StringLength(200)]
        public string description { get; set; }

        public int? event_point_type { get; set; }

        public int? event_point_id { get; set; }

        [StringLength(200)]
        public string event_point_name { get; set; }
    }
}

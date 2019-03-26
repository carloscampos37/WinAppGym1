namespace AppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class personnel_issuecard
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

        public int? UserID_id { get; set; }

        [StringLength(50)]
        public string cardno { get; set; }

        public DateTime? effectivenessdate { get; set; }

        public bool isvalid { get; set; }

        [StringLength(50)]
        public string cardpwd { get; set; }

        public DateTime? failuredate { get; set; }

        [StringLength(50)]
        public string cardstatus { get; set; }

        public DateTime? issuedate { get; set; }
    }
}

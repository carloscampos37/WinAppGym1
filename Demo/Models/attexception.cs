namespace ZKFingerSDKWindowsZK10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("attexception")]
    public partial class attexception
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

        public int? UserId { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public int? ExceptionID { get; set; }

        public int? AuditExcID { get; set; }

        public int? OldAuditExcID { get; set; }

        public int? OverlapTime { get; set; }

        public int? TimeLong { get; set; }

        public int? InScopeTime { get; set; }

        public DateTime? AttDate { get; set; }

        public int? OverlapWorkDayTai { get; set; }

        public int? OverlapWorkDay { get; set; }

        public int? schindex { get; set; }

        public int? Minsworkday { get; set; }

        public int? Minsworkday1 { get; set; }

        public int? schid { get; set; }
    }
}

namespace WinAppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class personnel_empchange
    {
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

        [Key]
        public int changeno { get; set; }

        public int? UserID_id { get; set; }

        public DateTime? changedate { get; set; }

        public int? changepostion { get; set; }

        [StringLength(50)]
        public string oldvalue { get; set; }

        [StringLength(50)]
        public string newvalue { get; set; }

        [StringLength(50)]
        public string changereason { get; set; }

        public bool isvalid { get; set; }

        public int? approvalstatus { get; set; }

        [StringLength(50)]
        public string remark { get; set; }
    }
}

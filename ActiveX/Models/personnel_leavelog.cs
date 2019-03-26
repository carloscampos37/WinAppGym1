namespace AppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class personnel_leavelog
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

        public DateTime? leavedate { get; set; }

        public int? leavetype { get; set; }

        [StringLength(50)]
        public string reason { get; set; }

        public bool isReturnTools { get; set; }

        public bool isReturnClothes { get; set; }

        public bool isReturnCard { get; set; }

        public bool isClassAtt { get; set; }

        public bool isClassAccess { get; set; }
    }
}

namespace WinAppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TmpPermitUsers
    {
        public int id { get; set; }

        public int? GroupId { get; set; }

        [StringLength(50)]
        public string CertifiNo { get; set; }

        [StringLength(24)]
        public string UserName { get; set; }

        [StringLength(2)]
        public string Gender { get; set; }

        [StringLength(20)]
        public string CardNo { get; set; }

        public DateTime? OfflineBeginDate { get; set; }

        public DateTime? OfflineEndDate { get; set; }
    }
}

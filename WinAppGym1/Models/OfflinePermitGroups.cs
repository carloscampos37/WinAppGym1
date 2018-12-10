namespace WinAppGym1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OfflinePermitGroups
    {
        public int id { get; set; }

        [StringLength(24)]
        public string GroupName { get; set; }

        public DateTime? BeginDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}

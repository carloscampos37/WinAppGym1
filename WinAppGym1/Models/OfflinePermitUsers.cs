namespace WinAppGym1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OfflinePermitUsers
    {
        public int id { get; set; }

        public int? GroupId { get; set; }

        [StringLength(24)]
        public string Pin { get; set; }

        public bool? ChkPwd { get; set; }

        public bool? ChkFp { get; set; }
    }
}

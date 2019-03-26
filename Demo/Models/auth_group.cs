namespace ZKFingerSDKWindowsZK10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class auth_group
    {
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public string Permission { get; set; }

        public string Remark { get; set; }
    }
}

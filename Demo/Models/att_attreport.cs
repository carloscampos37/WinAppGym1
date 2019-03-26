namespace ZKFingerSDKWindowsZK10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class att_attreport
    {
        [Key]
        [StringLength(50)]
        public string ItemName { get; set; }

        [StringLength(50)]
        public string ItemType { get; set; }

        public int? Author_id { get; set; }

        public string ItemValue { get; set; }

        public int? Published { get; set; }
    }
}

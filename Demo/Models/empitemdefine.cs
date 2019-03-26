namespace ZKFingerSDKWindowsZK10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("empitemdefine")]
    public partial class empitemdefine
    {
        [Key]
        [StringLength(100)]
        public string ItemName { get; set; }

        [StringLength(50)]
        public string ItemType { get; set; }

        public int? Author_id { get; set; }

        [StringLength(50)]
        public string ItemValue { get; set; }

        public short? Published { get; set; }
    }
}

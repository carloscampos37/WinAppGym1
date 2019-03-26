namespace ZKFingerSDKWindowsZK10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FingerVein")]
    public partial class FingerVein
    {
        [Key]
        public int FVID { get; set; }

        public int? UserID { get; set; }

        public int? FingerID { get; set; }

        [Column(TypeName = "image")]
        public byte[] Template { get; set; }

        public int? Size { get; set; }

        public int? DuressFlag { get; set; }

        [StringLength(50)]
        public string UserCode { get; set; }

        public int? Fv_ID_Index { get; set; }
    }
}

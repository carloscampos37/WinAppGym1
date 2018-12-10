namespace WinAppGym1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FaceTempEx")]
    public partial class FaceTempEx
    {
        [Key]
        public int TEMPLATEID { get; set; }

        [StringLength(24)]
        public string USERNO { get; set; }

        public int? SIZE { get; set; }

        public int? pin { get; set; }

        public int? FACEID { get; set; }

        public int? VALID { get; set; }

        public int? RESERVE { get; set; }

        public int? ACTIVETIME { get; set; }

        public int? VFCOUNT { get; set; }

        [Column(TypeName = "image")]
        public byte[] TEMPLATE { get; set; }

        public byte? FaceType { get; set; }

        [StringLength(6)]
        public string StateMigrationFlag { get; set; }
    }
}

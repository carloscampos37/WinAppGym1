namespace WinAppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TEMPLATE")]
    public partial class TEMPLATE
    {
        public int TEMPLATEID { get; set; }

        public int USERID { get; set; }

        public int FINGERID { get; set; }

        [Column("TEMPLATE", TypeName = "image")]
        public byte[] TEMPLATE1 { get; set; }

        [Column(TypeName = "image")]
        public byte[] TEMPLATE2 { get; set; }

        [Column(TypeName = "image")]
        public byte[] BITMAPPICTURE { get; set; }

        [Column(TypeName = "image")]
        public byte[] BITMAPPICTURE2 { get; set; }

        [Column(TypeName = "image")]
        public byte[] BITMAPPICTURE3 { get; set; }

        [Column(TypeName = "image")]
        public byte[] BITMAPPICTURE4 { get; set; }

        public short? USETYPE { get; set; }

        [StringLength(3)]
        public string EMACHINENUM { get; set; }

        [Column("TEMPLATE1", TypeName = "image")]
        public byte[] TEMPLATE11 { get; set; }

        public short? Flag { get; set; }

        public short? DivisionFP { get; set; }

        [Column(TypeName = "image")]
        public byte[] TEMPLATE4 { get; set; }

        [Column(TypeName = "image")]
        public byte[] TEMPLATE3 { get; set; }

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

        public int? Valid { get; set; }

        [StringLength(50)]
        public string Fpversion { get; set; }

        public int? bio_type { get; set; }

        public int? SN { get; set; }

        public DateTime? UTime { get; set; }
    }
}

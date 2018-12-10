namespace WinAppGym1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TEMPLATEEx")]
    public partial class TEMPLATEEx
    {
        [Key]
        [Column(Order = 0)]
        public int TEMPLATEID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int USERID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FINGERID { get; set; }

        [Column(TypeName = "image")]
        public byte[] TEMPLATE { get; set; }

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

        [Column(TypeName = "image")]
        public byte[] TEMPLATE1 { get; set; }

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

        [StringLength(6)]
        public string StateMigrationFlag { get; set; }
    }
}

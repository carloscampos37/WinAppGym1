namespace ZKFingerSDKWindowsZK10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("devlog")]
    public partial class devlog
    {
        public int id { get; set; }

        public int? SN_id { get; set; }

        [Required]
        [StringLength(40)]
        public string OP { get; set; }

        [StringLength(50)]
        public string Object { get; set; }

        public int Cnt { get; set; }

        public int ECnt { get; set; }

        public DateTime OpTime { get; set; }
    }
}

namespace ZKFingerSDKWindowsZK10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ParamSet")]
    public partial class ParamSet
    {
        [Key]
        [StringLength(20)]
        public string ParamName { get; set; }

        [StringLength(100)]
        public string ParamValue { get; set; }
    }
}

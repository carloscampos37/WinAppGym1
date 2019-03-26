namespace AppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserACPrivilege")]
    public partial class UserACPrivilege
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }

        public short ACGroupID { get; set; }

        public bool IsUseGroup { get; set; }

        public short? TimeZone1 { get; set; }

        public short? TimeZone2 { get; set; }

        public short? TimeZone3 { get; set; }
    }
}

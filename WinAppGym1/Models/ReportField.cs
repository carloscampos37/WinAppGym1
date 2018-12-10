namespace WinAppGym1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReportField")]
    public partial class ReportField
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CRId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string TableName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string FieldName { get; set; }

        public int ShowIndex { get; set; }
    }
}

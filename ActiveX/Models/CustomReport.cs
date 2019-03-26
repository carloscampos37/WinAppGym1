namespace AppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CustomReport")]
    public partial class CustomReport
    {
        public int id { get; set; }

        [StringLength(50)]
        public string ReportName { get; set; }

        [StringLength(50)]
        public string Memo { get; set; }
    }
}

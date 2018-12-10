namespace WinAppGym1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BioTemplate")]
    public partial class BioTemplate
    {
        public int UserID { get; set; }

        [Required]
        [StringLength(24)]
        public string BadgeNumber { get; set; }

        [StringLength(30)]
        public string CreateOperator { get; set; }

        public DateTime? CreateTime { get; set; }

        [Required]
        [StringLength(1)]
        public string ValidFlag { get; set; }

        [Required]
        [StringLength(1)]
        public string IsDuress { get; set; }

        public int BioType { get; set; }

        [Required]
        [StringLength(20)]
        public string Version { get; set; }

        public int? DataFormat { get; set; }

        public int TemplateNO { get; set; }

        public int TemplateNOIndex { get; set; }

        public int? nOldType { get; set; }

        [StringLength(3000)]
        public string TemplateData { get; set; }

        public int ID { get; set; }
    }
}

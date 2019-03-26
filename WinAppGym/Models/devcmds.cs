namespace WinAppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class devcmds
    {
        public int id { get; set; }

        [StringLength(50)]
        public string change_operator { get; set; }

        public DateTime? change_time { get; set; }

        [StringLength(50)]
        public string create_operator { get; set; }

        public DateTime? create_time { get; set; }

        [StringLength(50)]
        public string delete_operator { get; set; }

        public DateTime? delete_time { get; set; }

        public int status { get; set; }

        public int? SN_id { get; set; }

        public int? CmdOperate_id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string CmdContent { get; set; }

        public DateTime CmdCommitTime { get; set; }

        public DateTime? CmdTransTime { get; set; }

        public DateTime? CmdOverTime { get; set; }

        public int? CmdReturn { get; set; }

        [StringLength(50)]
        public string CmdReturnContent { get; set; }

        public bool CmdImmediately { get; set; }
    }
}

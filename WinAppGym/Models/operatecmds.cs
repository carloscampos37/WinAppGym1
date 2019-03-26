namespace WinAppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class operatecmds
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

        public int? status { get; set; }

        [StringLength(50)]
        public string Author_id { get; set; }

        [StringLength(50)]
        public string CmdContent { get; set; }

        public DateTime? CmdCommitTime { get; set; }

        public DateTime? commit_time { get; set; }

        public int? CmdReturn { get; set; }

        public int? process_count { get; set; }

        public int? success_flag { get; set; }

        [StringLength(50)]
        public string receive_data { get; set; }

        public int? cmm_type { get; set; }

        public int? cmm_system { get; set; }
    }
}

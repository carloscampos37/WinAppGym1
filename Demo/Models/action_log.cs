namespace ZKFingerSDKWindowsZK10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class action_log
    {
        public int id { get; set; }

        public DateTime? action_time { get; set; }

        public int? user_id { get; set; }

        public int? content_type_id { get; set; }

        public int? object_id { get; set; }

        [StringLength(50)]
        public string object_repr { get; set; }

        public int? action_flag { get; set; }

        [StringLength(500)]
        public string change_message { get; set; }
    }
}

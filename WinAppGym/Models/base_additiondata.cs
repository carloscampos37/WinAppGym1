namespace WinAppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class base_additiondata
    {
        public int id { get; set; }

        public DateTime? create_time { get; set; }

        public int? user_id { get; set; }

        public int? content_type_id { get; set; }

        [StringLength(50)]
        public string object_id { get; set; }

        [StringLength(50)]
        public string key { get; set; }

        [StringLength(50)]
        public string value { get; set; }

        [StringLength(50)]
        public string data { get; set; }

        public DateTime? delete_time { get; set; }
    }
}

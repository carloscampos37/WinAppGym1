namespace AppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class auth_permission
    {
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public int? content_type_id { get; set; }

        [StringLength(50)]
        public string codename { get; set; }
    }
}

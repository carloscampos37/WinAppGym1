namespace AppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class auth_message
    {
        public int id { get; set; }

        public int? user_id { get; set; }

        [StringLength(50)]
        public string message { get; set; }
    }
}

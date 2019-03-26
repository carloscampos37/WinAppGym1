namespace AppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class acc_firstopen_emp
    {
        public int id { get; set; }

        public int? accfirstopen_id { get; set; }

        public int? employee_id { get; set; }
    }
}

namespace WinAppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class acc_auxiliary
    {
        public long id { get; set; }

        public int? device_id { get; set; }

        public int? aux_no { get; set; }

        [StringLength(50)]
        public string printer_number { get; set; }

        [StringLength(50)]
        public string aux_name { get; set; }

        public int? aux_state { get; set; }
    }
}

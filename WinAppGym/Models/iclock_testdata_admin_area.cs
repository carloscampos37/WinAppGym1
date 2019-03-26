namespace WinAppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class iclock_testdata_admin_area
    {
        public int id { get; set; }

        public int? testdata_id { get; set; }

        public int? area_id { get; set; }
    }
}

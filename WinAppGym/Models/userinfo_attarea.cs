namespace WinAppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class userinfo_attarea
    {
        public int id { get; set; }

        public int employee_id { get; set; }

        public int area_id { get; set; }
    }
}

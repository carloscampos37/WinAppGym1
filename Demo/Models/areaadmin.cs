namespace ZKFingerSDKWindowsZK10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("areaadmin")]
    public partial class areaadmin
    {
        public int id { get; set; }

        public int? user_id { get; set; }

        public int? area_id { get; set; }
    }
}

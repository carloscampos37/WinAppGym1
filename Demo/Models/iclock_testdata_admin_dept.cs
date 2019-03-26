namespace ZKFingerSDKWindowsZK10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class iclock_testdata_admin_dept
    {
        public int id { get; set; }

        public int? testdata_id { get; set; }

        public int? department_id { get; set; }
    }
}

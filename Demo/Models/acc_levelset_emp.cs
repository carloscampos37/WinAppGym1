namespace ZKFingerSDKWindowsZK10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class acc_levelset_emp
    {
        public int id { get; set; }

        public int acclevelset_id { get; set; }

        public int employee_id { get; set; }
    }
}

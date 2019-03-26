namespace ZKFingerSDKWindowsZK10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class acc_levelset_door_group
    {
        public int id { get; set; }

        public int acclevelset_id { get; set; }

        public int accdoor_id { get; set; }

        public int? accdoor_no_exp { get; set; }

        public int? accdoor_device_id { get; set; }

        public int? level_timeseg_id { get; set; }
    }
}

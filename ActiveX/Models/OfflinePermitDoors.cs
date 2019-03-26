namespace AppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OfflinePermitDoors
    {
        public int id { get; set; }

        public int? GroupId { get; set; }

        public int? DeviceId { get; set; }

        public int? DoorNo { get; set; }
    }
}

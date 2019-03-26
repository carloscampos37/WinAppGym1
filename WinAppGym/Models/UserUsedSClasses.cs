namespace WinAppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserUsedSClasses
    {
        public int id { get; set; }

        public int UserId { get; set; }

        public int? SchId { get; set; }
    }
}

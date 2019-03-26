namespace ZKFingerSDKWindowsZK10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class acc_holidays
    {
        public int id { get; set; }

        [StringLength(50)]
        public string change_operator { get; set; }

        public DateTime? change_time { get; set; }

        [StringLength(50)]
        public string create_operator { get; set; }

        public DateTime? create_time { get; set; }

        [StringLength(50)]
        public string delete_operator { get; set; }

        public DateTime? delete_time { get; set; }

        public int status { get; set; }

        [StringLength(30)]
        public string holiday_name { get; set; }

        public int? holiday_type { get; set; }

        public DateTime start_date { get; set; }

        public DateTime end_date { get; set; }

        public int? loop_by_year { get; set; }

        [StringLength(70)]
        public string memo { get; set; }

        public int? HolidayNo { get; set; }

        public int? HolidayTZ { get; set; }
    }
}

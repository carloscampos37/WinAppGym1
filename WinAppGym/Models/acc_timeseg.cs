namespace WinAppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class acc_timeseg
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

        [StringLength(50)]
        public string timeseg_name { get; set; }

        [StringLength(70)]
        public string memo { get; set; }

        public DateTime sunday_start1 { get; set; }

        public DateTime? sunday_end1 { get; set; }

        public DateTime? sunday_start2 { get; set; }

        public DateTime? sunday_end2 { get; set; }

        public DateTime? sunday_start3 { get; set; }

        public DateTime? sunday_end3 { get; set; }

        public DateTime? monday_start1 { get; set; }

        public DateTime? monday_end1 { get; set; }

        public DateTime? monday_start2 { get; set; }

        public DateTime? monday_end2 { get; set; }

        public DateTime? monday_start3 { get; set; }

        public DateTime? monday_end3 { get; set; }

        public DateTime? tuesday_start1 { get; set; }

        public DateTime? tuesday_end1 { get; set; }

        public DateTime? tuesday_start2 { get; set; }

        public DateTime? tuesday_end2 { get; set; }

        public DateTime? tuesday_start3 { get; set; }

        public DateTime? tuesday_end3 { get; set; }

        public DateTime? wednesday_start1 { get; set; }

        public DateTime? wednesday_end1 { get; set; }

        public DateTime? wednesday_start2 { get; set; }

        public DateTime? wednesday_end2 { get; set; }

        public DateTime? wednesday_start3 { get; set; }

        public DateTime? wednesday_end3 { get; set; }

        public DateTime? thursday_start1 { get; set; }

        public DateTime? thursday_end1 { get; set; }

        public DateTime? thursday_start2 { get; set; }

        public DateTime? thursday_end2 { get; set; }

        public DateTime? thursday_start3 { get; set; }

        public DateTime? thursday_end3 { get; set; }

        public DateTime? friday_start1 { get; set; }

        public DateTime? friday_end1 { get; set; }

        public DateTime? friday_start2 { get; set; }

        public DateTime? friday_end2 { get; set; }

        public DateTime? friday_start3 { get; set; }

        public DateTime? friday_end3 { get; set; }

        public DateTime? saturday_start1 { get; set; }

        public DateTime? saturday_end1 { get; set; }

        public DateTime? saturday_start2 { get; set; }

        public DateTime? saturday_end2 { get; set; }

        public DateTime? saturday_start3 { get; set; }

        public DateTime? saturday_end3 { get; set; }

        public DateTime? holidaytype1_start1 { get; set; }

        public DateTime? holidaytype1_end1 { get; set; }

        public DateTime? holidaytype1_start2 { get; set; }

        public DateTime? holidaytype1_end2 { get; set; }

        public DateTime? holidaytype1_start3 { get; set; }

        public DateTime? holidaytype1_end3 { get; set; }

        public DateTime? holidaytype2_start1 { get; set; }

        public DateTime? holidaytype2_end1 { get; set; }

        public DateTime? holidaytype2_start2 { get; set; }

        public DateTime? holidaytype2_end2 { get; set; }

        public DateTime? holidaytype2_start3 { get; set; }

        public DateTime? holidaytype2_end3 { get; set; }

        public DateTime? holidaytype3_start1 { get; set; }

        public DateTime? holidaytype3_end1 { get; set; }

        public DateTime? holidaytype3_start2 { get; set; }

        public DateTime? holidaytype3_end2 { get; set; }

        public DateTime? holidaytype3_start3 { get; set; }

        public DateTime? holidaytype3_end3 { get; set; }

        public int? TimeZone1Id { get; set; }

        public int? TimeZone2Id { get; set; }

        public int? TimeZone3Id { get; set; }

        public int? TimeZoneHolidayId { get; set; }
    }
}

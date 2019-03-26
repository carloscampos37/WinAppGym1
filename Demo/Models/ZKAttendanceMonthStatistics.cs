namespace ZKFingerSDKWindowsZK10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ZKAttendanceMonthStatistics
    {
        public int Id { get; set; }

        public int? USERID { get; set; }

        public int? PortalSite { get; set; }

        public int? Department { get; set; }

        public int? Employee { get; set; }

        public int? Year { get; set; }

        public int? Month { get; set; }

        public decimal? YingDao { get; set; }

        public decimal? ShiDao { get; set; }

        public decimal? ChiDao { get; set; }

        public decimal? ZaoTui { get; set; }

        public decimal? KuangGong { get; set; }

        public decimal? JiaBan { get; set; }

        public decimal? WaiChu { get; set; }

        public decimal? YinGongWaiChu { get; set; }

        public decimal? GongZuoShiJian { get; set; }

        public decimal? YingQian { get; set; }

        public decimal? QianDao { get; set; }

        public decimal? QianTui { get; set; }

        public decimal? WeiQianDao { get; set; }

        public decimal? WeiQianTui { get; set; }

        public decimal? QingJia { get; set; }

        public decimal? PingRi { get; set; }

        public decimal? ZhouMo { get; set; }

        public decimal? JieJiaRi { get; set; }

        public decimal? ChuQinShiJian { get; set; }

        public decimal? PingRiJiaBan { get; set; }

        public decimal? ZhouMoJiaBan { get; set; }

        public decimal? JieJiaRiJiaBan { get; set; }
    }
}

namespace WinAppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Zk_Asistencia
    {
        public int ID { get; set; }

        public int? UserInfoID { get; set; }

        public DateTime? FechaAsistencia { get; set; }

        public DateTime? HoraAsistencia { get; set; }

        public virtual USERINFO USERINFO { get; set; }
    }
}

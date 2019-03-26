namespace ZKFingerSDKWindowsZK10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Zk_Turno
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string DescripcionTurno { get; set; }

        public bool? EstadoAnulado { get; set; }
    }
}

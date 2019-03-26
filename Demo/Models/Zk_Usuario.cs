namespace ZKFingerSDKWindowsZK10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Zk_Usuario
    {
        public int ID { get; set; }

        [StringLength(10)]
        public string CodigoID { get; set; }

        [StringLength(30)]
        public string Descripcion { get; set; }

        public int? NivelUsuario { get; set; }

        public bool? EstadoAnulado { get; set; }
    }
}

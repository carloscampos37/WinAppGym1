namespace ZKFingerSDKWindowsZK10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Zk_Membresias
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string DescripcionMembresias { get; set; }

        public int? PeriodosID { get; set; }

        public bool? Ilimitado { get; set; }

        public decimal? Precio { get; set; }

        public bool? EstadoAnulado { get; set; }

        public bool? MembresiaGrupo { get; set; }

        public int? CantidaddeSocios { get; set; }

        public DateTime? InicioVigencia { get; set; }

        public DateTime? TerminoVigencia { get; set; }

        public bool? TipoServicio { get; set; }
    }
}

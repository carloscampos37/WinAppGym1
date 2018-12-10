namespace WinAppGym1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class zz_Membresias
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }

        public int? PeriodosID { get; set; }

        public bool? Limitado { get; set; }

        public DateTime? FechaMaximaDuracion { get; set; }

        public decimal? Cantidad { get; set; }

        public decimal? Precio { get; set; }

        public bool? EstadoAnulado { get; set; }
    }
}

namespace WinAppGym1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MembresiasxSocio")]
    public partial class MembresiasxSocio
    {
        public int ID { get; set; }

        public int UserInfoID { get; set; }

        public int MembresiasID { get; set; }

        public DateTime? FechaInicio { get; set; }

        public DateTime? FechaFinal { get; set; }

        public decimal? Precio { get; set; }

        public decimal? descuento { get; set; }

        public decimal? ImportePactado { get; set; }

        public decimal? PagosaCuenta { get; set; }

        public DateTime? fechaMaximadePago { get; set; }

        public bool? EstadoCancelacion { get; set; }

        public int? UsuarioID { get; set; }

        public bool? EstadoAnulado { get; set; }

        public virtual Membresias Membresias { get; set; }

        public virtual USERINFO USERINFO { get; set; }
    }
}

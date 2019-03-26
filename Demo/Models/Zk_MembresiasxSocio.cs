namespace ZKFingerSDKWindowsZK10.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Zk_MembresiasxSocio
    {
        public int ID { get; set; }

        public int UserInfoID { get; set; }

        public int MembresiasID { get; set; }

        public DateTime? FechaInicio { get; set; }

        public DateTime? FechaFinal { get; set; }

        public decimal? Precio { get; set; }

        public decimal? descuento { get; set; }

        public decimal? PrecioPactado { get; set; }

        public DateTime? fechaMaximadePago { get; set; }

        public bool? EstadoCancelacion { get; set; }

        public int? UsuarioID { get; set; }

        public bool? EstadoAnulado { get; set; }

        public bool? Activacion { get; set; }

        public int? AutorizacionesID { get; set; }

        public decimal? Saldo { get; set; }

        public int? NroCuota { get; set; }

        public DateTime? FechaAct { get; set; }
    }
}

namespace WinAppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Zk_PagosSocios
    {
        public int ID { get; set; }

        public int? MembresiasxSocioID { get; set; }

        public int? NroCuota { get; set; }

        public DateTime? FechaPago { get; set; }

        public decimal? ImportePagado { get; set; }

        public int? TurnoID { get; set; }

        public int? FormaPagoID { get; set; }

        public int? UsuarioID { get; set; }

        public bool? EstadoAnulado { get; set; }

        public DateTime? FechaAct { get; set; }

        [StringLength(50)]
        public string Referencia { get; set; }

        public virtual Zk_FormaPago Zk_FormaPago { get; set; }

        public virtual Zk_MembresiasxSocio Zk_MembresiasxSocio { get; set; }

        public virtual Zk_Turno Zk_Turno { get; set; }

        public virtual Zk_Usuario Zk_Usuario { get; set; }
    }
}

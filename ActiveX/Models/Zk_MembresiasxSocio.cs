namespace AppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Zk_MembresiasxSocio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zk_MembresiasxSocio()
        {
            Zk_PagosSocios = new HashSet<Zk_PagosSocios>();
        }

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

        public virtual Zk_Autorizaciones Zk_Autorizaciones { get; set; }

        public virtual Zk_Membresias Zk_Membresias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zk_PagosSocios> Zk_PagosSocios { get; set; }
    }
}

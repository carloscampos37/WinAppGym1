namespace WinAppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Zk_Membresias
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zk_Membresias()
        {
            Zk_MembresiasxSocio = new HashSet<Zk_MembresiasxSocio>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string DescripcionMembresias { get; set; }

        public int? PeriodosID { get; set; }

        public bool? Ilimitado { get; set; }

        public int? Precio { get; set; }

        public bool? EstadoAnulado { get; set; }

        public bool? MembresiaGrupo { get; set; }

        public int? CantidaddeSocios { get; set; }

        public DateTime? InicioVigencia { get; set; }

        public DateTime? TerminoVigencia { get; set; }

        public bool? TipoServicio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zk_MembresiasxSocio> Zk_MembresiasxSocio { get; set; }
    }
}

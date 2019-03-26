namespace WinAppGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Zk_Autorizaciones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zk_Autorizaciones()
        {
            Zk_MembresiasxSocio = new HashSet<Zk_MembresiasxSocio>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string DescripcionAutorizacion { get; set; }

        public bool? EstadoAnulado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zk_MembresiasxSocio> Zk_MembresiasxSocio { get; set; }
    }
}

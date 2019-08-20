namespace QuanLyKho.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Suplier")]
    public partial class Suplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Suplier()
        {
            Objects = new HashSet<Object>();
        }

        public int Id { get; set; }

        public string DisplayName { get; set; }

        public string Address { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        public string MoreInfo { get; set; }

        public DateTime? ContractDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Object> Objects { get; set; }
    }
}

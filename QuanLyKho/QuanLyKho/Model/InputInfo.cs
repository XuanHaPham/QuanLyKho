namespace QuanLyKho.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InputInfo")]
    public partial class InputInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InputInfo()
        {
            OutputInfoes = new HashSet<OutputInfo>();
        }

        public string Id { get; set; }

        [Required]
        [StringLength(128)]
        public string IdObject { get; set; }

        [Required]
        [StringLength(128)]
        public string IdInput { get; set; }

        public int? Count { get; set; }

        public double? InputPrice { get; set; }

        public double? OutputPrice { get; set; }

        public string Status { get; set; }

        public virtual Input Input { get; set; }

        public virtual Object Object { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OutputInfo> OutputInfoes { get; set; }
    }
}

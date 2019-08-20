namespace QuanLyKho.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OutputInfo")]
    public partial class OutputInfo
    {
        public string Id { get; set; }

        [Required]
        [StringLength(128)]
        public string IdObject { get; set; }

        [Required]
        [StringLength(128)]
        public string IdOutput { get; set; }

        public int IdCustomer { get; set; }

        public int? Count { get; set; }

        public string Status { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual InputInfo InputInfo { get; set; }

        public virtual Object Object { get; set; }

        public virtual Output Output { get; set; }
    }
}

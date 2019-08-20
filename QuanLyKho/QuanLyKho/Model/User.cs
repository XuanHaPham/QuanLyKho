namespace QuanLyKho.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        public int Id { get; set; }

        public string DisplayName { get; set; }

        [StringLength(100)]
        public string UserName { get; set; }

        public string Password { get; set; }

        public int IdRole { get; set; }

        public virtual UserRole UserRole { get; set; }
    }
}

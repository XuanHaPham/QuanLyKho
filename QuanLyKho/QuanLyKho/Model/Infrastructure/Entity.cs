using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKho.Model
{
    public abstract class BaseEntity
    {
        public bool Deleted { get; set; }
    }

    public abstract class Entity<T> : BaseEntity, IEntity<T>
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public virtual T Id { get; set; }
    }
}

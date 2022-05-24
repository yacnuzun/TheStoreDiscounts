using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entity
{
    public class Customer:IEntity
    {
        [Key]
        public int Id { get; set; }
        public int FullName { get; set; }
        public int Card { get; set; }
        public int Affilation { get; set; }
        public DateTime Üyelik { get; set; }

    }
}

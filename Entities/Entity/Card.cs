using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entity
{
    
    public class Card:IEntity
    {
        [Key]
        public int Id { get; set; }
        public string? CardType { get; set; }
    }
}

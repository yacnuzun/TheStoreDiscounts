using Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entity
{
    public enum CardTypes
    {
        Gold,
        Silver,
        Not
    }
    public class Customer:IEntity
    {
        [Key]
        public int Id { get; set; }
        public string? FullName { get; set; }
        public CardTypes Card { get; set; }
        public bool Affilation { get; set; }
        public DateTime MemberDateTime { get; set; }

    }
}

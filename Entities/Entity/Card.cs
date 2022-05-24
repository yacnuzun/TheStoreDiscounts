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
        Silver
    }
    public class Card:IEntity
    {
        [Key]
        public int Id { get; set; }
        public CardTypes CardType { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeFit.Model
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }

        [ForeignKey("User")]
        public int SellerId { get; set; }

        public DateTime BuyDate { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public int TimesUsed { get; set; }

        [ForeignKey("Type")]
        public int TypeId { get; set; }
    }
}

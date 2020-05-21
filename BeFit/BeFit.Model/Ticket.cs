using System;
using System.ComponentModel.DataAnnotations;

namespace BeFit.Model
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }

        public Client Client { get; set; }
        public User Seller { get; set; }

        public DateTime BuyDate { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public int RemainingEntries { get; set; }

        public TicketType Type { get; set; }
    }
}

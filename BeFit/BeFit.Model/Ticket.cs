using System;
using System.ComponentModel.DataAnnotations;

namespace BeFit.Model
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public DateTime? BuyDate { get; set; }

        public DateTime? Start { get; set; }

        public DateTime? End { get; set; }

        public int? RemainingEntries { get; set; }
        public int TicketTypeId { get; set; }
        public TicketType TicketType { get; set; }
    }
}

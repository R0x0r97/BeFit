using System;
using System.ComponentModel.DataAnnotations;

namespace BeFit.Model
{
    public class TicketType
    {
        [Key]
        public int Id { get; set; }

        public float Price { get; set; }

        public int? TimesUsable { get; set; }

        public int? LengthInDays { get; set; }

        public string Name { get; set; }

        public bool isDeleted { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeFit.Model
{
    public class Entry
    {
        [Key]
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public Client Client { get; set; }
    }
}

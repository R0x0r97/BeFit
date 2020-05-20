using System;
using System.ComponentModel.DataAnnotations;

namespace BeFit.Model
{
    public class Type
    {
        [Key]
        public int Id { get; set; }

        public float Price { get; set; }

        public int TimesUsable { get; set; }

        public int LengthInDays { get; set; }

        public String Name { get; set; }

        public Boolean isDeleted { get; set; }
    }
}

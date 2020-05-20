using System;
using System.ComponentModel.DataAnnotations;

namespace BeFit.Model
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        public DateTime BirthDate { get; set; }

        public String Name { get; set; }

        public String Email { get; set; }

        public String PhoneNumber { get; set; }

        public Boolean IsDeleted { get; set; }

        public String Picture { get; set; }
    }
}

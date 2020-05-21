using System;
using System.ComponentModel.DataAnnotations;

namespace BeFit.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public bool IsAdmin { get; set; }
    }
}

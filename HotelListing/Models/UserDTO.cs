using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Models
{

    public class LoginUserDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    } 
    public class UserDTO : LoginUserDTO
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
           
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public ICollection<String> Roles { get; set; }
    }
}

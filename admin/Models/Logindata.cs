using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace admin.Models
{
    public class Logindata { 


        [Required(ErrorMessage = "Email is empty.Please fill the blank")]
        public string Email { get; set; }
        [MinLength(8)]
        [MaxLength(16)]
        public string Password { get; set; } 
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Northwİnd.Blazor.Models
{
    public class LoginModel
    {
        [Required]        
        public string UsernameOrEmailAddress { get; set; }

        [Required]        
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}

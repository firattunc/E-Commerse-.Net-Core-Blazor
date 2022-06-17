using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProjectBlazor.Models
{
    public class RegisterModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string SurName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required,EmailAddress()]
        public string EmailAddress { get; set; }
        [Required]
        public string Password { get; set; }
    }
}

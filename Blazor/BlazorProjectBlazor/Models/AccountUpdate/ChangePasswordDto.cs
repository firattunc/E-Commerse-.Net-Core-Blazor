using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorProjectBlazor.Models.AccountUpdate
{
    public class ChangePasswordDto
    {
        [Required]  
        public string CurrentPassword { get; set; }

        [Required]
        public string NewPassword { get; set; }
    }
}

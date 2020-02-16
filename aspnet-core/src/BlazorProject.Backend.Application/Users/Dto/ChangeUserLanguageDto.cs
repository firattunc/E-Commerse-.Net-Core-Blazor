using System.ComponentModel.DataAnnotations;

namespace BlazorProject.Backend.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
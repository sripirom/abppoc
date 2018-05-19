using System.ComponentModel.DataAnnotations;

namespace Bathawk.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
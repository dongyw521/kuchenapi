using System.ComponentModel.DataAnnotations;

namespace kuchen.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
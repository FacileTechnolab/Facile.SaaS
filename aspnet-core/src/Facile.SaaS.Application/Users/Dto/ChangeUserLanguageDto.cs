using System.ComponentModel.DataAnnotations;

namespace Facile.SaaS.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
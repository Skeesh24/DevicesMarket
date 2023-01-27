using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace DevicesMarket.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string? CodeWord { get; set; }

        [Display(Name = "Названия страницы(заголовок)")]
        public override string? Title { get; set; }

        [Display(Name = "Содержание страницы")]
        public override string? Desc { get; set; }

    }
}

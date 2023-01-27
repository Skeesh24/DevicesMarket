using System.ComponentModel.DataAnnotations;

namespace DevicesMarket.Domain.Entities
{
    public class Product : EntityBase
    {
        [Required]
        [Display(Name = "Названия товара")]
        public override string? Title { get; set; }

        [Display(Name = "Краткое описание товара")]
        public override string? Desc { get; set; }

        [Display(Name = "Цена")]
        public int Price { get; set; }

        [Display(Name = "Титульная картинка")]
        public override string? TitleImagePath { get; set; }
    }
}

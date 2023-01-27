using System.ComponentModel.DataAnnotations;

namespace DevicesMarket.Domain.Entities
{
    // класс дефолт сущности для энтити фрейма
    public abstract class EntityBase
    {
        protected EntityBase() => CreationTime = DateTime.UtcNow;

        // эта нотация означает первичный ключ
        [Required]
        public Guid Id { get; set; }

        // обычные атрибуты
        [Display(Name = "Название (заголовок)")]
        public virtual string? Title { get; set; }

        [Display(Name = "Краткое описание")]
        public virtual string? Subtitle { get; set; }

        [Display(Name = "Полное описание")]
        public virtual string? Desc { get; set; }

        [Display(Name = "Титульная картинка")]
        public virtual string? TitleImagePath { get; set; }

        [DataType(DataType.Time)]
        public DateTime CreationTime { get; }
    }
}

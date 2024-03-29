using System.ComponentModel.DataAnnotations;

namespace WebAppProject1.Models
{
    public class Form
    {
        [Display(Name = "Просмотрено")]
        public bool IsWatched {  get; set; }

        [Display(Name = "Вид медиа")]
        public string Type { get; set; }

        [Display(Name = "Название")]
        public string Name { get; set; }

        [Display(Name = "Рейтинг")]
        public double Rating { get; set; }
    }
}

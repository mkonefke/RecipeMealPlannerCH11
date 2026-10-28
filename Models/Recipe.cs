using System.ComponentModel.DataAnnotations;

namespace RecipeMealPlanner.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a recipe title.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Title must be between 3 and 100 characters.")]
        [Display(Name = "Recipe Title")]
        [RegularExpression(@"^[a-zA-Z0-9\s'-]+$", ErrorMessage = "Title can only contain letters, numbers, spaces, apostrophes, and hyphens.")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Category is required.")]
        [StringLength(50)]
        [RegularExpression(@"^[a-zA-Z\s&'-]+$", ErrorMessage = "Category can only contain letters and spaces.")]
        public string Category { get; set; } = string.Empty;

        [Required]
        [Range(1, 480, ErrorMessage = "Prep time must be between 1 and 480 minutes.")]
        [Display(Name = "Prep Time (mins)")]
        public int PrepTimeMinutes { get; set; }

        [Required]
        [Range(1, 20, ErrorMessage = "Servings must be between 1 and 20.")]
        public int Servings { get; set; }

        [Required]
        [StringLength(2000, MinimumLength = 10, ErrorMessage = "Instructions must be at least 10 characters long.")]
        [DataType(DataType.MultilineText)]
        public string Instructions { get; set; } = string.Empty;
    }
}

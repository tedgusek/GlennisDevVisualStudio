using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeShare.Models
{
    public class Recipes
    {
        // setting unique ID for each recipe
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RecipeId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Instructions { get; set; }

        public string Image { get; set; }

        // for rating and comments of recipe
        public double Ratings { get; set; }

        public string Comments { get; set; }


    }
}


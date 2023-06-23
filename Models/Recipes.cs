﻿using System;
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

        // will hold the directory to the image, not the image itself
        public string Image { get; set; }

        // for rating and comments of recipe
        public double RatingsAverage { get; set; }

        //public string Comments { get; set; }


    }
}


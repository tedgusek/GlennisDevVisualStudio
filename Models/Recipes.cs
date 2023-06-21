using System;
namespace RecipeShare.Models
{
	public class Recipes
	{
		// setting unique ID for each recipe
		public int RecipeId { get; set; }

		public string Title { get; set; }

		public string Instructions { get; set; }

		public string Image { get; set; }

		// for rating and comments of recipe
		public double Ratings { get; set; }

		public string Comments { get; set; }


	}
}


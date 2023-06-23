using System.Linq;
using RecipeShare.Data;

namespace RecipeShare.Services
{
    public class RatingsAverage
    {
        private readonly ApplicationDbContext _dbContext;

        public RatingsAverage(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public double CalculateAverage(int recipeId)
        {
            var ratings = _dbContext.RatingsAverage.Where(r => r.RecipeId == recipeId).ToList();

            if (ratings.Any())
            {
                double average = ratings.Average(r => r.Value);
                return average;
            }

            return 0; // Return 0 if no ratings found
        }
    }
}

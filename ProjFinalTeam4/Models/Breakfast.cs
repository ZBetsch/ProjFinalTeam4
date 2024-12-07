namespace ProjFinalTeam4.Models
{
    public class Breakfast
    {
        // Properties
        public int BreakfastId { get; set; }
        public string BreakfastName { get; set; }
        public string BreakfastType { get; set; }
        public int Calories { get; set; }
        public string FavoriteIngredient { get; set; }
        public bool IsHealthy { get; set; }

        // Constructors
        public Breakfast() { }

        public Breakfast(int breakfastId, string breakfastName, string breakfastType, int calories, string favoriteIngredient, bool isHealthy)
        {
            this.BreakfastId = breakfastId;
            this.BreakfastName = breakfastName;
            this.BreakfastType = breakfastType;
            this.Calories = calories;
            this.FavoriteIngredient = favoriteIngredient;
            this.IsHealthy = isHealthy;
        }
    }
}

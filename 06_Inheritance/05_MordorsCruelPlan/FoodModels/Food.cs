namespace _05_MordorsCruelPlan.FoodModels
{
    abstract class Food
    {
        public int Points { get; }

        public override string ToString() => GetType().Name;

        public Food(int points)
        {
            Points = points;
        }
    }
}

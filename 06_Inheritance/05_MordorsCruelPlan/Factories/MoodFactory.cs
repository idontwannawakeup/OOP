using _05_MordorsCruelPlan.MoodModels;

namespace _05_MordorsCruelPlan.Factories
{
    static class MoodFactory
    {
        public static Mood MakeMood(int pointsOfHappiness)
        {
            if (pointsOfHappiness < -5)
            {
                return new Mood("Angry");
            }
            else if (pointsOfHappiness >= -5 && pointsOfHappiness <= 0)
            {
                return new Mood("Sad");
            }
            else if (pointsOfHappiness > 0 && pointsOfHappiness <= 15)
            {
                return new Mood("Happy");
            }
            else
            {
                return new Mood("JavaScript");
            }
        }
    }
}

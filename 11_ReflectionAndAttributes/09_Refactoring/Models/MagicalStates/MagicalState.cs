namespace _09_Refactoring.Models.MagicalStates
{
    public class MagicalState
    {
        public int AdditionToMinDamage { get; }

        public int AdditionToMaxDamage { get; }

        public MagicalState(int additionToMinDamage, int additionToMaxDamage)
        {
            this.AdditionToMinDamage = additionToMinDamage;
            this.AdditionToMaxDamage = additionToMaxDamage;
        }
    }
}

namespace _08_CreateCustomClassAttribute.Models.MagicalStates
{
    class MagicalState
    {
        public int AdditionToMinDamage { get; }

        public int AdditionToMaxDamage { get; }

        public MagicalState(int additionToMinDamage, int additionToMaxDamage)
        {
            AdditionToMinDamage = additionToMinDamage;
            AdditionToMaxDamage = additionToMaxDamage;
        }
    }
}

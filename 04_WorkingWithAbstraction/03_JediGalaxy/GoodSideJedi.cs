namespace _03_JediGalaxy
{
    class GoodSideJedi : Jedi
    {
        public override void Shoot(Galaxy galaxy)
        {
            int i = position.x;
            int j = position.y;

            while (i >= 0 && j < galaxy.Cols)
            {
                Score += galaxy.Field[i, j];
                galaxy.Field[i, j] = 0;
                i--;
                j++;
            }
        }
    }
}

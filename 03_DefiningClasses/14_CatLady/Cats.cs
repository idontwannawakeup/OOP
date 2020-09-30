namespace _14_CatLady
{
    class Cat
    {
        public string Name { get; protected set; }
    }

    class Siamese : Cat
    {
        public int Earsize { get; }

        public override string ToString()
        {
            return new string($"{typeof(Siamese).Name} {Name} {Earsize}");
        }

        public Siamese(string name, int earsize)
        {
            Name = name;
            Earsize = earsize;
        }
    }

    class Cymric : Cat
    {
        public double FurLength { get; }

        public override string ToString()
        {
            return new string($"{typeof(Cymric).Name} {Name} {FurLength:0.00}");
        }

        public Cymric(string name, double furLength)
        {
            Name = name;
            FurLength = furLength;
        }
    }

    class StreetExtraordinaire : Cat
    {
        public int DecibelsOfMeows { get; }

        public override string ToString()
        {
            return new string($"{typeof(StreetExtraordinaire).Name} {Name} {DecibelsOfMeows}");
        }

        public StreetExtraordinaire(string name, int decibelsOfMeows)
        {
            Name = name;
            DecibelsOfMeows = decibelsOfMeows;
        }
    }
}

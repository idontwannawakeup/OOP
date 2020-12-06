namespace _08_CreateCustomClassAttribute.Attributes
{
    using System;

    class WeaponInfoAttribute : Attribute
    {
        public string Author { get; set; }

        public string Revision { get; set; }

        public string Description { get; set; }

        public string Reviewers { get; set; }
    }
}

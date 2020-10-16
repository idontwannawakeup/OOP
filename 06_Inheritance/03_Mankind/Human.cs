using System;
using System.Text;

namespace _03_Mankind
{
    class Human
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get => firstName;
            protected set
            {
                if (!char.IsUpper(value[0]))
                    throw new ArgumentException("Expected upper case letter! " +
                                                "Argument: firstName");

                if (value.Length < 4)
                    throw new ArgumentException("Expected length at least 4 symbols! " +
                                                "Argument: firstName");

                firstName = value;
            }
        }

        public string LastName
        {
            get => lastName;
            protected set
            {
                if (!char.IsUpper(value[0]))
                    throw new ArgumentException("Expected upper case letter! " +
                                                "Argument: lastName");

                if (value.Length < 3)
                    throw new ArgumentException("Expected length at least 3 symbols! " +
                                                "Argument: lastName");

                lastName = value;
            }
        }

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"First Name: {FirstName}")
                         .AppendLine($"Last Name: {LastName}");

            return resultBuilder.ToString().TrimEnd();
        }

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}

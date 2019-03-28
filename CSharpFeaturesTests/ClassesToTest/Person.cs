using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeaturesTests.ClassesToTest
{
    public class Person
    {
        public string FirstName { get; } = "Bob";
        public string LastName { get; } = "Barker";
        public static int DefaultAge { get; } = 12;
        public string FullName => (FirstName == "Garrett") ? $"Joshua {FirstName} {LastName}" : $"{FirstName} {LastName}";

        public Person()
        {

        }

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public void GetSuffixed(string suffix, out string suffixed) {
            suffixed = $"{FullName}, {suffix}";
        }
    }
}

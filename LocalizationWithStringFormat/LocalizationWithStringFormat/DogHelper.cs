using System;
using System.Collections.Generic;
using System.Text;

namespace LocalizationWithStringFormat
{
    public class DogHelper
    {
        public static List<Dog> GetDogs()
        {
            return new List<Dog>
            {
                new Dog
                {
                      Name = "Max",
                      SpecialAbility = "Treat detector"
                },
                new Dog
                {
                      Name = "Ranger",
                      SpecialAbility = "Chases squirels"
                },
                new Dog
                {
                      Name = "Nova",
                      SpecialAbility = "Does a really good sit"
                },
                new Dog
                {
                      Name = "Rex",
                      SpecialAbility = "Can jump on tables"
                },
                new Dog
                {
                      Name = "Speedy",
                      SpecialAbility = "Super fast"
                },
            };
        }
    }
}

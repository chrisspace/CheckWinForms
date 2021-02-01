using System;
using System.Collections.Generic;
using System.Text;

namespace PetMiniProject
{
    class Pet
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Age { get; set; }


        public Pet(string name, string type, decimal age)
        {
            Name = name;
            Type = type;
            Age = age;
        }
    }
}

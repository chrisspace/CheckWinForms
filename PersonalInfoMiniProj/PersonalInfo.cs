using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalInfoMiniProj
{
    public class PersonalInfo
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public PersonalInfo(string name, string address, int age, string phone)
        {
            Name = name;            
            Address = address;
            Age = age;
            Phone = phone;
        }

        public override string ToString()
        {
            string s=String.Format("Name: {0}" + Environment.NewLine +
                                "Address: {1}" + Environment.NewLine +
                                "Age: {2}" + Environment.NewLine +
                                "Phone: {3}" + Environment.NewLine,
                                Name, Address, Age, Phone);
                                    
            return s;
        }
    }
}

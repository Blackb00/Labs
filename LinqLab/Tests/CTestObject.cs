using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    
        [Serializable]
        class CTestObject : IPersonable
        {
            public string Name { get; set; }
            public string SecondName { get; set; }
            public int Age { get; set; }
            public string Country { get; set; }

            public CTestObject(string name, string sname, string country, int age)
            {
                this.Name = name;
                this.SecondName = sname;
                this.Age = age;
                this.Country = country;


            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                    return false;
                if (!(obj is CTestObject testObj)) 
                    return false;
                return this.Name.Equals(testObj.Name)
                       && this.SecondName.Equals(testObj.SecondName)
                       && this.Country.Equals(testObj.Country)
                       && this.Age.Equals(testObj.Age);
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }
        }
    
}

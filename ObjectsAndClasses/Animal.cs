using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsAndClasses
{
    class Animal
    {

        //field
        private string petName;
        //method
        public void SetPetName(string petName)
        {
            this.petName = petName;
        }
        public string GetPetName()
        {
            return petName;
        }

        private int age;
        //method
        public void SetAge(int age)
        {
            this.age = age;
        }
        public int GetAge()
        {
            return age;
        }
        // property
        public int CanFly { get; set; }

    }
}

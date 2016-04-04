using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Person
    {
        public enum Genders: int { Male, Female};
        public Genders gender;
        private string name;
        private DateTime birthDate;

        public Person()
        {}

        public Person(string name, DateTime birthDate, Genders gender)
        {
            this.name = name;
            this.birthDate = birthDate;
            this.gender = gender;
        }   

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public Genders Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public override string ToString()
        {
            return (String.Format("name: {0}, birthDate: {1}, gender: {2}", this.name, this.birthDate, this.gender));
        }
    }
}

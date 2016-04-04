using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee kovacs = new Employee("Geza", DateTime.Now, Person.Genders.Male, 1000, "lehuto");
            kovacs.Room = new Room(111);

            Employee kovacs2 = (Employee)kovacs.Clone();
            kovacs2.Room.Number = 112;

            Console.WriteLine(kovacs.ToString());
            Console.WriteLine(kovacs2.ToString());
            Console.ReadKey();
        }
    }
}

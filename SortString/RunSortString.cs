using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortString
{
    class RunSortString
    {
        static void Main(string[] args)
        {
            string words = "Microsoft.NET Framework 2.0 Application Developement Foundation";
            string[] wordsArray = words.Split(' ');
            Array.Sort(wordsArray);
            words = string.Join(" ", wordsArray);

            Console.Clear();
            Console.WriteLine(words);
            Console.ReadKey();
        }
    }
}

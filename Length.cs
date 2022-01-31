using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountTheSizeOfMyName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name= Console.ReadLine();
            int nameLength = name.Length;
            Console.WriteLine("The name " + name + " contains " + nameLength + " letters.");
        }
    }
}

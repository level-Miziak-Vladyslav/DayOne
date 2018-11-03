using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOne
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.WriteLine("enter the number of basic Elements");
            int a = int.Parse(Console.ReadLine());
            ICustomCollectionItem ie;
            ie = new TheElement();
                for (int i = 0; i < a - 1; i++)
                {
                    Console.WriteLine(ie.Value.ToString());
                    ie = new TheElement(ie);
                    Console.WriteLine(ie.Value.ToString());
                }           
            ICustomCollection s = new Creation();
            Console.WriteLine("enter the Name of new Element");
            string b = Console.ReadLine();
            ICustomCollectionItem add = new TheElement();
            s.Add(add);

            Console.WriteLine();
        }
    }
}

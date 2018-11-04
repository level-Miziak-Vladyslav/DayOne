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
            int keypress;
            try
            {
                Console.WriteLine("enter the number of basic Elements");
                int a = int.Parse(Console.ReadLine());
                ICustomCollection s = new Creation();
                for (int i = 0; i < a - 1; i++)
                {
                    ICustomCollectionItem ie = new TheElement();
                    ie.Value = "object # " + (i + 1).ToString();
                    s.Add(ie);
                }
                Console.WriteLine();

                do
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter task number");
                    Console.WriteLine("1 for enter the Name of new Element");
                    Console.WriteLine("2 for crop the Element");
                    Console.WriteLine("3 for get Element");
                    Console.WriteLine("4 for print all elements");
                    Console.WriteLine();

                    keypress = int.Parse(Console.ReadLine()); // read keystrokes

                    if (keypress == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("enter the Name of new Element");
                        string b = Console.ReadLine();
                        ICustomCollectionItem add = new TheElement();
                        add.Value = b;
                        s.Add(add);
                        Console.WriteLine();
                    }
                    if (keypress == 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine("enter index of Element for crop");
                        int c = int.Parse(Console.ReadLine());
                        Console.WriteLine(s.Crop(c).Value.ToString() + " was cropped");
                        Console.WriteLine();
                    }
                    if (keypress == 3)
                    {
                        Console.WriteLine();
                        Console.WriteLine("enter index of Element for get");
                        int d = int.Parse(Console.ReadLine());
                        Console.WriteLine(s.GetAt(d).Value.ToString() + "  index = " + s.GetAt(d).Index.ToString() + " was getted");
                        Console.WriteLine();
                    }
                    if (keypress == 4)
                    {
                        Console.WriteLine();
                        Console.WriteLine(" print all elements ");
                        s.PrintAllValues();
                        Console.WriteLine();
                    }
                } while (keypress != 0);
            }
            catch (Exception exc)
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка поймана" + exc);
                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OppsConsepts
{
    internal class CopyConstructor
    {
        public int id;
        public string Name;
        public CopyConstructor()
        {
            Console.WriteLine("default Constructor");
        }
        public CopyConstructor(CopyConstructor copyConstructor) 
        {
            Console.WriteLine("Copy Constructor\n");

          this.id = copyConstructor.id;
          this.Name = copyConstructor.Name;
        }
        public static void Main(string[] arg) 
        {
            CopyConstructor copyConstructor = new CopyConstructor();

            CopyConstructor copy = new CopyConstructor(copyConstructor);

            Console.WriteLine("enter id ");
            copy.id = int.Parse(Console.ReadLine());
            Console.WriteLine("enter Name");
            copy.Name=Console.ReadLine();

            Console.WriteLine($"ID>>{copy.id}");
            Console.WriteLine($"Name>>{copy.Name}");

        }

    }
}

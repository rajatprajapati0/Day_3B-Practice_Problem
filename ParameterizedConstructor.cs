using System;
using System.Collections.Generic;
using System.Text;

namespace OppsConsepts
{
    internal class ParameterizedConstructor
    {
      public  int id;
      public  string name;

        public ParameterizedConstructor(int id , string name) 
        {

            Console.WriteLine("Parameterized Constructor\n");
            this.id = id;
            this.name = name;

        }

        public static void Main(string[] args)
        {


            ParameterizedConstructor parameterizedConstructor = new ParameterizedConstructor(1, "Rajat");
            Console.WriteLine($"ID>> {parameterizedConstructor.id}");
            Console.WriteLine($"Name>>{parameterizedConstructor.name}");
        }
    }
}

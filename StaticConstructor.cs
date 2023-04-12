using System;
using System.Collections.Generic;
using System.Text;

namespace OppsConsepts
{
    internal class StaticConstructor
    {
        string id;
        string name;
        static string CompanyId; 
        public StaticConstructor(string id , string name) 
        {
            this.id = id;
            this.name = name;
        }
    
        static StaticConstructor()
        {
            Console.WriteLine("Static Constructor");
            CompanyId = 0101+"";        
        }
        public void data() 
        {
            Console.WriteLine($"ID >>{id}\nName >>{name}\nCompany ID >>{CompanyId}");
        }

        public static void Main(string[] args) 
        {
            StaticConstructor staticConstructor = new StaticConstructor("1","Rajat");
        
            staticConstructor.data();
        }
    }
}

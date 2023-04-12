using System;
using System.Collections.Generic;
using System.Text;

namespace OppsConsepts
{
    internal class PrivateConstructor
    {
        int demo;
        private PrivateConstructor()
        {
         //By private constructor we can not get access of class mamber 
        }
        public static int CandidateVisitedForInterview;
        public static int CountCandidate()
        {
            return ++CandidateVisitedForInterview;
        }
    }
    class Demo 
    {
        public static void Main(string[] args)
        {
            // The following comment line will throw an error because constructor is inaccessible  

           //PrivateConstructor privateConstructor = new PrivateConstructor();
            //privateConstructor.demo = 1;

            PrivateConstructor.CandidateVisitedForInterview = 20;
            PrivateConstructor.CountCandidate();
            Console.WriteLine("Interviewed candidates: {0}", PrivateConstructor.CandidateVisitedForInterview);
            Console.ReadLine();
        }

    }
       
    
    
}

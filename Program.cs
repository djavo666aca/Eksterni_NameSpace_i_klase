using System;
using DrugiNS;

namespace Eksterni_NameSpace_i_klase

{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Main Program");
            Console.WriteLine(Class1.x);
            Console.WriteLine(Class1.NekiString);
            Console.WriteLine(Class1.NekiChar);

            Class2.PrintMetod();

            
        }
    }
}

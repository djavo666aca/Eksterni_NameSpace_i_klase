using Eksterni_NameSpace_i_klase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Eksterni_NameSpace_i_klase
{
    public class Class1
    {
        public static int x = 1;
        public static string NekiString = "Neki string iz eksterne klase";
        public static char NekiChar = 'Z';
    }
}
namespace DrugiNS 
{
public class Class2 
    {
    public static void PrintMetod() 
        {
        Class1 objekat = new Class1();
            Console.WriteLine("#####################");
            Console.WriteLine(Class1.x);
            Console.WriteLine(Class1.NekiChar);
            Console.WriteLine(Class1.NekiString);
        }
    }
}
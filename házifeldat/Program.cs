using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace házifeldat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string szamok="";
            string ki;
            string adatok = "10;7;5";

            foreach (var item in adatok)
            {
                if (item==';')
                {
                    Console.WriteLine($"{szamok}*2 = {Convert.ToInt32(szamok)*2}");
                    szamok = "";
                }
                else
                {
                    szamok = szamok + item;
                }
            }
            Console.WriteLine($"{szamok}*2 = {Convert.ToInt32(szamok) * 2}");

            Console.ReadKey();
        
        }

    }
}


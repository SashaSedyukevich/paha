using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kvit();
            Console.ReadKey();
        }


        static void Kvit()
        {
            Kvit kvit = new Kvit();
            kvit.SetInfo();
            kvit.GetInfo();
            Console.WriteLine();


        }
    }



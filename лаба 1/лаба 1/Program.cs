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
    class Kvit
    {
        public int Number { get; set; }
        public string Data { get; set; }
        public float Sum { get; set; }

        public Kvit(int number, string data, float sum)
        {
            Number = number;
            Data = data;
            Sum = sum;
        }

        public Kvit()
        {
            Number = 0;
            Data = "";
            Sum = 0;
        }
    }
}
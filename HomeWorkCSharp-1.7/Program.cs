using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCSharp_1._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.7. Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.
            Random rnd = new Random();
            int valueOne = rnd.Next();
            int valueTwo = rnd.Next();
            int valueThree = rnd.Next();
            Console.WriteLine(valueOne + " " + valueTwo + " " + valueThree);
        }
    }
}

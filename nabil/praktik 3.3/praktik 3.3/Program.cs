using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perkalian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== operasi matematika di C# ===");
            // input angka pertama dan kedua 
            Console.WriteLine("masukan angka pertama:");
            int angka1 = int.Parse(Console.ReadLine());

            Console.WriteLine("masukan angka kedua:");
            int angka2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n--- hasil operasi perkalian ---");
            Console.WriteLine($"{angka1} * {angka2} = {angka1 * angka2}");
        }
    }
}

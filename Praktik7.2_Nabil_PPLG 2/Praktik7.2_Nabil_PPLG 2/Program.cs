using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik7._2_Danu_Tri_PPLG_2
{
    internal class Program
    {
        static void Sapanama(string nama)
        {
            Console.WriteLine("Halo, " + nama + " ! ");
            Console.WriteLine("Semangat belajar C# hari ini ! ");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Masukan nama anda: ");
            string namaSiswa = Console.ReadLine();
            Sapanama(namaSiswa); // memanggil fungsi dengan argumen
        }
    }
}

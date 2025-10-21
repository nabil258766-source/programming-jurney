using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dimas_gabut_6._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pilihan;

            do
            {
                //tampilkan menu 
                Console.WriteLine("\n=== menu aplikasi");
                Console.WriteLine("1. lihat data");
                Console.WriteLine("2. tambah data");
                Console.WriteLine("3. keluar");
                Console.WriteLine("masukan pilihan anda (1-3):");

                // baca inout pengguna 
                if (!int.TryParse(Console.ReadLine(), out pilihan))
                {
                    Console.WriteLine("pilihan tidak valid, harap masukan angka 1, 2, atau 3.");
                    // tetapkan nilai selain 3 agar loop berlanjut 
                    pilihan = 0;
                    continue;
                }

                // proses pilihan 
                switch (pilihan)
                {
                    case 1:
                        Console.WriteLine("anda memilih : lihat data.");
                        break;
                    case 2:
                        Console.WriteLine("anda memilih : tambah data.);
                    break;
                    case 3:
                        Console.WriteLine("program akan berhenti...:");
                        break;
                    default:
                        Console.WriteLine("pilihan diluar jangkauan. harap masukan 1, 2, atau 3.");
                        break;

                }

                // kondisi loop : lanjutkan selama pilihan bukan 3.
            






            }
        }
    }
}

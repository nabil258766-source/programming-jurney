using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator_Danu_Tri_X_PPLG_2
{
    internal class Program
    {
        // method main adalah titik awal eksekusi program 
        static void Main(string[] args)
        {
            string hitungLagi; // Variabel untuk menyimpan pilihan pengguna (y/n)

            // Perulangan do-while akan menjalankan blok kode setidaknya satu kali
            // dan akan terus berjalan selama kondisi while terpenuhi.
            do
            {
                Console.Clear(); // membersihkan layar konsol untuk setiap perhitungan baru 
                Console.WriteLine("--- KALKULATOR SEDERHANA ---");

                // Memanggil fungsi untuk menampilkan menu
                TampilkanMenu();

                Console.Write("masukkan pilihan operasi (1-4):");
                string pilihan = Console.ReadLine();

                // variabel untuk menampung angka dan hasil
                double angka1, angka2, hasil = 0;

                // memanggil fungsi untuk mendapatkan input angka dari user
                // dan memastikan input adalah angka yang valid
                if (AmbilInputAngka(out angka1, out angka2))
                {
                    // Struktur pemilihan switch-case untuk menentukan operasi
                    switch (pilihan)
                    {
                        case "1": // Pemjumlahan
                            hasil = tambah(angka1, angka2);
                            Console.WriteLine($"\nHasil: {angka1} + {angka2} = {hasil}");
                            break;
                        case "2": // Pengurangan
                            hasil = Kurang(angka1, angka2);
                            Console.WriteLine($"\n: {angka1} - {angka2} = {hasil}");
                            break;
                        case "3": // Perkalian
                            hasil = Kali(angka1, angka2);
                            Console.WriteLine($"\n: {angka1} * {angka2} = {hasil}");
                            break;
                        case "4": // Pembagian
                                  // Penanganan khusus untuk pembagian dengan nol
                            if (angka2 == 0)
                            {
                                Console.WriteLine("\nError: Tidak dapat melakukan pembagian dengan nol.");
                            }
                            else
                            {
                                hasil = Bagi(angka1, angka2);
                                Console.WriteLine($"\nHasil: {angka1} / {angka2} = {hasil}");
                            }
                            break;
                        default: // Jika pilihan tidak ada di case 1-4
                            Console.WriteLine("\nPilihan yang Anda masukkan tidak valid.");
                            break;
                    }
                }
                // menanyakan kepada pengguna apakah ingin menghitung lagi 
                Console.Write("\nApakah anda ingin menghitung kembali? (y/n): ");
                hitungLagi = Console.ReadLine();
                // . Tolower () membuat input jadi huruf kecil, jadi 'Y' atau 'y' akan sama

            } while (hitungLagi.ToLower() == "y");
            // pesan penutup jika pengguna memilih untuk keluar 
            Console.WriteLine("\nTerima kasih telah menggunakan kalkulator ini. " +
                             "Tekan tombol apa saja untuk keluar.");
            Console.ReadKey();
        }
        // --- FUNGSI-FUNGSI BANTUAN ---

        // Fungsi unntuk menampilkan menu pilihan
        static void TampilkanMenu()
        {
            Console.WriteLine("Pilihlah operasi metematika:");
            Console.WriteLine("1. Penjumlahan");
            Console.WriteLine("2. penguranga");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");
        }

        // Fungsi untuk mengambil input angka dari pengguna
        // Munggunakan 'out' karena fungsi ini mengambalikan lebih dari satu nilai
        static bool AmbilInputAngka(out double angka, out double angka2)
        {
            Console.Write("Masukkan angka pertama: ");
            // double.TryParse akan mencoba mengkonversi string ke double.
            // Jika berhasil, return true dan nilainya disimpan di variabel 'angka1'.
            // Jika gagal, return false
            if (!double.TryParse(Console.ReadLine(), out angka))
            {
                Console.WriteLine("Input untuk angka pertama tidak valid.");
                angka2 = 0;
                return false;
            }

            Console.Write("Masukkan angka kedua: ");
            if (!double.TryParse(Console.ReadLine(), out angka2))
            {
                Console.WriteLine("Input untuk angka kedua tidak vaalid.");
                angka2 = 0; // Beri nilai default agar tidak error
                return false;
            }

            return true; // Jika kedua input valid
        }

        // Fungsi untuk operasi penjumlahan

        static double tambah(double a, double b)
        {
            return a + b;
        }
        static double Kurang(double a, double b)
        {
            return a - b;
        }
        // fungsi Untuk operasi perkalian
        static double Kali(double a, double b)
        {
            return a * b;
        }
        // Fungsi untuk operasi pembagian
        static double Bagi(double a, double b)
        {
            return a / b;
        }
    }


}
    


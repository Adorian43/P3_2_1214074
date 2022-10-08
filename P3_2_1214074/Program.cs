using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P3_2_1214074
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                bool mulai = true;
                while (mulai)
                {
                    Console.WriteLine("MENU PERSEGI PANJANG\n");
                    Console.WriteLine("1. Hitung Luas");
                    Console.WriteLine("2. Hitung Keliling\n");

                    Console.Write("Menu Pilihan : ");
                    var pilihan = Console.ReadLine();

                    switch (pilihan)
                    {
                        case "1":

                            Console.WriteLine("\nMENGHITUNG LUAS PERSEGI PANJANG");
                            Console.Write("Masukan Panjang : ");
                            double panjang = double.Parse(Console.ReadLine());
                            Console.Write("Masukan Lebar : "); 
                            double lebar = double.Parse(Console.ReadLine());
                            double luas = (panjang * lebar);
                            Console.WriteLine("Luas Persegi Panjang = " + luas + "\n");
                            break;

                        case "2":
                            Console.WriteLine("\nMENGHITUNG KELILING PERSEGI PANJANG");
                            Console.Write("Masukan Panjang : ");
                            double panjang1 = double.Parse(Console.ReadLine());
                            Console.Write("Masukan Lebar : ");
                            double lebar1 = double.Parse(Console.ReadLine());
                            double keliling = (panjang1 * 2) + (lebar1 * 2);
                            Console.WriteLine("Keliling Persegi Panjang = " + keliling + "\n");
                            break;
                            
                    }
                    Console.Write("Ingin mengulang Kembali (Y/T)?");
                    var kondisi = Console.ReadLine();
                    if (kondisi == "T")
                    {
                        Console.WriteLine("\nProgram akan Berakhir\n");
                        mulai = false;
                        Console.Clear();
                    }
                    else if (kondisi == "t")
                    {
                        Console.WriteLine("\nProgram akan Berakhir\n");
                        mulai = false;
                        Console.Clear();
                    }
                   else if (kondisi == "Y")
                    {
                        Console.Clear();
                        mulai = true;
                    }
                    else if (kondisi == "y")
                    {
                        Console.Clear();
                        mulai = true;
                    }
                    else 
                    {
                        Console.Clear();
                        Console.WriteLine("\nSilhakan ulangi kembali\n");
                        mulai = false;
                    }
                } 
            }
        }
    }
}

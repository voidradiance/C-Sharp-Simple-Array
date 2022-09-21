using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgungSetiawan_Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] daftarKota = new string[5]
                {
                "Gotham", "Metropolis", "Sin City", "Pewter City", "Starling City"
                };

            int[,] jarakAntarKota = new int[5, 5];
            jarakAntarKota[0, 0] = 0;
            jarakAntarKota[0, 1] = 2400;
            jarakAntarKota[0, 2] = 3506;
            jarakAntarKota[0, 3] = 2178;
            jarakAntarKota[0, 4] = 5670;
            jarakAntarKota[1, 0] = 2400;
            jarakAntarKota[1, 1] = 0;
            jarakAntarKota[1, 2] = 4500;
            jarakAntarKota[1, 3] = 5666;
            jarakAntarKota[1, 4] = 3700;
            jarakAntarKota[2, 0] = 3506;
            jarakAntarKota[2, 1] = 4500;
            jarakAntarKota[2, 2] = 0;
            jarakAntarKota[2, 3] = 6788;
            jarakAntarKota[2, 4] = 8775;
            jarakAntarKota[3, 0] = 2178;
            jarakAntarKota[3, 1] = 5666;
            jarakAntarKota[3, 2] = 6788;
            jarakAntarKota[3, 3] = 0;
            jarakAntarKota[3, 4] = 1300;
            jarakAntarKota[4, 0] = 5670;
            jarakAntarKota[4, 1] = 3700;
            jarakAntarKota[4, 2] = 8775;
            jarakAntarKota[4, 3] = 1300;
            jarakAntarKota[4, 4] = 0;

            List<string> listString = new List<string>();
            Boolean looping = true;
            while (looping)
            {
                Console.Clear();
                Console.WriteLine("Pilih kota keberangkatan");
                Console.WriteLine("1. Gotham");
                Console.WriteLine("2. Metropolis");
                Console.WriteLine("3. Sin City");
                Console.WriteLine("4. Pewter City");
                Console.WriteLine("5. Starling City");
                int inputAwal = Convert.ToInt32(Console.ReadLine());

                if (!inputAwal.Equals(1) && !inputAwal.Equals(2) && !inputAwal.Equals(3) && !inputAwal.Equals(4) && !inputAwal.Equals(5))
                {
                    Console.Clear();
                    Console.WriteLine("Pilihan kota harus 1-5, silahkan masukan kembali\n");
                    continue;
                }
                else
                {
                    if (inputAwal == 1)
                    {
                        inputAwal = 0;
                    }
                    else if (inputAwal == 2)
                    {
                        inputAwal = 1;
                    }
                    else if (inputAwal == 3)
                    {
                        inputAwal = 2;
                    }
                    else if (inputAwal == 4)
                    {
                        inputAwal = 3;
                    }
                    else
                    {
                        inputAwal = 4;
                    }

                    Console.Clear();
                    Console.WriteLine("Pilih kota tujuan");
                    Console.WriteLine("1. Gotham");
                    Console.WriteLine("2. Metropolis");
                    Console.WriteLine("3. Sin City");
                    Console.WriteLine("4. Pewter City");
                    Console.WriteLine("5. Starling City");
                    int inputAkhir = Convert.ToInt32(Console.ReadLine());

                    if (!inputAkhir.Equals(1) && !inputAkhir.Equals(2) && !inputAkhir.Equals(3) && !inputAkhir.Equals(4) && !inputAkhir.Equals(5))
                    {
                        Console.Clear();
                        Console.WriteLine("Pilihan kota harus 1-5, silahkan masukan kembali\n");
                        continue;
                    }
                    else
                    {

                        if (inputAkhir == 1)
                        {
                            inputAkhir = 0;
                        }
                        else if (inputAkhir == 2)
                        {
                            inputAkhir = 1;
                        }
                        else if (inputAkhir == 3)
                        {
                            inputAkhir = 2;
                        }
                        else if (inputAkhir == 4)
                        {
                            inputAkhir = 3;
                        }
                        else
                        {
                            inputAkhir = 4;
                        }

                        Console.WriteLine("Jarak dari {0} sampai {1} adalah {2}\n", daftarKota[inputAwal], daftarKota[inputAkhir], jarakAntarKota[inputAwal,inputAkhir]);

                        Console.WriteLine("lanjutkan input atau keluarkan list semua output? (lanjut/list) :");
                        string input = Console.ReadLine().Trim();

                        while (!input.ToLower().Equals("lanjut") && !input.ToLower().Equals("list"))
                        {
                            Console.Write("hanya menerima (lanjut) atau (list) :");
                            input = Console.ReadLine().Trim();
                        }

                        if (input.ToLower().Equals("lanjut"))
                        {
                            string list = $"Jarak dari {daftarKota[inputAwal]} sampai {daftarKota[inputAkhir]} adalah {jarakAntarKota[inputAwal, inputAkhir]}";
                            listString.Add(list);
                            looping = true;
                        }
                        else
                        {
                            string list = $"Jarak dari {daftarKota[inputAwal]} sampai {daftarKota[inputAkhir]} adalah {jarakAntarKota[inputAwal, inputAkhir]}";
                            listString.Add(list);
                            looping = false;
                        }
                        Console.Clear();
                        foreach (string item in listString)
                        {
                            Console.WriteLine(item);
                        }

                    }
                }
            }
        }
    }
}

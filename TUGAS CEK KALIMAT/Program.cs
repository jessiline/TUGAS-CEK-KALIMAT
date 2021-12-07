using System;
using System.Collections.Generic;
using System.Linq;
namespace TUGAS_CEK_KALIMAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Kalimat : ".ToUpper());
            string kalimat = Console.ReadLine();
            string[] arrayKalimat = kalimat.Split(" ");
            while (arrayKalimat.Length <= 3)
            {
                Console.WriteLine("kata pada kalimat kurang panjang".ToUpper());
                Console.Write("Input Kalimat : ".ToUpper());
                kalimat = (Console.ReadLine()).ToUpper();
                arrayKalimat = kalimat.Split(" ");
            }
            char[] characters = kalimat.ToCharArray();
            var cobaList = new List<char>();
            Array.Sort(characters);
            Console.Write("Input Kata : ".ToUpper());
            string kata = Console.ReadLine();
            while (kata.Length <= 1)
            {
                Console.WriteLine("huruf pada kata kurang panjang".ToUpper());
                Console.Write("Input Kata : ");
                kata = Console.ReadLine();

            }
            Console.WriteLine("statistik huruf:".ToUpper());
            int spasi = 0;
            int jumlahHuruf = 0;
            foreach (var test in characters)
            {
                int huruf = 0;
                Array.Sort(characters);
                cobaList.Add(test);
                for (int j = 0; j < cobaList.Count; j++)
                {
                    if (test == cobaList[j])
                    {
                        huruf += 1;
                    }
                }
                if(huruf == 1 && test != ' ')
                {
                    char alph = test;
                    int hitung = characters.Count(a => (a == alph));
                    Console.WriteLine($"{test}: {hitung} huruf".ToUpper());
                    spasi++;
                    if (spasi % 5 == 0)
                    {
                        Console.WriteLine();
                    }
                }
                if(test != ' ')
                {
                    jumlahHuruf++;
                }
                
            }

            int berapaKata = 0;
            for(int k = 0; k < arrayKalimat.Length; k++)
            {
                if(arrayKalimat[k].Contains(kata) == true)
                {
                    berapaKata++;
                }
            }
            var hapus =kalimat.Remove(' ');
            Console.WriteLine($"statistik kata:\n{kata}: {berapaKata} kata\n".ToUpper());
            Console.WriteLine($"jumlah huruf: {jumlahHuruf} huruf".ToUpper());
        }
    }
}

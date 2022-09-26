using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_2_1214066
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Aplikasi Penghitung gaji ===");
            Console.Write("Silahkan masukkan gaji anda: ");
            var gaji = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            var pers_tunjangan = (float)(20.0 / 100.0);
            var pers_bonus = (float)(15.0 / 100.0);
            var pers_pph = (float)(3.5/100);

            var pers_tunjangan2 = (pers_tunjangan) * 100 + "%";
            var pers_bonus2 = (pers_bonus) * 100 + "%";
            var pers_pph2 = (pers_pph) * 100 + "%";

            var tunjangan = gaji * pers_tunjangan;
            var bonus = gaji * pers_bonus;
            var pph = gaji * pers_pph;

            string tambah = (" + ");
            string kali = (" * ");
            String kurang = (" - ");

            var total_gaji = gaji + tunjangan + bonus;
            var gaji_bersih = total_gaji - pph;

            Console.Write("Kalkulasi tunjangan: ");
            Console.WriteLine(gaji + kali + pers_tunjangan2);
            Console.WriteLine("Total tunjangan Anda senilai: Rp " + tunjangan + ",-");
            Console.WriteLine(" ");

            Console.Write("Kalkulasi Bonus: ");
            Console.WriteLine(gaji + kali + pers_bonus2);
            Console.WriteLine("Bonus Anda senilai: Rp " + bonus + ",-");
            Console.WriteLine(" ");

            Console.Write("Kalkulasi PPH: ");
            Console.WriteLine(gaji + kali + pers_pph2);
            Console.WriteLine("PPH Anda senilai: Rp " + pph + ",-");
            Console.WriteLine(" ");

            Console.Write("Kalkulasi total gaji: ");
            Console.WriteLine(gaji + tambah + tunjangan + tambah + bonus);
            Console.WriteLine("Total gaji kotor Anda senilai: Rp " + total_gaji + ",-");
            Console.WriteLine(" ");

            Console.Write("Kalkulasi gaji bersih: ");
            Console.WriteLine(gaji + kurang + pph);
            Console.WriteLine("Total gaji bersih Anda senilai: Rp " + gaji_bersih + ",-");
            Console.WriteLine(" ");
        }
    }
}

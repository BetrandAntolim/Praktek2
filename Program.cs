using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa saya = new Mahasiswa();
            Mahasiswa kamu = new Mahasiswa();


            saya.Nim = "18.11.2299";
            saya.Nama = "Betrand Antolim";
            saya.Ipk = 3.33f;

            kamu.Nim = "18.11.XXXX";
            kamu.Nama = "XXXXXXXX";
            kamu.Ipk = 4.00f;

            saya.Regristrasi();
            saya.IsiKrs();

            kamu.Regristrasi();
            kamu.IsiKrs();

            Console.ReadKey();

        }
    }
}

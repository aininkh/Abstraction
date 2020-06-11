using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction2595.Interface
{
    public class Polisi : IProfesi, IDivisi
    {
        public void Tugas()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Tugas Polisi : ");
            Console.WriteLine("---------------");
            Console.WriteLine("[1] Menangani masalah yang ada disekitar masyarakat");
            Console.WriteLine("[2] Menangkap penjahat, pengedar narkoba");
            Console.WriteLine("[3] Menjaga ketertiban");
            Console.WriteLine();
        }

        public void Bidang()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Bidang Divisi di Kepolisian : ");
            Console.WriteLine("------------------------------");
            Console.WriteLine("[1] Divisi Hukum");
            Console.WriteLine("[2] Divisi Hubungan Masyarakat");
            Console.WriteLine("[3] Divisi Hubungan Internasional");
            Console.WriteLine("[4] Divisi Teknologi Informasi Kepolisian");
            Console.WriteLine("========================================================================================================================");
        }
    }
}

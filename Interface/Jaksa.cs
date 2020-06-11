using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction2595.Interface
{
    public class Jaksa : IProfesi, IDivisi
    {
        public void Tugas()
        {
            Console.WriteLine("--------------");
            Console.WriteLine("Tugas Jaksa : ");
            Console.WriteLine("--------------");
            Console.WriteLine("[1] Melakukan penuntutan");
            Console.WriteLine("[2] Melaksanakan penetapan hakim dan putusan pengadilan yang telah memperoleh kekuatan hukum tetap");
            Console.WriteLine("[3] Melakukan pengawasan terhadap pelaksanaan putusan pidana bersyarat, putusan pidana pengawasan dan keputusan bersyarat");
            Console.WriteLine();
        }

        public void Bidang()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Bidang Divisi di Kejaksaan : ");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("[1] Bidang Intelijen");
            Console.WriteLine("[2] Bidang Pembinaan");
            Console.WriteLine("[3] Bidang Tindak Pidana Umum");
            Console.WriteLine("[4] Bidang Perdata");
            Console.WriteLine("[5] Bidang Pengawasan");
            Console.WriteLine("========================================================================================================================");
        }
    }
}

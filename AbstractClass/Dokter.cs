using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction2595.AbstractClass
{
    public class Dokter : Profesi
    {
        public override void Tugas()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Tugas Dokter : ");
            Console.WriteLine("---------------");
            Console.WriteLine("[1] Membantu pasien sembuh dari penyakitnya");
            Console.WriteLine("[2] Tempat konsultasi");
            Console.WriteLine("[3] Mendiagnosis sebuah penyakit");
            Console.WriteLine("========================================================================================================================");
        }
    }
}

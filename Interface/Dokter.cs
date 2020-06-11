using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction2595.Interface
{
    public class Dokter : IProfesi, IDivisi
    {
        public void Tugas()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Tugas Dokter : ");
            Console.WriteLine("---------------");
            Console.WriteLine("[1] Membantu pasien sembuh dari penyakitnya");
            Console.WriteLine("[2] Tempat konsultasi");
            Console.WriteLine("[3] Mendiagnosis sebuah penyakit");
            Console.WriteLine();
        }

        public void Bidang()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Bidang Spesialis di Kedokteran : ");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("[1] Spesialis Jantung dan Pembuluh Darah");
            Console.WriteLine("[2] Spesialis Bedah Toraks Kardiovaskular");
            Console.WriteLine("[3] Spesialis Bedah Orthopaedi dan Traumatologi");
            Console.WriteLine("[4] Spesialis Kedokteran Forensik & Medikolegal");
            Console.WriteLine("[5] Spesialis Obstetri & Ginekologi");
            Console.WriteLine("========================================================================================================================");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction2595.AbstractClass
{
    public class Polisi : Profesi
    {
        public override void Tugas()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Tugas Polisi : ");
            Console.WriteLine("---------------");
            Console.WriteLine("[1] Menangani masalah yang ada disekitar masyarakat");
            Console.WriteLine("[2] Menangkap penjahat, pengedar narkoba");
            Console.WriteLine("[3] Menjaga ketertiban");
            Console.WriteLine("========================================================================================================================");
        }
    }
}

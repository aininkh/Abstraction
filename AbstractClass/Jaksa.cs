using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction2595.AbstractClass
{
    public class Jaksa : Profesi
    {
        public override void Tugas()
        {
            Console.WriteLine("--------------");
            Console.WriteLine("Tugas Jaksa : ");
            Console.WriteLine("--------------");
            Console.WriteLine("[1] Melakukan penuntutan");
            Console.WriteLine("[2] Melaksanakan penetapan hakim dan putusan pengadilan yang telah memperoleh kekuatan hukum tetap");
            Console.WriteLine("[3] Melakukan pengawasan terhadap pelaksanaan putusan pidana bersyarat, putusan pidana pengawasan dan keputusan bersyarat");
            Console.WriteLine("========================================================================================================================");
        }
    }
}

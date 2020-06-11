using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Abstraction2595.AbstractClass;
using Abstraction2595.Interface;

namespace Abstraction2595
{
    class Program
    {
        static void Main(string[] args)
        {
            //menggunakan Abstract Class
            Profesi profesi;
            profesi = new Dokter();
            profesi.Tugas();

            Console.WriteLine();
            profesi = new Jaksa();
            profesi.Tugas();

            Console.WriteLine();
            profesi = new Polisi();
            profesi.Tugas();
            

            // menggunakan Interface
            IProfesi profesi;
            IDivisi divisi;

            profesi = new Dokter();
            profesi.Tugas();
            divisi = new Dokter();
            divisi.Bidang();

            Console.WriteLine();
            profesi = new Jaksa();
            profesi.Tugas();
            divisi = new Jaksa();
            divisi.Bidang();

            Console.WriteLine();
            profesi = new Polisi();
            profesi.Tugas();
            divisi = new Polisi();
            divisi.Bidang();
            
            Console.ReadKey();
        }
    }
}

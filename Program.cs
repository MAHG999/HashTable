using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace ColeccionHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable TblaHacheada = new Hashtable();

            TblaHacheada.Add(111, "Hola");
            TblaHacheada.Add(222, "Saludos");
            TblaHacheada.Add(333, "Adios");
            TblaHacheada.Add(444, "C#");
            TblaHacheada.Add(555, "Programacion");

            foreach (DictionaryEntry item in TblaHacheada)
            {
                Console.WriteLine("({0},{1})", item.Key,item.Value);
            }
            Console.ReadKey();
        }
    }
}

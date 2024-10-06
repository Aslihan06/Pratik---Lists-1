using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Ziyaretçilerin isimlerini içeren liste
        List<string> davetliler = new List<string>()
        {
            "Bülent Ersoy",
            "Ajda Pekkan",
            "Ebru Gündeş",
            "Hadise",
            "Hande Yener",
            "Tarkan",
            "Funda Arar",
            "Demet Akalın"
        };

        // İsimleri tek tek ekrana yazdırmak için foreach döngüsü
        foreach (string davetli in davetliler)
        {
            Console.WriteLine(davetli);
        }
    }
}


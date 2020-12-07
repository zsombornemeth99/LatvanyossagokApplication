using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatvanyossagokApplication
{
    class Latvanyossag
    {
        public int Id { get; set; }
        public string Nev { get; set; }
        public string Leiras { get; set; }
        public int Ar { get; set; }
        public int VarosId { get; set; }

        public override string ToString()
        {
            return Ar== 0?$"{Nev} - Ingyenes":$"{Nev} - {Ar} Ft";
        }
    }
}

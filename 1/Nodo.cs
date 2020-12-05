using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Nodo
    {
        public string Nombre { get; set; }

        public string Sexo { get; set; }
        public Nodo Siguiente { get; set; }
        public override string ToString()
        {
            return ($"{Nombre}");
        }
    }
}

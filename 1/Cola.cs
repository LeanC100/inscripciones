using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Cola
    {
        Nodo _inicio;
        public void AddCola(Nodo nodo)
        {
            if (_inicio == null)
            {
                _inicio = nodo;
            }
            else
            {
                Nodo aux = BuscarUltimo(_inicio);
                aux.Siguiente = nodo;
            }
        }

        public Nodo BuscarUltimo(Nodo nodo)
        {
            if (nodo.Siguiente == null)
            {
                return nodo;
            }
            else
            {
                return BuscarUltimo(nodo.Siguiente);
            }
        }
        public Nodo Inicio
        {
            get
            {
                return _inicio;
            }
        }
    }
}

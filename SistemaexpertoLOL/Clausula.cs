using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaexpertoLOL
{
    public class Clausula
    {
        public string Atributo { get; }
        public string Valor { get; }

        public Clausula(string atributo, string valor)
        {
            Atributo = atributo;
            Valor = valor;
        }
    }

}

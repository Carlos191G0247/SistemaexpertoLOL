using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaexpertoLOL
{
    internal class Regla
    {
        public List<Clausula> Clausulas { get; }
        public string CampeonRecomendado { get; }

        public Regla(List<Clausula> clausulas, string campeonRecomendado)
        {
            Clausulas = clausulas;
            CampeonRecomendado = campeonRecomendado;
        }

        public bool Evaluar(string rolUsuario, string estiloUsuario)
        {
            foreach (var clausula in Clausulas)
            {
                if (clausula.Atributo == "rol" && clausula.Valor != rolUsuario)
                {
                    return false;
                }
                else if (clausula.Atributo == "estilo" && clausula.Valor != estiloUsuario)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

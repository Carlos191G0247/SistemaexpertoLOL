using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaexpertoLOL
{
    internal class MotorSistemaExperto
    {
        private List<Campeon> campeones;
        private List<Regla> reglas;

        public MotorSistemaExperto()
        {
            InicializarCampeones();
            InicializarReglas();
        }

        private void InicializarCampeones()
        {
            campeones = new List<Campeon>
        {
                // Top
                new Campeon("Darius"),
                new Campeon("Maokai"),
                new Campeon("Gnar"),


                // Jungla
                new Campeon("Lee Sin"),
                new Campeon("Amumu"),
                new Campeon("Elise"),

                // Mid
                new Campeon("Ahri"),
                new Campeon("Zed"),
                new Campeon("Orianna"),

                // ADC
                new Campeon("Jinx"),
                new Campeon("Ashe"),
                new Campeon("Kai'Sa"),

                // Soporte
                new Campeon("Thresh"),
                new Campeon("Janna"),
                new Campeon("Leona")


            };
        }

        private void InicializarReglas()
        {
            // Inicializar la lista de reglas
            reglas = new List<Regla>
        {

                //TOP
            new Regla(new List<Clausula>
                {
                    new Clausula("rol", "Top"),
                    new Clausula("estilo", "Agresivo")
                }, "Darius"),
            new Regla(new List<Clausula>
                {
                    new Clausula("rol", "Top"),
                    new Clausula("estilo", "Defensivo")
                }, "Maokai"),

            new Regla(new List<Clausula>
                {
                    new Clausula("rol", "Top"),
                    new Clausula("estilo", "Equilibrados")
                }, "Maokai"),

            //Jungla
            new Regla(new List<Clausula>
                {
                    new Clausula("rol", "Jg"),
                    new Clausula("estilo", "Agresivo")
                }, "Lee Sin"),
            new Regla(new List<Clausula>
                {
                    new Clausula("rol", "Jg"),
                    new Clausula("estilo", "Defensivo")
                }, "Amumu"),

            new Regla(new List<Clausula>
                {
                    new Clausula("rol", "Jg"),
                    new Clausula("estilo", "Equilibrados")
                }, "Elise"),

            //Mid
            new Regla(new List<Clausula>
                {
                    new Clausula("rol", "Mid"),
                    new Clausula("estilo", "Agresivo")
                }, "Ahri"),
            new Regla(new List<Clausula>
                {
                    new Clausula("rol", "Mid"),
                    new Clausula("estilo", "Defensivo")
                }, "Zed"),

            new Regla(new List<Clausula>
                {
                    new Clausula("rol", "Mid"),
                    new Clausula("estilo", "Equilibrados")
                }, "Orianna"),

            //Adc
            new Regla(new List<Clausula>
                {
                    new Clausula("rol", "Adc"),
                    new Clausula("estilo", "Agresivo")
                }, "Jinx"),
            new Regla(new List<Clausula>
                {
                    new Clausula("rol", "Adc"),
                    new Clausula("estilo", "Defensivo")
                }, "Ashe"),

            new Regla(new List<Clausula>
                {
                    new Clausula("rol", "Adc"),
                    new Clausula("estilo", "Equilibrados")
                }, "Kai'Sa"),

            //Sup
            new Regla(new List<Clausula>
                {
                    new Clausula("rol", "Sup"),
                    new Clausula("estilo", "Agresivo")
                }, "Thresh"),
            new Regla(new List<Clausula>
                {
                    new Clausula("rol", "Sup"),
                    new Clausula("estilo", "Defensivo")
                }, "Leona"),

            new Regla(new List<Clausula>
                {
                    new Clausula("rol", "Sup"),
                    new Clausula("estilo", "Equilibrados")
                }, "Kai'Sa"),


           

        };
        }

        public string ObtenerCampeonRecomendado(string rolUsuario, string estiloUsuario)
        {
            foreach (var regla in reglas)
            {
                if (regla.Evaluar(rolUsuario, estiloUsuario))
                {
                    return regla.CampeonRecomendado;
                }
            }

            Console.WriteLine($"DEBUG: No se encontró coincidencia para rol={rolUsuario}, estilo={estiloUsuario}");
            return "No se encontró una recomendación para esa combinación de rol y estilo.";
        }

        public List<Campeon> ObtenerTodosLosCampeones()
        {
            return campeones;
        }

    }
}

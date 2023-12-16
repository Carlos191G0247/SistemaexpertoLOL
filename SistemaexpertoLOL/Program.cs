using SistemaexpertoLOL;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenido al sistema experto para selección de campeones en League of Legends");

        var motor = new MotorSistemaExperto();

        while (true)
        {
            Console.Write("Ingrese su rol preferido (Top, Jg, Mid, Adc, Sup): ");
            string rolPreferido = Console.ReadLine();

            Console.Write("¿Prefiere campeones Agresivo, Defensivo o Equilibrados? ");
            string estiloPreferido = Console.ReadLine();

            string campeonRecomendado = motor.ObtenerCampeonRecomendado(rolPreferido, estiloPreferido);

            Console.WriteLine($"Se recomienda seleccionar a {campeonRecomendado} para el rol de {rolPreferido}.");

            Console.Write("¿Desea realizar otra solicitud? (s/n): ");
            string respuesta = Console.ReadLine();

            if (respuesta.ToLower() != "s")
            {
                break;
            }
        }

        Console.WriteLine("Gracias por usar el sistema experto. Presiona cualquier tecla para salir...");
        Console.ReadKey();
    }
}

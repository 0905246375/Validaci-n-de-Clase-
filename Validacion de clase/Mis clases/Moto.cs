using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validacion_de_clase.Mis_clases
{
    internal class Moto
    {
        public Moto(int v1, string v2, string v3) : base(v1, v2, v3)
        {
        }

        public Moto(string marca, string modelo, int año, Chofer chofer)
            : base(marca, modelo, año, 100, chofer) // Velocidad máxima de una moto es 100 km/h
        {
            CapacidadTanque = 15; // Capacidad del tanque de una moto en galones
            ConsumoCombustible = 1; // Consumo de combustible de una moto en galones/km
            tipoLicenciaAceptados = new List<string> { "A", "M" };
        }

        public void HacerCaballito()
        {
            if (VelocidadActual > 0)
            {
                Console.WriteLine("Haciendo caballito...");
            }
            else
            {
                Console.WriteLine("No se puede hacer caballito con la moto detenida.");
            }
        }
    }
}

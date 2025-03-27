using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validacion_de_clase.Mis_clases.Interfase;

namespace Validacion_de_clase.Mis_clases
{
    internal class Chofer
    {
        private string v1;
        private int v2;

        public object? TipodeLicencia { get; private set; }
        public object? Nombre { get; private set; }
        public int Edad { get; }
        string IPiloto.Nombre { get; set; }
        int IPiloto.Edad { get; set; }
        string IPiloto.TipoLicencia { get; set; }

        public enum TipoLicencia

        {
            A, // Motocicletas
            B, // Vehículos livianos
            C, // Vehículos pesados
            M, // Motocicletas
            T  // Transporte colectivo
        }

        private TipoLicencia DeterminarLicencia(int edad)
        {
            if (edad >= 21)
            {
                return TipoLicencia.C;
            }
            else if (edad >= 18)
            {
                return TipoLicencia.B;
            }
            else if (edad >= 17)
            {
                return TipoLicencia.A;
            }
            else if (edad >= 16)
            {
                return TipoLicencia.M;
            }
            else if (edad >= 25)
            {
                return TipoLicencia.T;
            }
            else
            {
                throw new ArgumentException("Edad no corresponde con ningún tipo de licencia.");
            }
        }

        public Chofer(string name, int LaEdad, string Licencia)
        {
            Nombre = name;
            Edad = LaEdad;
            TipodeLicencia = Licencia;

        }

        public Chofer(string v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        void IPiloto.mostrarInformacion()
        {
            Console.WriteLine("El piloto es: {0}", Nombre);
            Console.WriteLine("La licencia es {0}", TipodeLicencia);
        }

        internal void mostrarInformacion()
        {
            throw new NotImplementedException();
        }
    }
}

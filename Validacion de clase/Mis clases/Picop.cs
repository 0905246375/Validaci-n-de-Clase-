using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validacion_de_clase.Mis_clases
{
    internal class Picop
    {
        public int Gasolina { get; set; }
        public int numeroDeLlanta { get; set; }
        public Picop(int anio, string elColor, string elModelo) : base(anio, elColor, elModelo)
        {
            tipoLicenciaAceptados = new List<string> { "C" };
        }

    }
}

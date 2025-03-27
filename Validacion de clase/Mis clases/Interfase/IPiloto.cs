using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validacion_de_clase.Mis_clases.Interfase
{
    internal interface IPiloto
    {
        string Nombre { get; set; }
        int Edad { get; set; }
        string TipoLicencia { get; set; } // a,b, c, m

        void mostrarInformacion();
    }
}

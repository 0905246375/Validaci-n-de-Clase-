using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace p1bpoo.MisClases
    {

        public class Vehiculo : VehiculoBase
        {
            public string Color { get; set; }
            public string Modelo { get; }
            public int Year { get; }
            public object? VelocidaMaxima { get; private set; }
            public int VehiculoVelocidadActual { get; set; }
            public int VelocidadActual { get; private set; }
            public int Estado { get; private set; }

            private int velocidad = 0;

            protected int CapacidadTanque { get; set; }
            protected int ConsumoCombustible { get; set; }

            protected List<string> tipoLicenciaAceptados = new List<string>("A", "B", "C");
            protected int VelociadaMaxima;

            private Chofer piloto = null;
            private int estadoVehiculo = 0;// 0=apagado, 1=Encendico, 2= eb nivimiento 
            private int anio;
            private string elColor;
            private string elModelo;
            private int v1;
            private string v2;
            private string v3;

            public Vehiculo(int anio, string elColor, string elModelo, int VelocidadMaxima)
            {
                this.Color = elColor;
                this.Modelo = elModelo;
                this.Year = anio;
                this.VelociadaMaxima = VelocidadMaxima;
                this.VelocidadActual = 0;
            }

            public Vehiculo(string v, int anio, string elColor, string elModelo)
            {
                this.anio = anio;
                this.elColor = elColor;
                this.elModelo = elModelo;
            }

            public Vehiculo(string v1, string v2, int v3, int v4, Chofer chofer1)
            {
            }

            public Vehiculo(int v1, string v2, string v3)
            {
                this.v1 = v1;
                this.v2 = v2;
                this.v3 = v3;
            }

            private void ValidarLicenciaParaVelocidad(Chofer chofer, int velocidadMaxima)
            {
                switch (chofer.TipodeLicencia)
                {
                    case TipoLicencia.A:
                    case TipoLicencia.M:
                        if (velocidadMaxima > 100)
                            throw new ArgumentException("La licencia del chofer no permite conducir a más de 100 km/h.");
                        break;
                    case TipoLicencia.B:
                        if (velocidadMaxima > 120)
                            throw new ArgumentException("La licencia del chofer no permite conducir a más de 120 km/h.");
                        break;
                    case TipoLicencia.C:
                        if (velocidadMaxima > 90)
                            throw new ArgumentException("La licencia del chofer no permite conducir a más de 90 km/h.");
                        break;
                    case TipoLicencia.T:
                        if (velocidadMaxima > 80)
                            throw new ArgumentException("La licencia del chofer no permite conducir a más de 80 km/h.");
                        break;
                    default:
                        throw new ArgumentException("Tipo de licencia no válido.");
                }
            }

            public void InformacionVehiculo()
            {
                Console.WriteLine("Color {0}:", this.Color);
                Console.WriteLine("Modelo {0}:", this.Modelo);
                Console.WriteLine("Año {0}", this.Year);
                Console.WriteLine("Velocidad Máxima: {0} km/h", VelocidaMaxima);
                Console.WriteLine("Conductor:");
            }
            public string Encender()
            {
                if (piloto == null)
                {
                    return "No puedes encenderlo ";
                }

                if (estadoVehiculo == 0)
                {
                    estadoVehiculo = 1;
                    return "El vehiculo esta encendido";

                }
                return "ups, ya estaba encendido";
            }
            public void Acelerar(int incremento)
            {
                if (VelocidadActual + incremento = VelocidaMaxima)
                {
                    VelocidadActual += incremento;
                    Console.WriteLine("Acelerando... Velocidad actual: {0} km/h", VelocidadActual);
                }
                else
                {
                    VelocidadActual = (int)VelocidaMaxima;
                    Console.WriteLine("No es posible acelera");
                }
            }

            public void Frenar(int decremento)
            {
                if (VelocidadActual - decremento >= 0)
                {
                    VelocidadActual -= decremento;
                    if (VelocidadActual == 0)
                    {
                        Estado = 1; // El vehículo está encendido
                    }
                    Console.WriteLine("Frenando... Velocidad actual: {0} km/h", VelocidadActual);
                }
                else
                {
                    VelocidadActual = 0;
                    Estado = 1; // El vehículo está encendido
                    Console.WriteLine("El vehículo se ha detenido.");
                }
            }

            public void Apagar()
            {
                if (VelocidadActual == 0)
                {
                    Estado = 0; // El vehículo está apagado
                    Console.WriteLine("El vehículo se ha apagado.");
                }
                else
                {
                    Console.WriteLine("No se puede apagar el vehículo en movimiento.");
                }
            }

            public void MostrarInformacion()
            {
                int estadoVehiculo = Estado switch
                {
                    0 => "Apagado";
                1 => "Encendido";
                2 => "En movimiento",
                    _ => "Desconocido"
                };


                Console.WriteLine("Vehículo: {0} {1} ({2})", Color, Modelo, Year);
                Console.WriteLine("Velocidad Máxima: {0} km/h", VelocidaMaxima);
                Console.WriteLine("Velocidad Actual: {0} km/h", VelocidadActual);
                Console.WriteLine("Estado del Vehículo: {0}", estadoVehiculo);
                Console.WriteLine("Conductor:");

            }
        }
    }


}
}

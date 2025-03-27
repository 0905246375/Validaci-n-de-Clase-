//using p1bpoo.MisClases;

//Vehiculo miCarrito = new Vehiculo(2026,"Azul","Alfa Romeo");

//Vehiculo elOtro = new Vehiculo(2000, "Rojo", "DELOREAN");

//CarroElectrico miBYD = new CarroElectrico(2026, "Amarillo", "BYD");

//miBYD.InformacionVehiculo();
//miBYD.cargarBateria();
//Console.WriteLine("El nivel de bateria es: {0}",miBYD.NivelBateria());

using System.Net.Mail;
using p1bpoo.MisClases;
using Validacion_de_clase.Mis_clases;

Chofer piloto1 = new Chofer("Monica", 25, "A");
Chofer piloto2 = new Chofer("Andrea", 21, "M");

Vehiculo sedan = new Vehiculo(2025, "Azul", "M");

String respuesta;
// seda.encender 
respuesta = sedan.AsignarPiloto(piloto1);
sedan.AsignarPiloto(piloto1);
Console.WriteLine(respuesta);
respuesta = sedan.Encender();
Console.WriteLine(respuesta);

Moto honda = new Moto(2025, "Rojo", "Honda");
Console.WriteLine(honda.AsignarPiloto(piloto2));


Trailer Toyota = new Trailer(2025, "Amarillo ", "Toyota");

Chofer chofer1 = new Chofer("Juan Pérez", 25);
Vehiculo vehiculo1 = new Vehiculo("Toyota", "Corolla", 2022, 120, chofer1);

Chofer chofer2 = new Chofer("Ana López", 19);
Moto moto1 = new Moto("Yamaha", "R1", 2021, chofer2);

vehiculo1.MostrarInformacion();
vehiculo1.Acelerar(50);
vehiculo1.Frenar(30);
vehiculo1.Apagar();
vehiculo1.Frenar(20);
vehiculo1.Apagar();
Console.WriteLine();

moto1.MostrarInformacion();
moto1.Acelerar(60);
moto1.HacerCaballito();
moto1.Frenar(60);
moto1.Apagar();







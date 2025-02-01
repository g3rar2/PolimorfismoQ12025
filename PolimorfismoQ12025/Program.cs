using PolimorfismoQ12025;

string? tipoInmueble, ubicacion;
double areaTerreno, precio;

Console.Write("Tipo de inmueble");
tipoInmueble = Console.ReadLine();

Console.Write("Ubicacion");
ubicacion = Console.ReadLine();

Console.Write("Area del Terreno");
areaTerreno = Convert.ToDouble(Console.ReadLine());

Console.Write("Precio");
precio = double.Parse(Console.ReadLine());

Inmueble inmueble = new Inmueble();
Inmueble inmueble1 = new Inmueble(tipoInmueble, ubicacion, areaTerreno,precio);
inmueble1.Vender();

Casa casa = new Casa(areaTerreno,precio);

casa.Vender(ubicacion);



Departamento departamento = new Departamento();
departamento.Vender(ubicacion, areaTerreno, precio);

Terreno terreno = new Terreno();
Terreno terreno1 = new Terreno();
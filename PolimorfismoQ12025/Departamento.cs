

namespace PolimorfismoQ12025
{
    public class Departamento : Inmueble
    {
        public void Vender(string Ubicacion, double AreaTerreno, double Precio)
        {
            Console.WriteLine($"Departamento con ubicacion en {Ubicacion}, con un area {AreaTerreno} mts2, ha sido vendido por el precio de {Precio}");
        }
    }
}

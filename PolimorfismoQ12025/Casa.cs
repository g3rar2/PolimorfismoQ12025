

namespace PolimorfismoQ12025
{
    public class Casa : Inmueble
    {
        public Casa(double AreaTerreno, double Precio) 
        { 
            this.AreaTerreno = AreaTerreno;
            this.Precio = Precio;
        }
        public void Vender(string Ubicacion)
        {
            Console.WriteLine($"Casa con ubicacion en {Ubicacion}, con un area de {AreaTerreno} mts , ha sido vendida por el precio de L.{Precio}");
        }
    }
}

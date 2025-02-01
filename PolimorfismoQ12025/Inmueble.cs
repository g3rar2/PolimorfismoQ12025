
namespace PolimorfismoQ12025
{
    public class Inmueble
    {
        public string TipoInmueble { get; set; }
        public string Ubicacion {  get; set; }
        public double AreaTerreno { get; set; }
        public double Precio { get; set; }

        public void vender()
        {
            Console.WriteLine($"{TipoInmueble}, con ubicacion en {Ubicacion}, con un area de terreno {AreaTerreno} mts2, ha sido vendido por el precio de L. {Precio}");
        }
    }
}

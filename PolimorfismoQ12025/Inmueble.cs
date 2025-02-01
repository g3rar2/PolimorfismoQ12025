
namespace PolimorfismoQ12025
{
    public class Inmueble
    {
        public string TipoInmueble { get; set; }
        public string Ubicacion {  get; set; }
        public double AreaTerreno { get; set; }
        public double Precio { get; set; }

        public Inmueble() { }

        public Inmueble(string TipoInmueble, string Ubicacion, double AreaTerreno, double Precio)
        {
            this.TipoInmueble = TipoInmueble;
            this.Ubicacion = Ubicacion;
            this.AreaTerreno = AreaTerreno;
            this.Precio = Precio;
        }

        public void Vender()
        {
            Console.WriteLine($"{TipoInmueble}, con ubicacion en {Ubicacion}, con un area de terreno {AreaTerreno} mts2, ha sido vendido por el precio de L. {Precio}");
        }
    }
}

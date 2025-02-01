

namespace PolimorfismoQ12025
{
    public class Terreno:Inmueble
    {
        public Terreno() { }
        public Terreno(string Ubicacion) { 
        this.Ubicacion = Ubicacion;
        }

        public Terreno(string Ubicacion, double AreaTerreno)
        {
            this.Ubicacion = Ubicacion;
            this.AreaTerreno = AreaTerreno;
        }

        public Terreno(string Ubicacion, double AreaTerreno, double Precio)
        {
            this.Ubicacion = Ubicacion;
            this.AreaTerreno = AreaTerreno;
            this.Precio = Precio;
        }

    }
}

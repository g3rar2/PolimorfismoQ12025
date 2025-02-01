

namespace PolimorfismoQ12025
{
    public class Terreno:Inmueble
    {
        public Terreno() { }


        public Terreno(string TipoInmueble)
        {
            this.TipoInmueble = TipoInmueble;

        }



        public Terreno(string TipoInmueble, string Ubicacion) { 
            this.TipoInmueble = TipoInmueble;
            this.Ubicacion = Ubicacion;
        }

        public Terreno(string TipoInmueble,string Ubicacion, double AreaTerreno)
        {
            this.TipoInmueble= TipoInmueble;
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

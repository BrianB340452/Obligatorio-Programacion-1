using Dominio.Enums;

namespace Dominio
{
    public class Venta : Publicacion
    {
        private bool _ofertaRelampago;

        public Venta(string nombre, EstadoPublicacion estado, DateTime fechaPublicacion, List<Articulo> articulos, bool ofertaRelampago) : base(nombre, estado, fechaPublicacion, articulos)
        {
            _ofertaRelampago = ofertaRelampago;
        }
    }
}

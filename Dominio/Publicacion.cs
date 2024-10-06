using Dominio.Enums;
using Dominio.Interfaces;

namespace Dominio
{
    public abstract class Publicacion : IValidable
    {
        protected int _id;
        private static int s_ultId = 1;
        protected string _nombre;
        protected EstadoPublicacion _estado;
        protected DateTime _fechaPublicacion;
        protected List<Articulo> _articulos = new List<Articulo>();
        protected Cliente _clienteComprador;
        protected Usuario _usuarioFinalizador;
        protected DateTime _fechaFinalizada;

        protected Publicacion(string nombre, EstadoPublicacion estado, DateTime fechaPublicacion, List<Articulo> articulos)
        {
            _id = s_ultId++;
            _nombre = nombre;
            _estado = estado;
            _fechaPublicacion = fechaPublicacion;
            _articulos = articulos;
        }

        public DateTime FechaPublicacion { get { return _fechaPublicacion; } }

        public virtual void Validar()
        {
            if (string.IsNullOrEmpty(_nombre)) throw new Exception("El nombre no puede estar vacío.");
            if (_articulos == null) throw new Exception("Los artículos no pueden ser nulos.");
            if (_fechaPublicacion < new DateTime(1950, 1, 1) /*|| _fechaPublicacion > DateTime.Today*/) throw new Exception("La fecha de publicación es invalida.");
        }

        public override string ToString()
        {
            return $"Nº{_id}: {_nombre} | Estado: {_estado} | Fecha publicación: {_fechaPublicacion.ToString("dd/MM/yyyy")}";
        }
    }
}

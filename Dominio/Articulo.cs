using Dominio.Interfaces;

namespace Dominio
{
    public class Articulo : IValidable
    {
        private int _id;
        private static int s_ultId = 1;
        private string _nombre;
        private string _categoria;
        private double _precio;

        public Articulo(string nombre, string categoria, double precio)
        {
            _id = s_ultId++;
            _nombre = nombre;
            _categoria = categoria;
            _precio = precio;
        }

        public string Categoria {  get { return _categoria; } }

        public void Validar()
        {
            if (string.IsNullOrEmpty(_nombre)) throw new Exception("El nombre no puede estar vacío.");
            if (string.IsNullOrEmpty(_categoria)) throw new Exception("La categoría no puede estar vacía.");
            if (_precio <= 0) throw new Exception("El precio debe ser mayor a $0.");
        }
    }
}

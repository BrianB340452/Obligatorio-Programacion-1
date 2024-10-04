namespace Dominio
{
    public class Sistema
    {
        private List<Administrador> _listaAdministradores = new List<Administrador>();
        private List<Cliente> _listaClientes = new List<Cliente>();
        private List<Articulo> _listaArticulos = new List<Articulo>();

        public Sistema()
        { 
          PrecargarCliente ();
        }

        public List<Cliente> Clientes { get { return _listaClientes; } }
        public List<Administrador> Administradores { get { return _listaAdministradores; } }

        public void AltaCliente(Cliente cliente)
        {
            if (cliente == null) throw new Exception("El cliente no puede ser nulo");
            cliente.Validar();
            _listaClientes.Add(cliente);
        }

        public void AltaArticulo(Articulo articulo)
        {
            if (articulo == null) throw new Exception("El artículo no puede ser nulo.");
            articulo.Validar();
            _listaArticulos.Add(articulo);
        }

        private void PrecargarCliente()
        {
            AltaCliente(new Cliente("Pedro","Perez","PedroPe@46","pedropedrope", 1200));
            AltaCliente(new Cliente("Carmen","Cianni","PedroPe@12","pedropedrope", 1800));
            AltaCliente(new Cliente("Cristian","Castro","PedroPe@12","pedropedrope", 1800));
        }


        public List<Cliente> ListarClientes()
        {
            return _listaClientes.OfType<Cliente>().ToList();
        }

        public List<Articulo> ListarArticulosPorCategoria(string categoria)
        {
            List<Articulo> articulos = new List<Articulo>();

            foreach (Articulo a in _listaArticulos)
            {
                if (a.Categoria == categoria) articulos.Add(a);
            }

            return articulos;
        }
    }
}
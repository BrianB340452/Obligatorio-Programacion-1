namespace Dominio
{
    public class Sistema
    {
        private List<Articulo> _listaArticulos = new List<Articulo>();
        private List<Usuario> _listaUsuarios = new List<Usuario>();

        public Sistema()
        {
            PrecargarClientes();
        }

        public List<Cliente> ListarClientes()
        {
            return _listaUsuarios.OfType<Cliente>().ToList();
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

        public void AltaArticulo(Articulo articulo)
        {
            if (articulo == null) throw new Exception("El artículo no puede ser nulo.");
            articulo.Validar();
            _listaArticulos.Add(articulo);
        }
      
        public void AltaCliente(Cliente cliente)
        {
            if (cliente == null) throw new Exception("El cliente no puede ser nulo.");
            cliente.Validar();
            _listaUsuarios.Add(cliente);
        }

        #region PRECARGAS
        private void PrecargarClientes()
        {
            AltaCliente(new Cliente("Pedro","Perez","PedroPe@46","pedropedrope", 1200));
            AltaCliente(new Cliente("Carmen","Cianni","PedroPe@12","pedropedrope", 1800));
            AltaCliente(new Cliente("Cristian","Castro","PedroPe@12","pedropedrope", 1800));
        }
        #endregion
    }
}
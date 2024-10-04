﻿namespace Dominio
{
    public class Sistema
    {
        private List<Usuario> _listaUsuarios = new List<Usuario>();
        private List<Articulo> _listaArticulos = new List<Articulo>();

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

            foreach (Articulo a in _listaArticulos) {
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
            AltaCliente(new Cliente("Nombre", "Apellido", "Email@em", "Clave", /*SALDO*/2000));
        }
        #endregion
    }
}
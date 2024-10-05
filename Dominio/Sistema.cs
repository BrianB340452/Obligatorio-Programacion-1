using Dominio.Enums;

namespace Dominio
{
    public class Sistema
    {
        private List<Usuario> _listaUsuarios = new List<Usuario>();
        private List<Articulo> _listaArticulos = new List<Articulo>();
        private List<Publicacion> _listaPublicaciones = new List<Publicacion>();

        public Sistema()
        {
            PrecargarUsuarios();
            PrecargarArticulos();
            PrecargarPublicaciones();
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
      
        public void AltaUsuario(Usuario usuario)
        {
            if (usuario == null) throw new Exception("El usuario no puede ser nulo.");
            usuario.Validar();
            _listaUsuarios.Add(usuario);
        }

        public void AltaPublicacion(Publicacion publicacion)
        {
            if (publicacion == null) throw new Exception("La publicación no puede ser nula.");
            publicacion.Validar();
            _listaPublicaciones.Add(publicacion);
        }

        public List<string> ListarCategorias()
        {
            List<string> categorias = new List<string>();

            foreach (Articulo a in _listaArticulos)
            {
                if (!categorias.Contains(a.Categoria))
                {
                    categorias.Add(a.Categoria);
                }
            }

            return categorias;
        }

        public List<Publicacion> ListarListarPublicacionesEntreDosFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            if (fechaInicio > fechaFin) throw new Exception("La fecha de inicio no puede ser mayor a la fecha final.");

            List<Publicacion> publicaciones = new List<Publicacion>();

            foreach (Publicacion p in _listaPublicaciones)
            {
                if (p.FechaPublicacion.Date >= fechaInicio.Date && p.FechaPublicacion.Date <= fechaFin.Date)
                {
                    publicaciones.Add(p);
                }
            }

            return publicaciones;
        }

        #region PRECARGAS
        private void PrecargarUsuarios()
        {
            // Precarga de clientes
            AltaUsuario(new Cliente("Pedro", "Perez", "PedroPerez@gmail.com", "pedroPe123", 1900));
            AltaUsuario(new Cliente("Laura", "Gomez", "LauraGomez@gmail.com", "lauraG456", 2500));
            AltaUsuario(new Cliente("Carlos", "Diaz", "CarlosDiaz@gmail.com", "carlosD789", 3200));
            AltaUsuario(new Cliente("Ana", "Martinez", "AnaMartinez@gmail.com", "anaM101", 1500));
            AltaUsuario(new Cliente("Juan", "Lopez", "JuanLopez@gmail.com", "juanL202", 2800));
            AltaUsuario(new Cliente("Maria", "Hernandez", "MariaHernandez@gmail.com", "mariaH303", 4100));
            AltaUsuario(new Cliente("Luis", "Garcia", "LuisGarcia@gmail.com", "luisG404", 1800));
            AltaUsuario(new Cliente("Sofia", "Rodriguez", "SofiaRodriguez@gmail.com", "sofiaR505", 3300));
            AltaUsuario(new Cliente("Diego", "Sanchez", "DiegoSanchez@gmail.com", "diegoS606", 1200));
            AltaUsuario(new Cliente("Lucia", "Ramirez", "LuciaRamirez@gmail.com", "luciaR707", 2950));

            // Precarga de administradores
            AltaUsuario(new Administrador("Santiago", "Fernandez", "SantiMas@gmail.com", "Firulais33"));
            AltaUsuario(new Administrador("Valeria", "Torres", "ValeriaTorres@gmail.com", "valTorres44"));
        }

        private void PrecargarArticulos()
        {
            AltaArticulo(new Articulo("Laptop", "Electrónica", 2000));
            AltaArticulo(new Articulo("Smartphone", "Electrónica", 1000));
            AltaArticulo(new Articulo("Televisor", "Electrónica", 1500));
            AltaArticulo(new Articulo("Cafetera", "Hogar", 300));
            AltaArticulo(new Articulo("Lavadora", "Electrodomésticos", 2500));
            AltaArticulo(new Articulo("Secadora", "Electrodomésticos", 2300));
            AltaArticulo(new Articulo("Refrigerador", "Electrodomésticos", 3000));
            AltaArticulo(new Articulo("Silla de oficina", "Muebles", 150));
            AltaArticulo(new Articulo("Escritorio", "Muebles", 400));
            AltaArticulo(new Articulo("Cama", "Muebles", 700));
            AltaArticulo(new Articulo("Monitor", "Electrónica", 500));
            AltaArticulo(new Articulo("Teclado mecánico", "Electrónica", 100));
            AltaArticulo(new Articulo("Ratón inalámbrico", "Electrónica", 50));
            AltaArticulo(new Articulo("Audífonos", "Electrónica", 200));
            AltaArticulo(new Articulo("Bicicleta", "Deportes", 800));
            AltaArticulo(new Articulo("Pelota de fútbol", "Deportes", 40));
            AltaArticulo(new Articulo("Zapatillas deportivas", "Deportes", 120));
            AltaArticulo(new Articulo("Camisa", "Ropa", 30));
            AltaArticulo(new Articulo("Pantalón", "Ropa", 50));
            AltaArticulo(new Articulo("Zapatos", "Ropa", 80));
            AltaArticulo(new Articulo("Guitarra", "Música", 600));
            AltaArticulo(new Articulo("Piano eléctrico", "Música", 1500));
            AltaArticulo(new Articulo("Batería", "Música", 2000));
            AltaArticulo(new Articulo("Libro de cocina", "Libros", 25));
            AltaArticulo(new Articulo("Novela", "Libros", 20));
            AltaArticulo(new Articulo("Enciclopedia", "Libros", 120));
            AltaArticulo(new Articulo("Plancha", "Hogar", 60));
            AltaArticulo(new Articulo("Aspiradora", "Hogar", 200));
            AltaArticulo(new Articulo("Ventilador", "Electrodomésticos", 150));
            AltaArticulo(new Articulo("Cámara fotográfica", "Electrónica", 700));
            AltaArticulo(new Articulo("Dron", "Electrónica", 1200));
            AltaArticulo(new Articulo("Smartwatch", "Electrónica", 300));
            AltaArticulo(new Articulo("Tablet", "Electrónica", 600));
            AltaArticulo(new Articulo("Altavoces", "Electrónica", 250));
            AltaArticulo(new Articulo("Impresora", "Oficina", 400));
            AltaArticulo(new Articulo("Proyector", "Oficina", 800));
            AltaArticulo(new Articulo("Calculadora", "Oficina", 20));
            AltaArticulo(new Articulo("Cámara de seguridad", "Electrónica", 500));
            AltaArticulo(new Articulo("Router Wi-Fi", "Electrónica", 120));
            AltaArticulo(new Articulo("Modem", "Electrónica", 100));
            AltaArticulo(new Articulo("Microondas", "Electrodomésticos", 300));
            AltaArticulo(new Articulo("Horno eléctrico", "Electrodomésticos", 400));
            AltaArticulo(new Articulo("Licuadora", "Hogar", 150));
            AltaArticulo(new Articulo("Tostadora", "Hogar", 80));
            AltaArticulo(new Articulo("Set de cuchillos", "Cocina", 50));
            AltaArticulo(new Articulo("Olla a presión", "Cocina", 200));
            AltaArticulo(new Articulo("Sartén antiadherente", "Cocina", 100));
            AltaArticulo(new Articulo("Mesa de comedor", "Muebles", 1000));
            AltaArticulo(new Articulo("Set de cucharas", "Cocina", 100));
        }

        private void PrecargarPublicaciones()
        {
            AltaPublicacion(new Subasta("Subasta 1", EstadoPublicacion.ABIERTA, new DateTime(2024, 09, 15), SeleccionarArticulosAleatorios(2), null));
            AltaPublicacion(new Subasta("Subasta 2", EstadoPublicacion.ABIERTA, new DateTime(2024, 09, 18), SeleccionarArticulosAleatorios(6), null));
            AltaPublicacion(new Subasta("Subasta 3", EstadoPublicacion.ABIERTA, new DateTime(2024, 09, 20), SeleccionarArticulosAleatorios(4), null));
            AltaPublicacion(new Subasta("Subasta 4", EstadoPublicacion.ABIERTA, new DateTime(2024, 09, 22), SeleccionarArticulosAleatorios(3), null));
            AltaPublicacion(new Subasta("Subasta 5", EstadoPublicacion.ABIERTA, new DateTime(2024, 09, 25), SeleccionarArticulosAleatorios(4), null));
            AltaPublicacion(new Subasta("Subasta 6", EstadoPublicacion.ABIERTA, new DateTime(2024, 09, 27), SeleccionarArticulosAleatorios(2), null));
            AltaPublicacion(new Subasta("Subasta 7", EstadoPublicacion.ABIERTA, new DateTime(2024, 10, 01), SeleccionarArticulosAleatorios(1), null));
            AltaPublicacion(new Subasta("Subasta 8", EstadoPublicacion.ABIERTA, new DateTime(2024, 10, 03), SeleccionarArticulosAleatorios(4), null));
            AltaPublicacion(new Subasta("Subasta 9", EstadoPublicacion.ABIERTA, new DateTime(2024, 10, 05), SeleccionarArticulosAleatorios(4), null));
            AltaPublicacion(new Subasta("Subasta 10", EstadoPublicacion.ABIERTA, new DateTime(2024, 10, 10), SeleccionarArticulosAleatorios(6), null));

            AltaPublicacion(new Venta("Venta 1", EstadoPublicacion.ABIERTA, new DateTime(2024, 10, 01), SeleccionarArticulosAleatorios(3), true));
            AltaPublicacion(new Venta("Venta 2", EstadoPublicacion.ABIERTA, new DateTime(2024, 10, 05), SeleccionarArticulosAleatorios(4), false));
            AltaPublicacion(new Venta("Venta 3", EstadoPublicacion.ABIERTA, new DateTime(2024, 10, 08), SeleccionarArticulosAleatorios(1), false));
            AltaPublicacion(new Venta("Venta 4", EstadoPublicacion.ABIERTA, new DateTime(2024, 10, 12), SeleccionarArticulosAleatorios(5), false));
            AltaPublicacion(new Venta("Venta 5", EstadoPublicacion.ABIERTA, new DateTime(2024, 10, 15), SeleccionarArticulosAleatorios(7), true));
            AltaPublicacion(new Venta("Venta 6", EstadoPublicacion.ABIERTA, new DateTime(2024, 10, 20), SeleccionarArticulosAleatorios(2), false));
            AltaPublicacion(new Venta("Venta 7", EstadoPublicacion.ABIERTA, new DateTime(2024, 10, 25), SeleccionarArticulosAleatorios(7), true));
            AltaPublicacion(new Venta("Venta 8", EstadoPublicacion.ABIERTA, new DateTime(2024, 10, 30), SeleccionarArticulosAleatorios(3), false));
            AltaPublicacion(new Venta("Venta 9", EstadoPublicacion.ABIERTA, new DateTime(2024, 11, 02), SeleccionarArticulosAleatorios(7), false));
            AltaPublicacion(new Venta("Venta 10", EstadoPublicacion.ABIERTA, new DateTime(2024, 11, 05), SeleccionarArticulosAleatorios(1), true));
        }

        private List<Articulo> SeleccionarArticulosAleatorios(int cantidad)
        {
            Random random = new Random();
            List<Articulo> articulosSeleccionados = new List<Articulo>();

            while (articulosSeleccionados.Count < cantidad && articulosSeleccionados.Count < _listaArticulos.Count)
            {
                int indiceAleatorio = random.Next(_listaArticulos.Count);

                // Asegurarse de que no se selecciona el mismo artículo dos veces
                if (!articulosSeleccionados.Contains(_listaArticulos[indiceAleatorio]))
                {
                    articulosSeleccionados.Add(_listaArticulos[indiceAleatorio]);
                }
            }

            return articulosSeleccionados;
        }

        #endregion
    }
}
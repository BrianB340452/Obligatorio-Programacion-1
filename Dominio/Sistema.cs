namespace Dominio
{
    public class Sistema
    {
        private List<Articulo> _listaArticulos = new List<Articulo>();
        private List<Usuario> _listaUsuarios = new List<Usuario>();

        public Sistema()
        {
            PrecargarUsuario();
            PrecargarArticulos();
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

        public void AltaAdministrador(Administrador administrador)
        {
            if (administrador == null) throw new Exception("El Administrador no puede ser nulo.");
            administrador.Validar();
            _listaUsuarios.Add(administrador);
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

        #region PRECARGAS
        private void PrecargarUsuario()
        {
            // Precarga de clientes
            AltaCliente(new Cliente("Pedro", "Perez", "PedroPerez@gmail.com", "pedroPe123", 1900));
            AltaCliente(new Cliente("Laura", "Gomez", "LauraGomez@gmail.com", "lauraG456", 2500));
            AltaCliente(new Cliente("Carlos", "Diaz", "CarlosDiaz@gmail.com", "carlosD789", 3200));
            AltaCliente(new Cliente("Ana", "Martinez", "AnaMartinez@gmail.com", "anaM101", 1500));
            AltaCliente(new Cliente("Juan", "Lopez", "JuanLopez@gmail.com", "juanL202", 2800));
            AltaCliente(new Cliente("Maria", "Hernandez", "MariaHernandez@gmail.com", "mariaH303", 4100));
            AltaCliente(new Cliente("Luis", "Garcia", "LuisGarcia@gmail.com", "luisG404", 1800));
            AltaCliente(new Cliente("Sofia", "Rodriguez", "SofiaRodriguez@gmail.com", "sofiaR505", 3300));
            AltaCliente(new Cliente("Diego", "Sanchez", "DiegoSanchez@gmail.com", "diegoS606", 1200));
            AltaCliente(new Cliente("Lucia", "Ramirez", "LuciaRamirez@gmail.com", "luciaR707", 2950));

            // Precarga de administradores
            AltaAdministrador(new Administrador("Santiago", "Fernandez", "SantiMas@gmail.com", "Firulais33"));
            AltaAdministrador(new Administrador("Valeria", "Torres", "ValeriaTorres@gmail.com", "valTorres44"));

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
        #endregion
    }
}
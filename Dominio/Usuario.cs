using Dominio.Interfaces;

namespace Dominio
{
    public abstract class Usuario : IValidable
    {
        private int _id;
        private static int s_ultId = 1;
        private string _nombre;
        private string _apellido;
        private string _email;
        private string _clave;

        public Usuario(string nombre, string apellido, string email, string clave)
        {
            _id = s_ultId++;
            _nombre = nombre;
            _apellido = apellido;
            _email = email;
            _clave = clave;
        }

        public virtual void Validar()
        {
            if (string.IsNullOrEmpty(_nombre)) throw new Exception("El nombre no puede estar vacío.");
            if (string.IsNullOrEmpty(_apellido)) throw new Exception("El apellido no puede estar vacío.");
            if (!EmailValido(_email)) throw new Exception("El email ingresado es inválido.");
            if (_clave.Length < 4) throw new Exception("La contraseña debe contener un mínimo de 4 caracteres.");
        }

        private bool EmailValido(string email)
        {
            if (string.IsNullOrEmpty(email)) return false;
            if (!email.Contains("@")) return false;
            if (email.Contains(" ")) return false;
            if (email.StartsWith("@")) return false;
            if (email.EndsWith("@")) return false;

            return true;
        }

        public override string ToString()
        {
            return $"Nombre - {_nombre} - Apellido: {_apellido}";
        }
    }
}

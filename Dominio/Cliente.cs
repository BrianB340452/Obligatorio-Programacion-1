namespace Dominio
{
    public class Cliente : Usuario
    {
        private double _saldo;

        public Cliente(string nombre, string apellido, string email, string clave, double saldo) : base(nombre, apellido, email, clave)
        {

            _saldo = saldo;
        }

        public override string ToString()
        {
            return $"{_id}: {_nombre} {_apellido} | {_email} | ${_saldo}";
        }
    }
}

namespace Dominio
{
    public class Cliente : Usuario
    {
        private double _saldo;

        public Cliente(string nombre, string apellido, string email, string clave, double saldo) : base(nombre, apellido, email, clave)
        {
            _saldo = saldo;
        }

        private void ValidarSaldo()
        {
            if (_saldo < 0) throw new Exception("Debe tener un saldo positivo");
        }

        public override void Validar()
        { 
           base.Validar();
           ValidarSaldo();
        }
    }
}

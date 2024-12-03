
using System.Globalization;

namespace ExercicioContaBancaria
{
    internal class ContaBancaria
    {
        private int _idConta;
        public string NomeTitular { get; private set; }
        private double _saldo;

        public ContaBancaria(int idConta, string nomeTitular, double saldo)
        {
            _idConta = idConta;
            NomeTitular = nomeTitular;
            _saldo = saldo;
        }

        public ContaBancaria(int idConta, string nomeTitular)
        {
            _idConta = idConta;
            NomeTitular = nomeTitular;
            _saldo = 0.00;
        }

        public int Conta
        {
            get { return _idConta; }
        }

        public double Saldo
        {
            get { return _saldo; }
        }


        public override string ToString()
        {
            return "Conta "
                   + _idConta 
                   + ", Titular: "
                   + NomeTitular
                   + ", Saldo: $"
                   + _saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

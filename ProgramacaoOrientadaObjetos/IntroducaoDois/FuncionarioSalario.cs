using System.Globalization;

namespace Introducao.ClassesIntroducao
{
    internal class FuncionarioSalario
    {
        public string Nome;
        public double SalarioBruto;
        public double Impostos;

        public double SalarioLiquido()
        {
            return SalarioBruto - Impostos;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto * (porcentagem / 100);
        }

        public override string ToString()
        {
            return "Funcionário:"
                + Nome
                + ", $ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

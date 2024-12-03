
namespace Introducao
{
    internal class ConversorDeMoeda
    {
        public static double ValorASerPago(double cotacao, double valor)
        {
            return (cotacao * valor) * 1.06;
        }
    }
}

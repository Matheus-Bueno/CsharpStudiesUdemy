namespace Introducao.ClassesIntroducao
{
    internal class Aluno
    {
        public string Nome;
        public double PrimeiraNota;
        public double SegundaNota;
        public double TerceiraNota;


        public double NotaFinal()
        {
            return PrimeiraNota + SegundaNota + TerceiraNota;
        }

        public bool Aprovado()
        {
            if (NotaFinal() > 60.0)
            {
                return true;
            }
            return false;
        }

        public double FaltouQuantosPontos()
        {
            return 60.0 - NotaFinal();
        }
    }
}

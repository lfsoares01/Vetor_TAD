namespace Vetor_TAD;

class Program
{
    static void Main(string[] args)
    {
        Vetor meuVetor = new Vetor(5);
        meuVetor.PreencherVetor();
        meuVetor.ExibirVetor();
        Vetor meuVetor2 = new Vetor (10);
        meuVetor2.PreencherVetor();
        meuVetor2.ExibirVetor();
    }
}

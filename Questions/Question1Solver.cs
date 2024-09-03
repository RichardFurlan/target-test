namespace TesteTarget.Questions;

public class Question1Solver
{
    public int CalcularSoma()
    {
        const int INDICE = 13;
        int soma = 0, K = 0;

        while (K < INDICE)
        {
            K += 1;
            soma += K;
        }
        return soma;
    }
}
namespace TesteTarget.Questions;

public class Question5Solver
{
    public string InverterString(string texto)
    {
        char[] caracteres = texto.ToCharArray();
        int inicio = 0, fim = caracteres.Length - 1;

        while (inicio < fim)
        {
            (caracteres[inicio], caracteres[fim]) = (caracteres[fim], caracteres[inicio]);
            inicio++;
            fim--;
        }

        return new string(caracteres);
    }
}
namespace TesteTarget.Questions;

public class Question4Solver
{
    public void CalcularPercentualRepresentacao()
    {
        var faturamentosPorEstado = new Dictionary<string, double>
        {
            { "SP", 67836.43 },
            { "RJ", 36678.66 },
            { "MG", 29229.88 },
            { "ES", 27165.48 },
            { "Outros", 19849.53 }
        };

        double faturamentoTotal = faturamentosPorEstado.Values.Sum();

        foreach (var estado in faturamentosPorEstado)
        {
            double percentual = (estado.Value / faturamentoTotal) * 100;
            Console.WriteLine($"{estado.Key}: {percentual:F2}%");
        }
    }
}
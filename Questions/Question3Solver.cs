using System.Text.Json;

namespace TesteTarget.Questions
{
    public class Faturamento
    {
        public DateTime Data { get; set; }
        public double Valor { get; set; }
    }

    public class Question3Solver
    {
        private List<Faturamento> _faturamentos;
        
        public void CarregarFaturamentos(string filePath)
        {
            var jsonString = File.ReadAllText(filePath);
            _faturamentos = JsonSerializer.Deserialize<List<Faturamento>>(jsonString)
                                ?.Where(f => f.Valor > 0)
                                .ToList() 
                            ?? new List<Faturamento>();
        }

        public double ObterMenorFaturamento()
        {
            if (_faturamentos == null || !_faturamentos.Any())
                throw new InvalidOperationException("Faturamentos não carregados.");

            return _faturamentos.Min(f => f.Valor);
        }

        public double ObterMaiorFaturamento()
        {
            if (_faturamentos == null || !_faturamentos.Any())
                throw new InvalidOperationException("Faturamentos não carregados.");

            return _faturamentos.Max(f => f.Valor);
        }

        public int ObterDiasAcimaDaMedia()
        {
            if (_faturamentos == null || !_faturamentos.Any())
                throw new InvalidOperationException("Faturamentos não carregados.");

            double mediaMensal = _faturamentos.Average(f => f.Valor);
            return _faturamentos.Count(f => f.Valor > mediaMensal);
        }
    }
}
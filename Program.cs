using TesteTarget.Questions;

// Questão 1
var question1 = new Question1Solver();
Console.WriteLine($"Resultado da questão 1: {question1.CalcularSoma()}");

// Questão 2
var question2 = new Question2Solver();
int numeroFibonacci = 21; // Defina o número que deseja verificar
Console.WriteLine($"O número {numeroFibonacci} pertence à sequência de Fibonacci? {question2.EhFibonacci(numeroFibonacci)}");

// Questão 3
var solver = new Question3Solver();

string filePath = "Data/faturamento.json";
solver.CarregarFaturamentos(filePath);

Console.WriteLine($"Menor Faturamento: {solver.ObterMenorFaturamento()}");
Console.WriteLine($"Maior Faturamento: {solver.ObterMaiorFaturamento()}");
Console.WriteLine($"Dias Acima da Média: {solver.ObterDiasAcimaDaMedia()}");


// Questão 4
var question4 = new Question4Solver();
question4.CalcularPercentualRepresentacao();

// Questão 5
var question5 = new Question5Solver();
string texto = "Invertida";
Console.WriteLine($"String invertida: {question5.InverterString(texto)}");
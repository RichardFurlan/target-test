# Teste Técnico - Target

Este repositório contém a solução para o teste técnico proposto pela empresa **Target**. A aplicação foi desenvolvida em **C#**, utilizando o framework **.NET Core**. O projeto consiste em responder às questões técnicas descritas no desafio, utilizando uma aplicação de console.

## 🎯 Objetivo

A aplicação resolve as seguintes questões técnicas:

1. **Soma de valores**
2. **Verificação de número na sequência de Fibonacci**
3. **Cálculo de faturamento diário**
4. **Percentual de representação por estado**
5. **Inversão de string**

## 🛠️ Tecnologias Utilizadas

- **C#**
- **.NET Core**
- **JSON** para leitura de dados de faturamento
- **LINQ** para manipulação de coleções
- **Sistema de arquivos** para leitura de arquivos

## ⚙️ Estrutura do Projeto

/TesteTarget <br>
  ├── /Questions <br>
  │   ├── Question1Solver.cs <br>
  │   ├── Question2Solver.cs <br>
  │   ├── Question3Solver.cs <br>
  │   ├── Question4Solver.cs <br>
  │   └── Question5Solver.cs <br>
  ├── /Data <br>
  │   └── faturamento.json <br>
  └── Program.cs <br>

O projeto está organizado em pastas para cada questão, facilitando a navegação e o entendimento do código.

Cada uma das classes `QuestionXSolver.cs` contém a lógica necessária para resolver a questão correspondente. O arquivo `Program.cs` orquestra a execução do código e imprime os resultados no console.

## 🚀 Executando o Projeto

### Pré-requisitos

- .NET Core SDK 6.0 ou superior instalado em sua máquina.

### Passo a Passo para Executar

1. **Clone o repositório:**
 ```
  git clone https://github.com/seu-usuario/nome-do-repositorio.git
```
2. **Navegue até a pasta do projeto:**
 ```
  cd nome-do-repositorio
```
3. **Restaurar pacotes:**
```
  dotnet restore
```
4. **Executar a aplicação:**
```
  dotnet restore
```
5. **Visualizar os Resultados:**
  A aplicação irá processar cada questão e imprimir os resultados diretamente no console.

## ⚠️ Observação Importante
Para a Questão 3, o programa lê os dados de faturamento a partir de um arquivo JSON localizado na pasta Data. Certifique-se de que o arquivo faturamento.json está presente nesta pasta e contém os dados no formato correto.

Exemplo de Arquivo JSON
O arquivo faturamento.json deve seguir o formato abaixo:
```JSON
[
  { "Data": "2024-09-01", "Valor": 1000.0 },
  { "Data": "2024-09-02", "Valor": 2500.0 },
  { "Data": "2024-09-03", "Valor": 0.0 },
  { "Data": "2024-09-04", "Valor": 1500.0 }
]
```

Esse arquivo é utilizado para calcular o menor, maior valor de faturamento e também a quantidade de dias com faturamento acima da média mensal.

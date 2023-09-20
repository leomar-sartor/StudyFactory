// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello Calcula Parcelas!");

//int soma = 0, diferenca = 0, produto = 0, resto = 0;
//double divisao = 0; // resultado da divisão
//int num1 = 10, num2 = 2;
//soma = num1 + num2;
//diferenca = num1 - num2;
//produto = num1 * num2;
//divisao = num1 / num2;
//// resto de 3/2
//resto = 3 % num2;
//Console.WriteLine("num1 = {0}, num2 = {1}", num1, num2);
//Console.WriteLine();
//Console.WriteLine("Soma de {0} e {1} é {2}", num1, num2, soma);
//Console.WriteLine("Diferença de {0} e {1} é {2}", num1, num2, diferenca);
//Console.WriteLine("Produto de {0} e {1} é {2}", num1, num2, produto);
//Console.WriteLine("Quociente de {0} e {1} é {2}", num1, num2, divisao);
//Console.WriteLine();
//Console.WriteLine("resto de 3 quando é dividido por {0} é {1}", num2, resto);

//decimal valorTotal = 100M;
//uint numeroDeParcelas = 3;

//decimal valorTotal = 157.33M;
//uint numeroDeParcelas = 7;

decimal valorTotal = 187.32M;
uint numeroDeParcelas = 9;

decimal somaParcelas = 0;
decimal restoParcelas = 0;

for (int i = 1; i <= numeroDeParcelas; i++)
{
    var valueForTwoDecimals = (valorTotal / numeroDeParcelas);
    var valorParcela= Math.Floor(valueForTwoDecimals * 100) / 100;
    somaParcelas += valorParcela;
}

restoParcelas = valorTotal - somaParcelas;

if ((restoParcelas + somaParcelas) != valorTotal || restoParcelas < 0 || somaParcelas > valorTotal)
    throw new Exception("Divergência do Valor total com as parcelas");

Console.WriteLine("valorTotal = {0}, somaParcelas = {1}, restoParcelas = {2}", valorTotal, somaParcelas, restoParcelas);

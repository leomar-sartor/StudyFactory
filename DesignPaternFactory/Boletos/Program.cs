using Boletos.Factory;

Console.WriteLine("Hello, Boletos!");

//decimal valorTotal = 100M; //3X
decimal valorTotal = 157.33M; // 7X
//decimal valorTotal = 187.32M; // 9X

try
{
    var duplicatas = DuplicatasFactory.Create(Boletos.FormaPagamentoEnum.AVista, valorTotal);

    if(duplicatas is not null)
    {
        if (duplicatas.Boletos.Any())
        {
            foreach (var boleto in duplicatas.Boletos)
            {
                Console.WriteLine($"Numero: {boleto.Parcela} | Valor: {boleto.Valor}");
            }
        }
        else
        {
            Console.WriteLine("Lançamento Manual");
        }
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.ReadLine();
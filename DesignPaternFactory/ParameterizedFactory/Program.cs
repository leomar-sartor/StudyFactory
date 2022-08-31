using ParameterizedFactory;

Console.WriteLine("Olá Design Pattern PARAMETERIZED FACTORY METHOD!");

var arquivo = AnalisadorFactory.Create("teste.xml");

Console.WriteLine("Nosso XML deu certo! Agora vamos forçar um erro criando um TXT :D");

try
{
    var arquivoLancaException = AnalisadorFactory.Create("teste.txt");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.ReadLine();
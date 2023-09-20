using DesignPaternFactory.Factory;

Console.WriteLine("Olá Design Pattern Factory!");

Console.WriteLine("Escolha o Lanche : ");
Console.WriteLine("(1)Bauru  (2)Frango  (3)Misto Quente  (4)Vegetariano");

var lancheEscolhido = Convert.ToInt32(Console.ReadLine());

try
{
    LancheFactory factory = new LancheFactory();

    var lanche = factory.CriarLanche(lancheEscolhido);
    Console.WriteLine(lanche.Nome);

    foreach (var ingrediente in lanche.Ingredientes)
        Console.WriteLine(ingrediente);

    Console.WriteLine("\nLanche montado com sucesso");
}
catch (Exception ex)
{
    Console.WriteLine("Erro :" + ex.Message);
}

Console.ReadLine();
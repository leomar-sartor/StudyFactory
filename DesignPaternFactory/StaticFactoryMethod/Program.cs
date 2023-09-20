using StaticFactoryMethod.Entidade;

Console.WriteLine("Olá Design Pattern STATIC FACTORY METHOD!");

var prazoPadrao = Prazo.CriarNovoEntreDatasPadrao();

Console.WriteLine($"\n=== Prazo Padrão ===");
Console.WriteLine($"Data Inicial: {prazoPadrao.DataInicial}");
Console.WriteLine($"Data Final: {prazoPadrao.DataFinal}");

var dataIncial = new DateTime(2022, 01, 01);
var dataFinal = new DateTime(2022, 12, 31);
var prazoInformado = Prazo.CriarNovoEntreDatas(dataIncial, dataFinal);

Console.WriteLine($"\n=== Prazo Informado ===");
Console.WriteLine($"Data Inicial: {prazoInformado.DataInicial}");
Console.WriteLine($"Data Final: {prazoInformado.DataFinal}");

Console.ReadLine();
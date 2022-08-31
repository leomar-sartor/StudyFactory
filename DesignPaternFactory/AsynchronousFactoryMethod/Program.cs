using AsynchronousFactoryMethod;

Console.WriteLine("Olá Design Pattern ASYNC FACTORY METHOD!");

var armazenamento = await Armazenamento.CreateNewAsync();

Console.WriteLine($"Esperando...");

Console.ReadLine();
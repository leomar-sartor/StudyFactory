using InnerFactory;

Console.WriteLine("Olá Design Pattern INNER FACTORY !");

//Consuming
var contrato = Contrato.Factory.CreateNewBetweenDefaultDates();

Console.WriteLine("E não é que deu certo !");


Console.ReadLine();
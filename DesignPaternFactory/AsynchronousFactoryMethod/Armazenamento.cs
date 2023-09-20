namespace AsynchronousFactoryMethod
{
    public class Armazenamento
    {
        private Armazenamento() { }

        public static async Task<Armazenamento> CreateNewAsync()
        {
            //Simula uma operação Assíncrona
            await Task.Delay(100);
            return new Armazenamento();
        }
    }
}

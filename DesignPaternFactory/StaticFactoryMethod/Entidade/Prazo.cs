namespace StaticFactoryMethod.Entidade
{
    public class Prazo
    {
        //Properties
        public DateTime DataInicial { get; }
        public DateTime DataFinal { get; }

        //Private constructor
        private Prazo(DateTime dataInicial, DateTime dataFinal)
        {
            this.DataInicial = dataInicial;
            this.DataFinal = dataFinal;
        }

        //Static factory methods
        public static Prazo CriarNovoEntreDatasPadrao()
            => new Prazo(new DateTime(2000, 1, 1), DateTime.UtcNow);

        public static Prazo CriarNovoEntreDatas(DateTime dataInicial, DateTime dataFinal)
            => new Prazo(dataInicial, dataFinal);
    }
}

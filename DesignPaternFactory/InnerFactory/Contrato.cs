namespace InnerFactory
{
    public class Contrato
    {
        //Properties
        public DateTime DataInicial { get; }
        public DateTime DataFinal { get; }

        //Private constructor
        private Contrato(DateTime dataInicial, DateTime dataFinal)
        {
            this.DataInicial = dataInicial;
            this.DataFinal = dataFinal;
        }

        //Inner factory
        public static class Factory
        {
            //Static factory methods
            public static Contrato CreateNewBetweenDefaultDates()
                => new Contrato(new DateTime(2000, 1, 1), DateTime.UtcNow);

            public static Contrato CreateNewBetweenDates(DateTime startDate, DateTime endDate)
                => new Contrato(startDate, endDate);
        }
    }
}

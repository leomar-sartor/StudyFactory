using Boletos.Interfaces;

namespace Boletos.Entidades
{
    public class Boleto : IDuplicate
    {
        public List<Boleto> Boletos { get; set; }
        public int Parcela { get; set; }
        public decimal Valor { get; set; }
    }
}

using Boletos.Abstract;
using Boletos.Interfaces;

namespace Boletos.Entidades
{
    internal class Cheque : CalculaParcelasAbstract, IDuplicate
    {
        public const uint _numeroParcelas = 0;
        public List<Boleto> Boletos { get; set; }
        public Cheque(decimal ValorTotal)
        {
            Boletos = this.GerarDuplicatas(ValorTotal, _numeroParcelas);
        }
    }
}

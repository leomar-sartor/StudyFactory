using Boletos.Abstract;
using Boletos.Interfaces;

namespace Boletos.Entidades
{
    internal class Avista : CalculaParcelasAbstract, IDuplicate
    {
        public const uint _numeroParcelas = 1;
        public List<Boleto> Boletos { get; set; }
        public Avista(decimal ValorTotal)
        {
            Boletos = this.GerarDuplicatas(ValorTotal, _numeroParcelas);
        }
    }
}

using Boletos.Abstract;
using Boletos.Interfaces;

namespace Boletos.Entidades
{
    internal class TrezVezes : CalculaParcelasAbstract, IDuplicate
    {
        public const uint _numeroParcelas = 3;
        public List<Boleto> Boletos { get; set; }

        public TrezVezes(decimal ValorTotal)
        {
            Boletos = this.GerarDuplicatas(ValorTotal, _numeroParcelas);
        }
    }
}

using Boletos.Abstract;
using Boletos.Interfaces;

namespace Boletos.Entidades
{
    internal class UmaMaisTres : CalculaParcelasAbstract, IDuplicate
    {
        public const uint _numeroParcelas = 4;
        public List<Boleto> Boletos { get; set; }
        public UmaMaisTres(decimal ValorTotal)
        {
            Boletos = this.GerarDuplicatas(ValorTotal, _numeroParcelas);
        }

    }
}

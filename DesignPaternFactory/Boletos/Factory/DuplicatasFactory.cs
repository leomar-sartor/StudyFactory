using Boletos.Entidades;
using Boletos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletos.Factory
{
    public static class DuplicatasFactory
    {
        public static IDuplicate Create(FormaPagamentoEnum formaPagamento, decimal valorTotal)
        {
            return GetDuplicatas(formaPagamento, valorTotal);
        }

        private static IDuplicate GetDuplicatas(FormaPagamentoEnum formaPagamento, decimal valorTotal) => formaPagamento switch
        {
            FormaPagamentoEnum.AVista => new Avista(valorTotal),
            //FormaPagamentoEnum. => new Cheque(valorTotal),
            FormaPagamentoEnum.TresVezes => new TrezVezes(valorTotal),
            //FormaPagamentoEnum. => new UmaMaisTres(valorTotal),
            _ => throw new Exception("Tipo de Pagamento: (" + formaPagamento + ") não existente")
        };
    }
}

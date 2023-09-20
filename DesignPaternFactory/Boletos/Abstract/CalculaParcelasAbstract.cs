using Boletos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletos.Abstract
{
    abstract class CalculaParcelasAbstract
    {
        protected List<Boleto> Parcelas { get; set; }
        public List<Boleto> GerarDuplicatas(decimal valorTotal, uint numeroParcelas)
        {
            var boletos = new List<Boleto>();

            if (numeroParcelas == 0)
                return boletos;

            decimal somaParcelas = 0;
            decimal restoParcelas = 0;

            for (int i = 1; i <= numeroParcelas; i++)
            {
                var valueForTwoDecimals = (valorTotal / numeroParcelas);
                var valorParcela = Math.Floor(valueForTwoDecimals * 100) / 100;

                boletos.Add(new Boleto()
                {
                    Parcela = i,
                    Valor = valorParcela
                });

                somaParcelas += valorParcela;
            }

            restoParcelas = valorTotal - somaParcelas;

            if ((restoParcelas + somaParcelas) != valorTotal || restoParcelas < 0 || somaParcelas > valorTotal)
                throw new Exception("Divergência do Valor total com as parcelas");

            if (restoParcelas > 0)
            {
                boletos.Where(m => m.Parcela == 1).First().Valor += restoParcelas;
            }

            Console.WriteLine("\nvalorTotal = {0}, somaParcelas = {1}, restoParcelas = {2} \n", valorTotal, somaParcelas, restoParcelas);

            return boletos;
        }
    }
}

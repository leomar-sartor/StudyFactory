using Boletos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletos.Interfaces
{
    public interface IDuplicate 
    {
        List<Boleto> Boletos { get; set; }

    }
}

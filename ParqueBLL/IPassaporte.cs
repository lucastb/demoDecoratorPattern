using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueBLL
{
    public interface IPassaporte
    {
        String NomeCliente { get; }
        int NroDias { get; }
        decimal ValorBasico { get; }
        DateTime DataInicial { get; }

        decimal valorDoDia(int nrodia);
        decimal valorTotal();

    }
}
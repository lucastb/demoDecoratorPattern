using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueBLL
{
    class PassaporteBasico : IPassaporte
    {

        public PassaporteBasico(String umCliente, int umNroDias, decimal umValorBasico, int dia, int mes, int ano)
        {
            NomeCliente = umCliente;
            NroDias = umNroDias;
            ValorBasico = umValorBasico;
            DataInicial = new DateTime(ano, mes, dia);
        }


        public string NomeCliente { get; }
        public int NroDias { get; }
        public decimal ValorBasico { get; }
        public DateTime DataInicial { get; }

        public decimal valorDoDia(int nrodia)
        {
            decimal valorDia = ValorBasico;

            for (int i = 0; i < nrodia - 1; i++)
            {
                valorDia = valorDia - (valorDia * 0.2M);
            }
            return valorDia;
        }

        public decimal valorTotal()
        {
            decimal valorTotal = 0;
            for (int d = 1; d <= NroDias; d++)
            {
                valorTotal += valorDoDia(d);
            }
            return valorTotal;
        }

        public override string ToString()
        {
            return String.Format("Cliente: {0}\t Valor básico: {1}  Numero de dias: {2}",
                NomeCliente, 
                ValorBasico,
                NroDias);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParqueBLL
{
    public class FachadaParque
    {
        public IPassaporte CriarPassaporte(String umCliente,
                                                  int umNroDias,
                                                  decimal umValorBasico,
                                                  int dia,
                                                  int mes,
                                                  int ano,
                                                  PromocoesAtivas[] descontos)
        {
            return PassaporteFactory.CriarPassaporte(umCliente, umNroDias, umValorBasico, dia, mes, ano, descontos);
        }
    }
}

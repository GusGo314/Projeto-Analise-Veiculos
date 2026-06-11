using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analise_Veiculos_Usados.Models
{
    public class Analise
    {

            public List<Veiculo> VeiculosAnalise { get; set; }
            public Concessionaria Css_Analise{ get; set; }
            public Guid ID_Analise { get; set; }

        public Analise()
        {

            ID_Analise = Guid.NewGuid();
            VeiculosAnalise = new List<Veiculo>();

        }


        public decimal CalculoFipe (decimal ValorVeiculo, decimal ValorFipe)
        {
            decimal valorFinal = (ValorVeiculo / ValorFipe) * 100;

            return valorFinal;

        }
    }

}


    

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analise_Veiculos_Usados.Models
{
    public class RegistroFipe
    {
      
        public string FabricanteFipe { get; set; }
        public string ModeloFipe { get; set; }
        public string VersaoFipe { get; set; }
        public int AnoFabricacaoFipe { get; set; }
        public int AnoModeloFipe { get; set; }
        public string CombustivelFipe { get; set; }
        public decimal ValorFipe { get; set; }
        public string CodFipeInput { get; set; }

        public string PlacaInput { get; set; }

    }
}

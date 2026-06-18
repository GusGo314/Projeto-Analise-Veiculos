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
             
            public class DadosAnalise
        {

            public string BUCanalise { get; set; }
            public List<string> OrigemAnalise = new List<string>();
            public string CodFipeAnalise { get; set; }
            public decimal ValorFipe { get; set; }
            public DateTime DataReferencia { get; set; }
            public string FabricanteAnalise { get; set; }
            public string ModeloAnalise { get; set; }
            public string VersaoAnalise { get; set; }
            public int AnoModeloAnalise { get; set; }
            public string CombustivelAnalise { get; set; }
            public int IdadeVeiculo { get; set; }
            public decimal PorcentagemFipe { get; set; }
            public bool VerificacaoTestDrive { get; set; }
            public string Observacoes { get; set;}


        }

            public List<DadosAnalise> DadosLista { get; set; } // lista fonte dos dados da segunda grid //
       
       

           
        public Analise()
        {

            ID_Analise = Guid.NewGuid();
            VeiculosAnalise = new List<Veiculo>();
            DadosLista = new List<DadosAnalise>();
        }

        

        public decimal CalculoFipe (decimal ValorVeiculo, decimal ValorFipe)
        {
            decimal valorFinal = (ValorVeiculo / ValorFipe) * 100;

            return valorFinal;

        }
    }

}


    

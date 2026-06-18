using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                            // ARQUIVO DE ESTRUTURAÇÃO DA CLASSE VEICULO //
namespace Analise_Veiculos_Usados.Models
{
    public class Veiculo
    {
        public string CNPJOrigem { get; set; }
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public string Versao { get; set; }
        public int AnoFabricacao { get; set; }
        public int AnoModelo { get; set; }
        public string Combustivel { get; set; }
        public string Placa { get; set; }
        public string Chassi { get; set; }
        public string NotaFiscal { get; set; }
        public DateTime DataNF { get; set; }
        public decimal ValorNF { get; set; }
        public string CodFipe { get; set; }


    }   
 
}

using Analise_Veiculos_Usados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
                                               // ARQUIVO DA CLASSE PARA LEITURA DO EXCEL //

namespace Analise_Veiculos_Usados.Helpers
{
    public class ExcelHelper // classe que possui a função de leitura de um arquivo excel
    {
        public List<Veiculo> LeitorExcel(string caminho) {

            List<Veiculo> ListaRetorno = new List<Veiculo>();

            var workbook = new XLWorkbook(caminho); // XLWorkbook pra pegar um arquivo excel inteiro
            var planilha = workbook.Worksheet(1); // workbook.Worksheet(x) pra pegar a pagina x do excel.
            
            foreach ( var row in planilha.RowsUsed())
            {
                if (row.RowNumber() == 1) continue;
              
                    Veiculo inputVeiculo = new Veiculo();

                    inputVeiculo.Fabricante = row.Cell(2).GetValue<string>(); // sintaxe diz algo como: "pegue o valor da celula 2  //
                    inputVeiculo.Modelo = row.Cell(3).GetValue<string>();     //daquela row que está selecionada no foreach, em     //
                    inputVeiculo.Versao = row.Cell(4).GetValue<string>();     //formato <string> e atribua ao

                    var Anoinput = row.Cell(5).GetValue<string>();
                      if(Anoinput.Length > 4)
                         { 
                           var AnoOutput = Anoinput.Substring(Anoinput.Length - 4); // para formatar o valor Ano/Ano //
                           inputVeiculo.AnoModelo = int.Parse(AnoOutput);

                         }
                       else {
                      inputVeiculo.AnoModelo = int.Parse(Anoinput);
                         }

                    inputVeiculo.Placa = row.Cell(7).GetValue<string>();
                    inputVeiculo.ValorNF = row.Cell(10).GetValue<decimal>();

                    ListaRetorno.Add(inputVeiculo);

                
                
            }


            

            




            return ListaRetorno;
        
        }

    }
}

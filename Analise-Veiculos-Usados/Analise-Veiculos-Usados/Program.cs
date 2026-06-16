using System;
using Analise_Veiculos_Usados.Helpers;
using Analise_Veiculos_Usados.Models;
using System.Windows.Forms;
namespace Analise_Veiculos_Usados
    
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
             ApplicationConfiguration.Initialize(); 
             Application.Run(new Form1()); 




            Console.WriteLine("Teste1");
            

            var Helper = new ExcelHelper(); // declara a classe que possui o metodo de leitura de planilha //
            var analise = new Analise();
            
            List<Veiculo> Lista = Helper.LeitorExcel("C:\\TestePlanilha\\Teste.xlsx");

            analise.VeiculosAnalise = Lista;
            

            Console.WriteLine("|| CNPJ || FABRICANTE || MODELO || VERSÃO || ANO || COMBUSTIVEL || PLACA || CHASSI || NOTA FISCAL || DATA NOTA || VALOR NF ||");

            foreach (Veiculo x in Lista)
            {
             Console.WriteLine($"|| {x.CNPJOrigem}|| {x.Fabricante} || {x.Modelo} ||  {x.Versao} || {x.AnoModelo} || {x.Combustivel} || {x.Placa} || {x.Chassi} || {x.NotaFiscal} || {x.DataNF} || {x.ValorNF} ||");
                

            }

            Console.WriteLine("");
            Console.WriteLine("Análise dos valores: ");
            decimal valorTeste = 40000; // valor Fipe fixo para teste de calculo, definir depois uma lista Fipe para manipulação//
            foreach(Veiculo x in Lista)
            {
                decimal relacaoFipe = analise.CalculoFipe(x.ValorNF, valorTeste);

                Console.WriteLine($" {x.Fabricante}  {x.Modelo}  {x.Versao}  {x.AnoModelo} {relacaoFipe}%");




            }





        }
    }
}
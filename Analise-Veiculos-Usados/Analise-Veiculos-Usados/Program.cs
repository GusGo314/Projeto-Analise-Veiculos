using System;
using Analise_Veiculos_Usados.Helpers;
using Analise_Veiculos_Usados.Models;
namespace Analise_Veiculos_Usados
    
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            // ApplicationConfiguration.Initialize(); IMPORTANTE, DESCOMENTAR DEPOIS
            // Application.Run(new Form1()); - IMPORTANTE, DESCOMENTAR DEPOIS




            Console.WriteLine("Teste");
            

            var Helper = new ExcelHelper(); // declara a classe que possui o metodo de leitura de planilha //

            
            List<Veiculo> Lista = Helper.LeitorExcel("C:\\TestePlanilha\\Teste.xlsx");
            
            foreach (Veiculo x in Lista)
            {
             Console.WriteLine($"{x.Fabricante} {x.Modelo} {x.Versao} do ano: {x.AnoModelo} Placa: {x.Placa} e valor {x.ValorNF}");
                

            }

            


        }
    }
}
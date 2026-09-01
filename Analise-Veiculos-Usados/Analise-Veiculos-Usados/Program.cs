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



           
     




        }
    }
}
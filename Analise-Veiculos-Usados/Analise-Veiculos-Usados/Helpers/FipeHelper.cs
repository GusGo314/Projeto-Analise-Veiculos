using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Analise_Veiculos_Usados.Models;
using System.Text.Json.Serialization;

namespace Analise_Veiculos_Usados.Helpers
{
    public class FipeHelper
    {

        public List <RegistroFipe> LeitorVeiculosInput()
        {
            string CaminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database.json");

            string JsonOutput = File.ReadAllText(CaminhoArquivo);

            List<RegistroFipe> Lista = JsonSerializer.Deserialize<List<RegistroFipe>> (JsonOutput);

            return Lista;


        }
        List<RegistroFipe> _Registros;

        public FipeHelper() 
        {

           _Registros  = LeitorVeiculosInput();



        }


        public RegistroFipe PesquisaPlaca (string placa)
        {
            RegistroFipe Retorno = null;


            foreach (RegistroFipe x in _Registros)
            {
                if (x.PlacaInput == placa)
                {
                    Retorno = x;
                    break;


                }
                


            }

            return Retorno;


        }



    }


   
}

using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analise_Veiculos_Usados.Models
{
	public class Concessionaria
	{
        private string _nome;
        private string _CNPJ;
        private List<Analise> _Lista_Analises;
        private bool _eFIAT;
        private bool _eJEEP;
        private string _brand;
        private string _codigoBUC;


        public int contadorAnalises { get => _Lista_Analises.Count; }



        public bool EFIAT
        {
            get => _eFIAT;
            set
            {
                _eFIAT = value;
                if (value) _brand = "FIAT"; 
            }
        }

        public bool EJEEP
        {
            get => _eJEEP;
            set
            {
                _eJEEP = value;
                if (value) _brand = "JEEP";
            }
        }





        public string Brand { get => this._brand; }
                
        public string Codigo { get => this._codigoBUC; set { if (value.Length == 6) _codigoBUC = value; } }

        public string Nome { get => this._nome; set { if (value.Length >= 3) this._nome = value; } }
        public string CNPJ {

            get { return this._CNPJ; }

            set { if (value.Length == 18) _CNPJ = value; }
       }

      


        public Concessionaria()
		{
           
			_Lista_Analises = new List<Analise>();
      
			
		}

		
	}

	


}	
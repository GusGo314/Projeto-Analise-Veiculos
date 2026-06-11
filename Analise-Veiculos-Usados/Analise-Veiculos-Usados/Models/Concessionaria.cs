using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analise_Veiculos_Usados.Models
{
	public class Concessionaria
	{
		public string nome { get; set; }
		public class BUC
		{
			public string Brand { get; set; }
			public string Codigo { get; set; }



		}
		public string CNPJ { get; set; }

		public List<Analise> Lista_Analises { get; set; }
		
		public Concessionaria()
		{

			Lista_Analises = new List<Analise>();


		}

	}

	


}	
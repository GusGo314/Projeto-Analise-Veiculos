using DocumentFormat.OpenXml.Drawing.Diagrams;
using Analise_Veiculos_Usados.Helpers;
using Analise_Veiculos_Usados.Models;
using DocumentFormat.OpenXml.Wordprocessing;
namespace Analise_Veiculos_Usados
{
    public partial class Form1 : Form
    {
        public List<Veiculo> InputVeiculos = new List<Veiculo>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnCarregarPlanilha_Click(object sender, EventArgs e)
        {
            var RetornoDialog = openFileDialog1.ShowDialog();
            
            if (RetornoDialog == DialogResult.OK){
                ExcelHelper Leitor = new ExcelHelper();
                

                InputVeiculos = Leitor.LeitorExcel(openFileDialog1.FileName);
                planilhaAnalise.DataSource = InputVeiculos;


            }

            else if(RetornoDialog == DialogResult.Cancel)
            {




            }

            
            


            

        }

        private void planilhaAnalise_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
           
        }
    }
}

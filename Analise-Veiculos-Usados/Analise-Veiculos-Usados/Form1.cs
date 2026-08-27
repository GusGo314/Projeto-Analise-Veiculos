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
            planilhaAnalise.AutoGenerateColumns = false;
        }

        private void BtnCarregarPlanilha_Click(object sender, EventArgs e)
        {
            var RetornoDialog = openFileDialog1.ShowDialog();
           
                if (RetornoDialog == DialogResult.OK)
                {

                try 
                {
                    ExcelHelper Leitor = new ExcelHelper();
                    InputVeiculos = Leitor.LeitorExcel(openFileDialog1.FileName);
                    planilhaAnalise.DataSource = InputVeiculos;

                }

                catch (Exception ex)
                {

                    MessageBox.Show($"Não foi possivel realizar a leitura do arquivo");

                    File.AppendAllText("C:\\TestePlanilha\\Log.txt", $"{DateTime.Now} {ex.Message}\n");



                }
                Analise analiseAtual = new Analise();

                    planilhaAnaliseDados.DataSource = analiseAtual.DadosLista;
                    decimal valorTotal = 0;

                    FipeHelper Comparador = new FipeHelper();


                    foreach (Veiculo x in InputVeiculos)
                    {
                        valorTotal += x.ValorNF;


                    }



                    ValorTotalInput.Text = valorTotal.ToString("C");


                }

                else if (RetornoDialog == DialogResult.Cancel)
                {




                }







          
            }

        private void planilhaAnalise_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {





        }

        private void planilhaAnaliseDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void planilhaAnalise_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Value = e.RowIndex + 1;
            }
        }

       
    }
}

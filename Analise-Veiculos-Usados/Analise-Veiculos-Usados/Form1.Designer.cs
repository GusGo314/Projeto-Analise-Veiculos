namespace Analise_Veiculos_Usados
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            planilhaAnalise = new DataGridView();
            ColunaItem = new DataGridViewTextBoxColumn();
            ColunaCNPJ = new DataGridViewTextBoxColumn();
            ColunaFabricante = new DataGridViewTextBoxColumn();
            ColunaModelo = new DataGridViewTextBoxColumn();
            ColunaVersao = new DataGridViewTextBoxColumn();
            ColunaAnos = new DataGridViewTextBoxColumn();
            ColunaCombustivel = new DataGridViewTextBoxColumn();
            ColunaPlaca = new DataGridViewTextBoxColumn();
            ColunaChassi = new DataGridViewTextBoxColumn();
            ColunaNF = new DataGridViewTextBoxColumn();
            ColunaDataNF = new DataGridViewTextBoxColumn();
            ColunaValor = new DataGridViewTextBoxColumn();
            BtnCarregarPlanilha = new Button();
            openFileDialog1 = new OpenFileDialog();
            planilhaAnaliseDados = new DataGridView();
            ValorTotal = new Label();
            BoxValorTotal = new GroupBox();
            ValorTotalInput = new Label();
            botaoNovoForms = new Button();
            ((System.ComponentModel.ISupportInitialize)planilhaAnalise).BeginInit();
            ((System.ComponentModel.ISupportInitialize)planilhaAnaliseDados).BeginInit();
            BoxValorTotal.SuspendLayout();
            SuspendLayout();
            // 
            // planilhaAnalise
            // 
            planilhaAnalise.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            planilhaAnalise.Columns.AddRange(new DataGridViewColumn[] { ColunaItem, ColunaCNPJ, ColunaFabricante, ColunaModelo, ColunaVersao, ColunaAnos, ColunaCombustivel, ColunaPlaca, ColunaChassi, ColunaNF, ColunaDataNF, ColunaValor });
            planilhaAnalise.Location = new Point(12, 74);
            planilhaAnalise.Name = "planilhaAnalise";
            planilhaAnalise.Size = new Size(450, 246);
            planilhaAnalise.TabIndex = 0;
            planilhaAnalise.CellFormatting += planilhaAnalise_CellFormatting;
            // 
            // ColunaItem
            // 
            ColunaItem.HeaderText = "Item";
            ColunaItem.Name = "ColunaItem";
            // 
            // ColunaCNPJ
            // 
            ColunaCNPJ.DataPropertyName = "CNPJOrigem";
            ColunaCNPJ.HeaderText = "CNPJ";
            ColunaCNPJ.Name = "ColunaCNPJ";
            ColunaCNPJ.ReadOnly = true;
            // 
            // ColunaFabricante
            // 
            ColunaFabricante.DataPropertyName = "Fabricante";
            ColunaFabricante.HeaderText = "Fabricante";
            ColunaFabricante.Name = "ColunaFabricante";
            ColunaFabricante.ReadOnly = true;
            // 
            // ColunaModelo
            // 
            ColunaModelo.DataPropertyName = "Modelo";
            ColunaModelo.HeaderText = "Modelo";
            ColunaModelo.Name = "ColunaModelo";
            ColunaModelo.ReadOnly = true;
            // 
            // ColunaVersao
            // 
            ColunaVersao.DataPropertyName = "Versao";
            ColunaVersao.HeaderText = "Versão";
            ColunaVersao.Name = "ColunaVersao";
            ColunaVersao.ReadOnly = true;
            // 
            // ColunaAnos
            // 
            ColunaAnos.DataPropertyName = "AnoModelo";
            ColunaAnos.HeaderText = "AnoMod";
            ColunaAnos.Name = "ColunaAnos";
            ColunaAnos.ReadOnly = true;
            // 
            // ColunaCombustivel
            // 
            ColunaCombustivel.DataPropertyName = "Combustivel";
            ColunaCombustivel.HeaderText = "Combustivel";
            ColunaCombustivel.Name = "ColunaCombustivel";
            ColunaCombustivel.ReadOnly = true;
            // 
            // ColunaPlaca
            // 
            ColunaPlaca.DataPropertyName = "Placa";
            ColunaPlaca.HeaderText = "Placa";
            ColunaPlaca.Name = "ColunaPlaca";
            ColunaPlaca.ReadOnly = true;
            // 
            // ColunaChassi
            // 
            ColunaChassi.DataPropertyName = "Chassi";
            ColunaChassi.HeaderText = "Chassi";
            ColunaChassi.Name = "ColunaChassi";
            ColunaChassi.ReadOnly = true;
            // 
            // ColunaNF
            // 
            ColunaNF.DataPropertyName = "NotaFiscal";
            ColunaNF.HeaderText = "NotaFiscal";
            ColunaNF.Name = "ColunaNF";
            ColunaNF.ReadOnly = true;
            // 
            // ColunaDataNF
            // 
            ColunaDataNF.DataPropertyName = "DataNF";
            ColunaDataNF.HeaderText = "Data NF";
            ColunaDataNF.Name = "ColunaDataNF";
            ColunaDataNF.ReadOnly = true;
            // 
            // ColunaValor
            // 
            ColunaValor.DataPropertyName = "ValorNF";
            ColunaValor.HeaderText = "Valor NF";
            ColunaValor.Name = "ColunaValor";
            ColunaValor.ReadOnly = true;
            // 
            // BtnCarregarPlanilha
            // 
            BtnCarregarPlanilha.Location = new Point(12, 34);
            BtnCarregarPlanilha.Name = "BtnCarregarPlanilha";
            BtnCarregarPlanilha.Size = new Size(154, 34);
            BtnCarregarPlanilha.TabIndex = 1;
            BtnCarregarPlanilha.Text = "Carregar Planilha";
            BtnCarregarPlanilha.UseVisualStyleBackColor = true;
            BtnCarregarPlanilha.Click += BtnCarregarPlanilha_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // planilhaAnaliseDados
            // 
            planilhaAnaliseDados.AllowUserToAddRows = false;
            planilhaAnaliseDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            planilhaAnaliseDados.Location = new Point(468, 74);
            planilhaAnaliseDados.Name = "planilhaAnaliseDados";
            planilhaAnaliseDados.Size = new Size(453, 245);
            planilhaAnaliseDados.TabIndex = 2;
            // 
            // ValorTotal
            // 
            ValorTotal.AutoSize = true;
            ValorTotal.ForeColor = SystemColors.ControlText;
            ValorTotal.Location = new Point(0, 0);
            ValorTotal.Name = "ValorTotal";
            ValorTotal.Size = new Size(62, 15);
            ValorTotal.TabIndex = 3;
            ValorTotal.Text = "Valor Total";
            // 
            // BoxValorTotal
            // 
            BoxValorTotal.Controls.Add(ValorTotalInput);
            BoxValorTotal.Controls.Add(ValorTotal);
            BoxValorTotal.Location = new Point(311, 336);
            BoxValorTotal.Name = "BoxValorTotal";
            BoxValorTotal.Size = new Size(151, 40);
            BoxValorTotal.TabIndex = 4;
            BoxValorTotal.TabStop = false;
            // 
            // ValorTotalInput
            // 
            ValorTotalInput.AutoSize = true;
            ValorTotalInput.Location = new Point(52, 19);
            ValorTotalInput.Name = "ValorTotalInput";
            ValorTotalInput.Size = new Size(34, 15);
            ValorTotalInput.TabIndex = 4;
            ValorTotalInput.Text = "         \r\n";
            // 
            // botaoNovoForms
            // 
            botaoNovoForms.Location = new Point(12, 0);
            botaoNovoForms.Name = "botaoNovoForms";
            botaoNovoForms.Size = new Size(88, 28);
            botaoNovoForms.TabIndex = 5;
            botaoNovoForms.Text = "Novo";
            botaoNovoForms.UseVisualStyleBackColor = true;
            botaoNovoForms.Click += botaoNovoForms_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 461);
            Controls.Add(botaoNovoForms);
            Controls.Add(BoxValorTotal);
            Controls.Add(planilhaAnaliseDados);
            Controls.Add(BtnCarregarPlanilha);
            Controls.Add(planilhaAnalise);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)planilhaAnalise).EndInit();
            ((System.ComponentModel.ISupportInitialize)planilhaAnaliseDados).EndInit();
            BoxValorTotal.ResumeLayout(false);
            BoxValorTotal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView planilhaAnalise;
        private Button BtnCarregarPlanilha;
        private OpenFileDialog openFileDialog1;
        private DataGridView planilhaAnaliseDados;
        private DataGridViewTextBoxColumn ColunaItem;
        private DataGridViewTextBoxColumn ColunaCNPJ;
        private DataGridViewTextBoxColumn ColunaFabricante;
        private DataGridViewTextBoxColumn ColunaModelo;
        private DataGridViewTextBoxColumn ColunaVersao;
        private DataGridViewTextBoxColumn ColunaAnos;
        private DataGridViewTextBoxColumn ColunaCombustivel;
        private DataGridViewTextBoxColumn ColunaPlaca;
        private DataGridViewTextBoxColumn ColunaChassi;
        private DataGridViewTextBoxColumn ColunaNF;
        private DataGridViewTextBoxColumn ColunaDataNF;
        private DataGridViewTextBoxColumn ColunaValor;
        private Label ValorTotal;
        private GroupBox BoxValorTotal;
        private Label ValorTotalInput;
        private Button botaoNovoForms;
    }
}

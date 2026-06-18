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
        private void InitializeComponent()
        {
            planilhaAnalise = new DataGridView();
            BtnCarregarPlanilha = new Button();
            openFileDialog1 = new OpenFileDialog();
            planilhaAnaliseDados = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)planilhaAnalise).BeginInit();
            ((System.ComponentModel.ISupportInitialize)planilhaAnaliseDados).BeginInit();
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
            planilhaAnalise.CellContentClick += planilhaAnalise_CellContentClick;
            planilhaAnalise.AutoGenerateColumns = false;
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
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // planilhaAnaliseDados
            // 
            planilhaAnaliseDados.AllowUserToAddRows = false;
            planilhaAnaliseDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            planilhaAnaliseDados.Location = new Point(468, 74);
            planilhaAnaliseDados.Name = "planilhaAnaliseDados";
            planilhaAnaliseDados.Size = new Size(453, 245);
            planilhaAnaliseDados.TabIndex = 2;
            planilhaAnaliseDados.CellContentClick += planilhaAnaliseDados_CellContentClick;
            // 
            // ColunaItem
            // 
            ColunaItem.HeaderText = "Item";
            ColunaItem.Name = "ColunaItem";
            ColunaItem.ReadOnly = true;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 461);
            Controls.Add(planilhaAnaliseDados);
            Controls.Add(BtnCarregarPlanilha);
            Controls.Add(planilhaAnalise);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)planilhaAnalise).EndInit();
            ((System.ComponentModel.ISupportInitialize)planilhaAnaliseDados).EndInit();
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
    }
}

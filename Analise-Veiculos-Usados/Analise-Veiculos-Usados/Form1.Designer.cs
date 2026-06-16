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
            components = new System.ComponentModel.Container();
            planilhaAnalise = new DataGridView();
            BtnCarregarPlanilha = new Button();
            veiculosAnaliseBindingSource = new BindingSource(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)planilhaAnalise).BeginInit();
            ((System.ComponentModel.ISupportInitialize)veiculosAnaliseBindingSource).BeginInit();
            SuspendLayout();
            // 
            // planilhaAnalise
            // 
            planilhaAnalise.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            planilhaAnalise.Location = new Point(12, 41);
            planilhaAnalise.Name = "planilhaAnalise";
            planilhaAnalise.Size = new Size(706, 246);
            planilhaAnalise.TabIndex = 0;
            planilhaAnalise.CellContentClick += planilhaAnalise_CellContentClick;
            // 
            // BtnCarregarPlanilha
            // 
            BtnCarregarPlanilha.Location = new Point(12, 1);
            BtnCarregarPlanilha.Name = "BtnCarregarPlanilha";
            BtnCarregarPlanilha.Size = new Size(154, 34);
            BtnCarregarPlanilha.TabIndex = 1;
            BtnCarregarPlanilha.Text = "Carregar Planilha";
            BtnCarregarPlanilha.UseVisualStyleBackColor = true;
            BtnCarregarPlanilha.Click += BtnCarregarPlanilha_Click;
            // 
            // veiculosAnaliseBindingSource
            // 
            veiculosAnaliseBindingSource.DataMember = "VeiculosAnalise";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 461);
            Controls.Add(BtnCarregarPlanilha);
            Controls.Add(planilhaAnalise);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)planilhaAnalise).EndInit();
            ((System.ComponentModel.ISupportInitialize)veiculosAnaliseBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView planilhaAnalise;
        private Button BtnCarregarPlanilha;
        private BindingSource veiculosAnaliseBindingSource;
        private OpenFileDialog openFileDialog1;
    }
}

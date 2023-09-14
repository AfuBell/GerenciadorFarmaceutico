namespace GerenciadorFarmaceutico.Forms
{
    partial class CadastrarProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            PanelMed = new Panel();
            TBDosagem = new TextBox();
            TBNumRegistroAnvisa = new TextBox();
            label8 = new Label();
            label10 = new Label();
            TBComposicao = new TextBox();
            label9 = new Label();
            TBValor = new TextBox();
            label6 = new Label();
            TBCodigoDeBarras = new TextBox();
            label7 = new Label();
            DatePickerVencimento = new DateTimePicker();
            label5 = new Label();
            TBLote = new TextBox();
            label2 = new Label();
            DatePickerFabricacao = new DateTimePicker();
            TBMarca = new TextBox();
            TBDescricao = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            CBTypePicker = new ComboBox();
            BCadastroProduto = new Button();
            panel1.SuspendLayout();
            PanelMed.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(PanelMed);
            panel1.Controls.Add(TBValor);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(TBCodigoDeBarras);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(DatePickerVencimento);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(TBLote);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(DatePickerFabricacao);
            panel1.Controls.Add(TBMarca);
            panel1.Controls.Add(TBDescricao);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(CBTypePicker);
            panel1.Location = new Point(3, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(686, 340);
            panel1.TabIndex = 4;
            // 
            // PanelMed
            // 
            PanelMed.Controls.Add(TBDosagem);
            PanelMed.Controls.Add(TBNumRegistroAnvisa);
            PanelMed.Controls.Add(label8);
            PanelMed.Controls.Add(label10);
            PanelMed.Controls.Add(TBComposicao);
            PanelMed.Controls.Add(label9);
            PanelMed.Location = new Point(0, 232);
            PanelMed.Name = "PanelMed";
            PanelMed.Size = new Size(679, 96);
            PanelMed.TabIndex = 20;
            PanelMed.Visible = false;
            // 
            // TBDosagem
            // 
            TBDosagem.Location = new Point(167, 61);
            TBDosagem.Name = "TBDosagem";
            TBDosagem.Size = new Size(509, 23);
            TBDosagem.TabIndex = 26;
            // 
            // TBNumRegistroAnvisa
            // 
            TBNumRegistroAnvisa.Location = new Point(167, 3);
            TBNumRegistroAnvisa.Name = "TBNumRegistroAnvisa";
            TBNumRegistroAnvisa.Size = new Size(509, 23);
            TBNumRegistroAnvisa.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(10, 63);
            label8.Name = "label8";
            label8.Padding = new Padding(6, 0, 6, 0);
            label8.Size = new Size(91, 21);
            label8.TabIndex = 25;
            label8.Text = "Dosagem:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(10, 5);
            label10.Name = "label10";
            label10.Padding = new Padding(6, 0, 6, 0);
            label10.Size = new Size(164, 21);
            label10.TabIndex = 21;
            label10.Text = "NumRegistroAnvisa:";
            // 
            // TBComposicao
            // 
            TBComposicao.Location = new Point(167, 32);
            TBComposicao.Name = "TBComposicao";
            TBComposicao.Size = new Size(509, 23);
            TBComposicao.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(10, 34);
            label9.Name = "label9";
            label9.Padding = new Padding(6, 0, 6, 0);
            label9.Size = new Size(111, 21);
            label9.TabIndex = 22;
            label9.Text = "Composição:";
            // 
            // TBValor
            // 
            TBValor.Location = new Point(167, 206);
            TBValor.Name = "TBValor";
            TBValor.Size = new Size(512, 23);
            TBValor.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(13, 208);
            label6.Name = "label6";
            label6.Padding = new Padding(6, 0, 6, 0);
            label6.Size = new Size(61, 21);
            label6.TabIndex = 18;
            label6.Text = "Valor:";
            // 
            // TBCodigoDeBarras
            // 
            TBCodigoDeBarras.Location = new Point(167, 177);
            TBCodigoDeBarras.Name = "TBCodigoDeBarras";
            TBCodigoDeBarras.Size = new Size(512, 23);
            TBCodigoDeBarras.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(13, 179);
            label7.Name = "label7";
            label7.Padding = new Padding(6, 0, 6, 0);
            label7.Size = new Size(138, 21);
            label7.TabIndex = 16;
            label7.Text = "CodigoDeBarras:";
            // 
            // DatePickerVencimento
            // 
            DatePickerVencimento.Location = new Point(167, 148);
            DatePickerVencimento.Name = "DatePickerVencimento";
            DatePickerVencimento.Size = new Size(192, 23);
            DatePickerVencimento.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(13, 150);
            label5.Name = "label5";
            label5.Padding = new Padding(6, 0, 6, 0);
            label5.Size = new Size(107, 21);
            label5.TabIndex = 14;
            label5.Text = "Vencimento:";
            // 
            // TBLote
            // 
            TBLote.Location = new Point(167, 90);
            TBLote.Name = "TBLote";
            TBLote.Size = new Size(512, 23);
            TBLote.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 92);
            label2.Name = "label2";
            label2.Padding = new Padding(6, 0, 6, 0);
            label2.Size = new Size(55, 21);
            label2.TabIndex = 12;
            label2.Text = "Lote:";
            // 
            // DatePickerFabricacao
            // 
            DatePickerFabricacao.Location = new Point(167, 119);
            DatePickerFabricacao.Name = "DatePickerFabricacao";
            DatePickerFabricacao.Size = new Size(192, 23);
            DatePickerFabricacao.TabIndex = 11;
            // 
            // TBMarca
            // 
            TBMarca.Location = new Point(167, 61);
            TBMarca.Name = "TBMarca";
            TBMarca.Size = new Size(512, 23);
            TBMarca.TabIndex = 8;
            // 
            // TBDescricao
            // 
            TBDescricao.Location = new Point(167, 32);
            TBDescricao.Name = "TBDescricao";
            TBDescricao.Size = new Size(512, 23);
            TBDescricao.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(13, 63);
            label4.Name = "label4";
            label4.Padding = new Padding(6, 0, 6, 0);
            label4.Size = new Size(68, 21);
            label4.TabIndex = 6;
            label4.Text = "Marca:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(13, 121);
            label3.Name = "label3";
            label3.Padding = new Padding(6, 0, 6, 0);
            label3.Size = new Size(98, 21);
            label3.TabIndex = 5;
            label3.Text = "Fabricação:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 34);
            label1.Name = "label1";
            label1.Padding = new Padding(6, 0, 6, 0);
            label1.Size = new Size(92, 21);
            label1.TabIndex = 3;
            label1.Text = "Descrição:";
            // 
            // CBTypePicker
            // 
            CBTypePicker.FormattingEnabled = true;
            CBTypePicker.Items.AddRange(new object[] { "ProdutoComum", "Medicamento", "MedicamentoControlado", "MedicamentoInjetavel" });
            CBTypePicker.Location = new Point(13, 3);
            CBTypePicker.Name = "CBTypePicker";
            CBTypePicker.Size = new Size(121, 23);
            CBTypePicker.TabIndex = 2;
            CBTypePicker.Text = "Qual?";
            CBTypePicker.SelectedIndexChanged += CBTypePicker_SelectedIndexChanged;
            // 
            // BCadastroProduto
            // 
            BCadastroProduto.Location = new Point(525, 358);
            BCadastroProduto.Name = "BCadastroProduto";
            BCadastroProduto.Size = new Size(154, 23);
            BCadastroProduto.TabIndex = 5;
            BCadastroProduto.Text = "Cadastro de Produto";
            BCadastroProduto.UseVisualStyleBackColor = true;
            BCadastroProduto.Click += BCadastroProduto_Click;
            // 
            // CadastrarProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 392);
            Controls.Add(BCadastroProduto);
            Controls.Add(panel1);
            Name = "CadastrarProduto";
            Text = "CadastrarProduto";
            Load += CadastrarProduto_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            PanelMed.ResumeLayout(false);
            PanelMed.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DateTimePicker DatePickerFabricacao;
        private TextBox TBMarca;
        private TextBox TBDescricao;
        private Label label4;
        private Label label3;
        private Label label1;
        private ComboBox CBTypePicker;
        private Panel PanelMed;
        private TextBox TBDosagem;
        private TextBox TBNumRegistroAnvisa;
        private Label label8;
        private Label label10;
        private TextBox TBComposicao;
        private Label label9;
        private TextBox TBValor;
        private Label label6;
        private TextBox TBCodigoDeBarras;
        private Label label7;
        private DateTimePicker DatePickerVencimento;
        private Label label5;
        private TextBox TBLote;
        private Label label2;
        private Button BCadastroProduto;
    }
}
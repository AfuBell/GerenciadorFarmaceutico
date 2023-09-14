namespace GerenciadorFarmaceutico.Forms
{
    partial class CadastrarVenda
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
            CBFuncionarios = new ComboBox();
            label1 = new Label();
            TBCpf = new TextBox();
            label2 = new Label();
            DTDataCompra = new DateTimePicker();
            label3 = new Label();
            DataHolder = new ListBox();
            BIniciarVenda = new Button();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            BAdicionarItem = new Button();
            label5 = new Label();
            label4 = new Label();
            NumericPad = new NumericUpDown();
            CBProdutos = new ComboBox();
            PainelItemVenda = new Panel();
            BTerminarVenda = new Button();
            label6 = new Label();
            ListaValorTotal = new ListBox();
            Desconto = new Label();
            ListaDesconto = new ListBox();
            label8 = new Label();
            ListaValorProdutos = new ListBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericPad).BeginInit();
            PainelItemVenda.SuspendLayout();
            SuspendLayout();
            // 
            // CBFuncionarios
            // 
            CBFuncionarios.FormattingEnabled = true;
            CBFuncionarios.Location = new Point(101, 8);
            CBFuncionarios.Name = "CBFuncionarios";
            CBFuncionarios.Size = new Size(275, 23);
            CBFuncionarios.TabIndex = 0;
            CBFuncionarios.SelectedIndexChanged += CBFuncionarios_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 11);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 1;
            label1.Text = "Funcionario:";
            // 
            // TBCpf
            // 
            TBCpf.Location = new Point(101, 37);
            TBCpf.Name = "TBCpf";
            TBCpf.Size = new Size(275, 23);
            TBCpf.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 40);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Cpf Cliente:";
            // 
            // DTDataCompra
            // 
            DTDataCompra.Location = new Point(101, 66);
            DTDataCompra.Name = "DTDataCompra";
            DTDataCompra.Size = new Size(273, 23);
            DTDataCompra.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 72);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 5;
            label3.Text = "Data Compra:";
            // 
            // DataHolder
            // 
            DataHolder.FormattingEnabled = true;
            DataHolder.ItemHeight = 15;
            DataHolder.Location = new Point(398, 15);
            DataHolder.Name = "DataHolder";
            DataHolder.Size = new Size(390, 379);
            DataHolder.TabIndex = 6;
            
            // 
            // BIniciarVenda
            // 
            BIniciarVenda.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BIniciarVenda.Location = new Point(9, 105);
            BIniciarVenda.Name = "BIniciarVenda";
            BIniciarVenda.Size = new Size(365, 31);
            BIniciarVenda.TabIndex = 7;
            BIniciarVenda.Text = "Confirmar dados e iniciar venda";
            BIniciarVenda.UseVisualStyleBackColor = true;
            BIniciarVenda.Click += BIniciarVenda_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BIniciarVenda);
            panel1.Controls.Add(CBFuncionarios);
            panel1.Controls.Add(TBCpf);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(DTDataCompra);
            panel1.Location = new Point(3, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 142);
            panel1.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BAdicionarItem);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(NumericPad);
            groupBox1.Controls.Add(CBProdutos);
            groupBox1.Location = new Point(9, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(377, 106);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adicionar Item";
            // 
            // BAdicionarItem
            // 
            BAdicionarItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BAdicionarItem.Location = new Point(234, 69);
            BAdicionarItem.Name = "BAdicionarItem";
            BAdicionarItem.Size = new Size(137, 31);
            BAdicionarItem.TabIndex = 8;
            BAdicionarItem.Text = "Adicionar item";
            BAdicionarItem.UseVisualStyleBackColor = true;
            BAdicionarItem.Click += BAdicionarItem_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 43);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 11;
            label5.Text = "Quantidade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 15);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 10;
            label4.Text = "Item:";
            // 
            // NumericPad
            // 
            NumericPad.Location = new Point(92, 41);
            NumericPad.Name = "NumericPad";
            NumericPad.Size = new Size(279, 23);
            NumericPad.TabIndex = 9;
            // 
            // CBProdutos
            // 
            CBProdutos.FormattingEnabled = true;
            CBProdutos.Location = new Point(92, 12);
            CBProdutos.Name = "CBProdutos";
            CBProdutos.Size = new Size(279, 23);
            CBProdutos.TabIndex = 8;
            CBProdutos.SelectedIndexChanged += CBProdutos_SelectedIndexChanged;
            // 
            // PainelItemVenda
            // 
            PainelItemVenda.Controls.Add(label8);
            PainelItemVenda.Controls.Add(ListaValorProdutos);
            PainelItemVenda.Controls.Add(Desconto);
            PainelItemVenda.Controls.Add(ListaDesconto);
            PainelItemVenda.Controls.Add(BTerminarVenda);
            PainelItemVenda.Controls.Add(label6);
            PainelItemVenda.Controls.Add(ListaValorTotal);
            PainelItemVenda.Controls.Add(groupBox1);
            PainelItemVenda.Location = new Point(3, 163);
            PainelItemVenda.Name = "PainelItemVenda";
            PainelItemVenda.Size = new Size(389, 231);
            PainelItemVenda.TabIndex = 10;
            PainelItemVenda.Visible = false;
            // 
            // BTerminarVenda
            // 
            BTerminarVenda.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BTerminarVenda.Location = new Point(234, 199);
            BTerminarVenda.Name = "BTerminarVenda";
            BTerminarVenda.Size = new Size(146, 29);
            BTerminarVenda.TabIndex = 13;
            BTerminarVenda.Text = "Terminar venda";
            BTerminarVenda.UseVisualStyleBackColor = true;
            BTerminarVenda.Click += BTerminarVenda_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 174);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 12;
            label6.Text = "Valor final:";
            // 
            // ListaValorTotal
            // 
            ListaValorTotal.FormattingEnabled = true;
            ListaValorTotal.ItemHeight = 15;
            ListaValorTotal.Location = new Point(101, 174);
            ListaValorTotal.Name = "ListaValorTotal";
            ListaValorTotal.Size = new Size(285, 19);
            ListaValorTotal.TabIndex = 11;
            
            // 
            // Desconto
            // 
            Desconto.AutoSize = true;
            Desconto.Location = new Point(19, 149);
            Desconto.Name = "Desconto";
            Desconto.Size = new Size(60, 15);
            Desconto.TabIndex = 15;
            Desconto.Text = "Desconto:";
            // 
            // ListaDesconto
            // 
            ListaDesconto.FormattingEnabled = true;
            ListaDesconto.ItemHeight = 15;
            ListaDesconto.Location = new Point(101, 149);
            ListaDesconto.Name = "ListaDesconto";
            ListaDesconto.Size = new Size(285, 19);
            ListaDesconto.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 124);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 17;
            label8.Text = "Valor total:";
            
            // 
            // ListaValorProdutos
            // 
            ListaValorProdutos.FormattingEnabled = true;
            ListaValorProdutos.ItemHeight = 15;
            ListaValorProdutos.Location = new Point(101, 124);
            ListaValorProdutos.Name = "ListaValorProdutos";
            ListaValorProdutos.Size = new Size(285, 19);
            ListaValorProdutos.TabIndex = 16;
            
            // 
            // CadastrarVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PainelItemVenda);
            Controls.Add(panel1);
            Controls.Add(DataHolder);
            Name = "CadastrarVenda";
            Text = "CadastrarVenda";
            Load += CadastrarVenda_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericPad).EndInit();
            PainelItemVenda.ResumeLayout(false);
            PainelItemVenda.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox CBFuncionarios;
        private Label label1;
        private TextBox TBCpf;
        private Label label2;
        private DateTimePicker DTDataCompra;
        private Label label3;
        private ListBox DataHolder;
        private Button BIniciarVenda;
        private Panel panel1;
        private GroupBox groupBox1;
        private ComboBox CBProdutos;
        private Panel PainelItemVenda;
        private Button BAdicionarItem;
        private Label label5;
        private Label label4;
        private NumericUpDown NumericPad;
        private Button BTerminarVenda;
        private Label label6;
        private ListBox ListaValorTotal;
        private Label Desconto;
        private ListBox ListaDesconto;
        private Label label8;
        private ListBox ListaValorProdutos;
    }
}
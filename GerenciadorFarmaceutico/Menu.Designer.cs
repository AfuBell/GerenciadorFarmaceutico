namespace GerenciadorFarmaceutico
{
    partial class Menu
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
            ListMenu = new TabControl();
            Cadastros = new TabPage();
            BNovoProduto = new Button();
            BNewUser = new Button();
            BNovaVenda = new Button();
            Exibir = new TabPage();
            BListarInjetaveis = new Button();
            BListarControlados = new Button();
            BListarMedicamento = new Button();
            BListarProduto = new Button();
            panel1 = new Panel();
            BListarVendas = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            BListarFuncionarios = new Button();
            BListarClientes = new Button();
            DataHolder = new ListBox();
            B_Sair = new Button();
            ListMenu.SuspendLayout();
            Cadastros.SuspendLayout();
            Exibir.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ListMenu
            // 
            ListMenu.Controls.Add(Cadastros);
            ListMenu.Controls.Add(Exibir);
            ListMenu.Location = new Point(12, 12);
            ListMenu.Name = "ListMenu";
            ListMenu.SelectedIndex = 0;
            ListMenu.Size = new Size(466, 397);
            ListMenu.TabIndex = 0;
            // 
            // Cadastros
            // 
            Cadastros.Controls.Add(BNovoProduto);
            Cadastros.Controls.Add(BNewUser);
            Cadastros.Controls.Add(BNovaVenda);
            Cadastros.Location = new Point(4, 24);
            Cadastros.Name = "Cadastros";
            Cadastros.Padding = new Padding(3);
            Cadastros.Size = new Size(458, 369);
            Cadastros.TabIndex = 0;
            Cadastros.Text = "Cadastros";
            Cadastros.UseVisualStyleBackColor = true;
            Cadastros.Click += Cadastros_Click;
            // 
            // BNovoProduto
            // 
            BNovoProduto.Font = new Font("DejaVu Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BNovoProduto.Location = new Point(6, 57);
            BNovoProduto.Name = "BNovoProduto";
            BNovoProduto.Size = new Size(165, 36);
            BNovoProduto.TabIndex = 2;
            BNovoProduto.Text = "Novo Produto";
            BNovoProduto.UseVisualStyleBackColor = true;
            BNovoProduto.Click += BNovoProduto_Click;
            // 
            // BNewUser
            // 
            BNewUser.Font = new Font("DejaVu Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BNewUser.Location = new Point(6, 111);
            BNewUser.Name = "BNewUser";
            BNewUser.Size = new Size(165, 36);
            BNewUser.TabIndex = 1;
            BNewUser.Text = "Cadastrar User";
            BNewUser.UseVisualStyleBackColor = true;
            BNewUser.Click += BNewUser_Click;
            // 
            // BNovaVenda
            // 
            BNovaVenda.Font = new Font("DejaVu Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BNovaVenda.Location = new Point(6, 6);
            BNovaVenda.Name = "BNovaVenda";
            BNovaVenda.Size = new Size(165, 36);
            BNovaVenda.TabIndex = 0;
            BNovaVenda.Text = "Nova Venda";
            BNovaVenda.UseVisualStyleBackColor = true;
            BNovaVenda.Click += BNovaVenda_Click;
            // 
            // Exibir
            // 
            Exibir.Controls.Add(BListarInjetaveis);
            Exibir.Controls.Add(BListarControlados);
            Exibir.Controls.Add(BListarMedicamento);
            Exibir.Controls.Add(BListarProduto);
            Exibir.Controls.Add(panel1);
            Exibir.Controls.Add(BListarFuncionarios);
            Exibir.Controls.Add(BListarClientes);
            Exibir.Controls.Add(DataHolder);
            Exibir.Location = new Point(4, 24);
            Exibir.Name = "Exibir";
            Exibir.Padding = new Padding(3);
            Exibir.Size = new Size(458, 369);
            Exibir.TabIndex = 2;
            Exibir.Text = "Exibir";
            Exibir.UseVisualStyleBackColor = true;
            // 
            // BListarInjetaveis
            // 
            BListarInjetaveis.Location = new Point(116, 103);
            BListarInjetaveis.Name = "BListarInjetaveis";
            BListarInjetaveis.Size = new Size(87, 41);
            BListarInjetaveis.TabIndex = 7;
            BListarInjetaveis.Text = "Injetaveis";
            BListarInjetaveis.UseVisualStyleBackColor = true;
            BListarInjetaveis.Click += BListarInjetaveis_Click;
            // 
            // BListarControlados
            // 
            BListarControlados.Location = new Point(6, 103);
            BListarControlados.Name = "BListarControlados";
            BListarControlados.Size = new Size(87, 41);
            BListarControlados.TabIndex = 6;
            BListarControlados.Text = "Controlados";
            BListarControlados.UseVisualStyleBackColor = true;
            BListarControlados.Click += BListarControlados_Click;
            // 
            // BListarMedicamento
            // 
            BListarMedicamento.Location = new Point(116, 53);
            BListarMedicamento.Name = "BListarMedicamento";
            BListarMedicamento.Size = new Size(87, 41);
            BListarMedicamento.TabIndex = 5;
            BListarMedicamento.Text = "Medicamentos";
            BListarMedicamento.UseVisualStyleBackColor = true;
            BListarMedicamento.Click += BListarMedicamento_Click;
            // 
            // BListarProduto
            // 
            BListarProduto.Location = new Point(6, 53);
            BListarProduto.Name = "BListarProduto";
            BListarProduto.Size = new Size(87, 41);
            BListarProduto.TabIndex = 4;
            BListarProduto.Text = "Produtos";
            BListarProduto.UseVisualStyleBackColor = true;
            BListarProduto.Click += BListarProduto_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(BListarVendas);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(6, 147);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 208);
            panel1.TabIndex = 3;
            // 
            // BListarVendas
            // 
            BListarVendas.Location = new Point(0, 66);
            BListarVendas.Name = "BListarVendas";
            BListarVendas.Size = new Size(194, 28);
            BListarVendas.TabIndex = 4;
            BListarVendas.Text = "Vendas";
            BListarVendas.UseVisualStyleBackColor = true;
            BListarVendas.Click += BListarVendas_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 23);
            textBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(194, 28);
            button2.TabIndex = 2;
            button2.Text = "Procurar cliente por cpf";
            button2.UseVisualStyleBackColor = true;
            // 
            // BListarFuncionarios
            // 
            BListarFuncionarios.Location = new Point(117, 6);
            BListarFuncionarios.Name = "BListarFuncionarios";
            BListarFuncionarios.Size = new Size(87, 41);
            BListarFuncionarios.TabIndex = 2;
            BListarFuncionarios.Text = "Funcionarios";
            BListarFuncionarios.UseVisualStyleBackColor = true;
            BListarFuncionarios.Click += BListarFuncionarios_Click;
            // 
            // BListarClientes
            // 
            BListarClientes.Location = new Point(6, 6);
            BListarClientes.Name = "BListarClientes";
            BListarClientes.Size = new Size(87, 41);
            BListarClientes.TabIndex = 1;
            BListarClientes.Text = "Clientes";
            BListarClientes.UseVisualStyleBackColor = true;
            BListarClientes.Click += BListarClientes_Click;
            // 
            // DataHolder
            // 
            DataHolder.FormattingEnabled = true;
            DataHolder.ItemHeight = 15;
            DataHolder.Location = new Point(210, 6);
            DataHolder.Name = "DataHolder";
            DataHolder.Size = new Size(242, 349);
            DataHolder.TabIndex = 0;
            // 
            // B_Sair
            // 
            B_Sair.Font = new Font("DejaVu Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            B_Sair.Location = new Point(367, 415);
            B_Sair.Name = "B_Sair";
            B_Sair.Size = new Size(111, 36);
            B_Sair.TabIndex = 2;
            B_Sair.Text = "Sair";
            B_Sair.UseVisualStyleBackColor = true;
            B_Sair.Click += B_Sair_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(61, 118, 209);
            ClientSize = new Size(490, 463);
            Controls.Add(B_Sair);
            Controls.Add(ListMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            Text = "Form1";
            Load += Menu_Load;
            ListMenu.ResumeLayout(false);
            Cadastros.ResumeLayout(false);
            Exibir.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl ListMenu;
        private TabPage Cadastros;
        private TabPage Exibir;
        private Button BNovoProduto;
        private Button BNewUser;
        private Button BNovaVenda;
        private Button B_Sair;
        private Button BListarFuncionarios;
        private Button BListarClientes;
        private ListBox DataHolder;
        private Panel panel1;
        private TextBox textBox1;
        private Button button2;
        private Button BListarProduto;
        private Button BListarInjetaveis;
        private Button BListarControlados;
        private Button BListarMedicamento;
        private Button BListarVendas;
    }
}
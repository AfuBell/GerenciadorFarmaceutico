namespace GerenciadorFarmaceutico.Forms
{
    partial class CadastroPessoa
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
            this.B_Sair = new System.Windows.Forms.Button();
            this.BConfirmarCadastro = new System.Windows.Forms.Button();
            this.TB_ClassType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TB_DataNascimento = new System.Windows.Forms.DateTimePicker();
            this.TB_emailORctps = new System.Windows.Forms.TextBox();
            this.TB_Cpf = new System.Windows.Forms.TextBox();
            this.TB_Nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextClassDependent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_Sair
            // 
            this.B_Sair.Location = new System.Drawing.Point(12, 368);
            this.B_Sair.Name = "B_Sair";
            this.B_Sair.Size = new System.Drawing.Size(75, 23);
            this.B_Sair.TabIndex = 0;
            this.B_Sair.Text = "Sair";
            this.B_Sair.UseVisualStyleBackColor = true;
            this.B_Sair.Click += new System.EventHandler(this.B_Sair_Click);
            // 
            // BConfirmarCadastro
            // 
            this.BConfirmarCadastro.Location = new System.Drawing.Point(445, 368);
            this.BConfirmarCadastro.Name = "BConfirmarCadastro";
            this.BConfirmarCadastro.Size = new System.Drawing.Size(75, 23);
            this.BConfirmarCadastro.TabIndex = 1;
            this.BConfirmarCadastro.Text = "Cadastrar";
            this.BConfirmarCadastro.UseVisualStyleBackColor = true;
            this.BConfirmarCadastro.Click += new System.EventHandler(this.BConfirmarCadastro_Click);
            // 
            // TB_ClassType
            // 
            this.TB_ClassType.FormattingEnabled = true;
            this.TB_ClassType.Items.AddRange(new object[] {
            "Cliente",
            "Funcionario"});
            this.TB_ClassType.Location = new System.Drawing.Point(13, 3);
            this.TB_ClassType.Name = "TB_ClassType";
            this.TB_ClassType.Size = new System.Drawing.Size(121, 23);
            this.TB_ClassType.TabIndex = 2;
            this.TB_ClassType.Text = "Qual?";
            this.TB_ClassType.SelectedIndexChanged += new System.EventHandler(this.TB_ClassType_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.TB_DataNascimento);
            this.panel1.Controls.Add(this.TB_emailORctps);
            this.panel1.Controls.Add(this.TB_Cpf);
            this.panel1.Controls.Add(this.TB_Nome);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TextClassDependent);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TB_ClassType);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 350);
            this.panel1.TabIndex = 3;
            // 
            // TB_DataNascimento
            // 
            this.TB_DataNascimento.Location = new System.Drawing.Point(175, 202);
            this.TB_DataNascimento.Name = "TB_DataNascimento";
            this.TB_DataNascimento.Size = new System.Drawing.Size(200, 23);
            this.TB_DataNascimento.TabIndex = 11;
            // 
            // TB_emailORctps
            // 
            this.TB_emailORctps.Location = new System.Drawing.Point(175, 280);
            this.TB_emailORctps.Name = "TB_emailORctps";
            this.TB_emailORctps.Size = new System.Drawing.Size(330, 23);
            this.TB_emailORctps.TabIndex = 10;
            // 
            // TB_Cpf
            // 
            this.TB_Cpf.Location = new System.Drawing.Point(175, 130);
            this.TB_Cpf.Name = "TB_Cpf";
            this.TB_Cpf.Size = new System.Drawing.Size(330, 23);
            this.TB_Cpf.TabIndex = 8;
            // 
            // TB_Nome
            // 
            this.TB_Nome.Location = new System.Drawing.Point(175, 58);
            this.TB_Nome.Name = "TB_Nome";
            this.TB_Nome.Size = new System.Drawing.Size(330, 23);
            this.TB_Nome.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 128);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 204);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Size = new System.Drawing.Size(144, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data Nascimento:";
            // 
            // TextClassDependent
            // 
            this.TextClassDependent.AutoSize = true;
            this.TextClassDependent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextClassDependent.Location = new System.Drawing.Point(13, 282);
            this.TextClassDependent.Name = "TextClassDependent";
            this.TextClassDependent.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TextClassDependent.Size = new System.Drawing.Size(148, 21);
            this.TextClassDependent.TabIndex = 4;
            this.TextClassDependent.Text = "WaitingDeffinition";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // CadastroPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 403);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BConfirmarCadastro);
            this.Controls.Add(this.B_Sair);
            this.Name = "CadastroPessoa";
            this.Text = "CadastroPessoa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button B_Sair;
        private Button BConfirmarCadastro;
        private ComboBox TB_ClassType;
        private Panel panel1;
        private DateTimePicker TB_DataNascimento;
        private TextBox TB_emailORctps;
        private TextBox TB_Cpf;
        private TextBox TB_Nome;
        private Label label4;
        private Label label3;
        private Label TextClassDependent;
        private Label label1;
    }
}
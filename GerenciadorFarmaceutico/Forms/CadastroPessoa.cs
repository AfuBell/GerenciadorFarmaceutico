using GerenciadorFarmaceutico.Classes;
using GerenciadorFarmaceutico.Classes.Pessoas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorFarmaceutico.Forms
{
    public partial class CadastroPessoa : Form
    {
        
        //informacoes do cadastrado
        private string nome = string.Empty;
        private string cpf = string.Empty;
        private DateTime data;
        private string ctpsORemail = string.Empty;
        //
        public CadastroPessoa()

        {
            
            InitializeComponent();
        }

        private void BConfirmarCadastro_Click(object sender, EventArgs e)
        {
            Pessoa cadastrado;
            nome = TB_Nome.Text;
            cpf = TB_Cpf.Text;
            data = TB_DataNascimento.Value;
            ctpsORemail = TB_emailORctps.Text;
            if(TB_ClassType.SelectedIndex == 0)
            {
               cadastrado = new Cliente(SubMain.maxIdPessoa, nome, cpf, data, ctpsORemail);
            }
            else
            {
                cadastrado = new Funcionario(SubMain.maxIdPessoa, nome, cpf, data, ctpsORemail);
            }
            SubMain.AddPessoa(cadastrado);
            this.Close();
        }

        private void TB_ClassType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TB_ClassType.SelectedIndex == 0)
            {
                TextClassDependent.Text = "email";
            }
            else
            {
                TextClassDependent.Text = "ctps";
            }
        }
       
        private void B_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

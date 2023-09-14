using GerenciadorFarmaceutico.Classes;
using GerenciadorFarmaceutico.Classes.Produtos;
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
    public partial class CadastrarProduto : Form
    {


        public CadastrarProduto()
        {
            InitializeComponent();
        }

        private void CBTypePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBTypePicker.SelectedIndex == 0)
            {
                PanelMed.Visible = false;
            }
            else PanelMed.Visible = true;
        }

        private void BCadastroProduto_Click(object sender, EventArgs e)
        {
            Produto ProdutoACadastrar;
            if (CBTypePicker.SelectedIndex == 0)
            {
                ProdutoACadastrar = new Produto(SubMain.maxIdProduto, TBDescricao.Text, TBMarca.Text, TBLote.Text, DatePickerFabricacao.Value, DatePickerVencimento.Value, TBCodigoDeBarras.Text, Convert.ToDouble(TBValor.Text));
            }
            else if (CBTypePicker.SelectedIndex == 1)
            {
                ProdutoACadastrar = new Medicamento(SubMain.maxIdProduto, TBDescricao.Text, TBMarca.Text, TBLote.Text, DatePickerFabricacao.Value, DatePickerVencimento.Value, TBCodigoDeBarras.Text, Convert.ToDouble(TBValor.Text), Convert.ToInt32(TBNumRegistroAnvisa.Text), TBComposicao.Text, Convert.ToDouble(TBDosagem.Text));
            }
            else if (CBTypePicker.SelectedIndex == 2)
            {
                ProdutoACadastrar = new MedicamentoControlado(SubMain.maxIdProduto, TBDescricao.Text, TBMarca.Text, TBLote.Text, DatePickerFabricacao.Value, DatePickerVencimento.Value, TBCodigoDeBarras.Text, Convert.ToDouble(TBValor.Text), Convert.ToInt32(TBNumRegistroAnvisa.Text), TBComposicao.Text, Convert.ToDouble(TBDosagem.Text));
            }
            else if (CBTypePicker.SelectedIndex == 3)
            {
                ProdutoACadastrar = new MedicamentoInjetavel(SubMain.maxIdProduto, TBDescricao.Text, TBMarca.Text, TBLote.Text, DatePickerFabricacao.Value, DatePickerVencimento.Value, TBCodigoDeBarras.Text, Convert.ToDouble(TBValor.Text), Convert.ToInt32(TBNumRegistroAnvisa.Text), TBComposicao.Text, Convert.ToDouble(TBDosagem.Text));
            }
            else
            {
                MessageBox.Show("ERROR");
                return;
            }
            SubMain.AddProduto(ProdutoACadastrar);
            this.Close();
        }

        private void CadastrarProduto_Load(object sender, EventArgs e)
        {

        }
    }
}

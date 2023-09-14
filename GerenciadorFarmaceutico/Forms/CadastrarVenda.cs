using GerenciadorFarmaceutico.Classes;
using GerenciadorFarmaceutico.Classes.GerenciadorVendas;
using GerenciadorFarmaceutico.Classes.Pessoas;
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
    public partial class CadastrarVenda : Form
    {
        //
        int x;
        Venda venda;
        Funcionario funcResponsavel;
        Cliente clienteDaCompra;
        Produto produtoAAdicionar;
        //
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public CadastrarVenda()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {


            InitializeComponent();
        }

        private void CBFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBFuncionarios.SelectedItem is Funcionario funEscolhido)
            {
                funcResponsavel = funEscolhido;
            }
        }

        private void CadastrarVenda_Load(object sender, EventArgs e)
        {
            foreach (var pessoas in SubMain.pessoas)
            {
                if (pessoas is Funcionario)
                {
                    CBFuncionarios.Items.Add(pessoas);
                }
            }
            foreach (var produtos in SubMain.produtos)
            {
                CBProdutos.Items.Add(produtos);
            }
        }

        private void BIniciarVenda_Click(object sender, EventArgs e)
        {
            DataHolder.Items.Clear();
            x = SubMain.pessoas.FindIndex(item => item.cpf == TBCpf.Text);
            clienteDaCompra = (Cliente)SubMain.pessoas[x];
            venda = new Venda(SubMain.maxIdVenda, funcResponsavel, clienteDaCompra, DTDataCompra.Value);
            DataHolder.Items.Add("Id Venda: " + venda.id);
            DataHolder.Items.Add("Funcionario Responsavel: " + venda.funcionario.nome);
            DataHolder.Items.Add("Cliente: " + venda.cliente.nome);
            DataHolder.Items.Add("Data da venda: " + venda.data.Day + "/" + venda.data.Month + "/" + venda.data.Year);
            DataHolder.Items.Add("-ITENS: ");
            PainelItemVenda.Visible = true;
        }

        private void CBProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBProdutos.SelectedItem is Produto prodEscolhido)
            {
                produtoAAdicionar = prodEscolhido;
            }
        }

        private void BAdicionarItem_Click(object sender, EventArgs e)
        {
            venda.itens.Add(new ItemVenda(produtoAAdicionar, Convert.ToInt32(NumericPad.Value), produtoAAdicionar.valor));
            venda.valorProduto += venda.itens[venda.itemVendaIndex].valorTotal;
            venda.desconto += venda.itens[venda.itemVendaIndex].desconto;
            venda.valorTotal += venda.itens[venda.itemVendaIndex].valorTotalCalculado;
            DataHolder.Items.Add("- Produto: " + produtoAAdicionar.descricao);
            DataHolder.Items.Add("-  Valor Unitario: " + produtoAAdicionar.valor);
            DataHolder.Items.Add("-  Quantidade: " + Convert.ToInt32(NumericPad.Value));
            venda.itemVendaIndex++;
            ListaValorTotal.Items.Clear();
            ListaValorTotal.Items.Add(venda.valorProduto);
            ListaDesconto.Items.Clear();
            ListaDesconto.Items.Add(venda.desconto);
            ListaValorProdutos.Items.Clear();
            ListaValorProdutos.Items.Add(venda.valorTotal);
        }


        private void BTerminarVenda_Click(object sender, EventArgs e)
        {
            SubMain.AddVenda(venda);
            this.Close();
        }

        
    }
}

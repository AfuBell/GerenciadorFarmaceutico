using GerenciadorFarmaceutico.Classes.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorFarmaceutico.Classes.GerenciadorVendas
{
    internal class ItemVenda
    {
        //variaveis auxiliares
        private double _valorTotal;
        private double _valorTotalCalculado;
        
        //variaveis
        public Produto produto;
        public int quantidade { get; set; }
        public double valorUnitario { get; set; }
        public double valorTotal
        {
            get
            {
                return _valorTotal;
            }
            set
            {
                _valorTotal = valorUnitario * quantidade;
            }
        }
        public double valorTotalCalculado
        {
            get
            {
                return _valorTotalCalculado;
            }
            set
            {
                _valorTotalCalculado = valorTotal * produto.GetDesconto();
                desconto = valorTotal - _valorTotalCalculado;
            }
        }
        public double desconto { get; set; }
        //Construtores
        public ItemVenda(Produto produto, int quantidade, double valorUnitario)
        {
            this.produto = produto ?? throw new ArgumentNullException(nameof(produto));
            this.quantidade = quantidade;
            this.valorUnitario = valorUnitario;
            this.valorTotal = 1;
            this.valorTotalCalculado = 1;
        }
        public ItemVenda(Medicamento produto, int quantidade, double valorUnitario)
        {
            this.produto = produto ?? throw new ArgumentNullException(nameof(produto));
            this.quantidade = quantidade;
            this.valorUnitario = valorUnitario;
            this.valorTotal = 1;
            this.valorTotalCalculado = 1;
        }
        public ItemVenda(MedicamentoControlado produto, int quantidade, double valorUnitario)
        {
            this.produto = produto ?? throw new ArgumentNullException(nameof(produto));
            this.quantidade = quantidade;
            this.valorUnitario = valorUnitario;
            this.valorTotal = 1;
            this.valorTotalCalculado = 1;
        }
        public ItemVenda(MedicamentoInjetavel produto, int quantidade, double valorUnitario)
        {
            this.produto = produto ?? throw new ArgumentNullException(nameof(produto));
            this.quantidade = quantidade;
            this.valorUnitario = valorUnitario;
            this.valorTotal = 1;
            this.valorTotalCalculado = 1;
        }
    
        
    }
}

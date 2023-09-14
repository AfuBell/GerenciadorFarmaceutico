using GerenciadorFarmaceutico.Classes.Pessoas;
using GerenciadorFarmaceutico.Classes.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorFarmaceutico.Classes.GerenciadorVendas
{
    internal class Venda
    {
        public int id { get; set; }
        public Funcionario funcionario { get; set; }
        public Cliente cliente { get; set; }
        public DateTime data { get; set; }
        public double valorProduto { get; set; }
        public double desconto { get; set; }
        public double valorTotal { get; set; }
        public List<ItemVenda> itens = new();
        public int itemVendaIndex;
        public Venda(int id, Funcionario funcionario, Cliente cliente, DateTime data, double valorProduto, double desconto, double valorTotal, List<ItemVenda> itens)
        {
            this.id = id;
            this.funcionario = funcionario ?? throw new ArgumentNullException(nameof(funcionario));
            this.cliente = cliente ?? throw new ArgumentNullException(nameof(cliente));
            this.data = data;
            this.valorProduto = valorProduto;
            this.desconto = desconto;
            this.valorTotal = valorTotal;
            this.itens = itens ?? throw new ArgumentNullException(nameof(itens));
        }

        public Venda(int id, Funcionario funcionario, Cliente cliente, DateTime data)
        {
            this.id = id;
            this.funcionario = funcionario ?? throw new ArgumentNullException(nameof(funcionario));
            this.cliente = cliente ?? throw new ArgumentNullException(nameof(cliente));
            this.data = data;
        }
    }
}

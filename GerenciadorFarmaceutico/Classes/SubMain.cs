using GerenciadorFarmaceutico.Classes.GerenciadorVendas;
using GerenciadorFarmaceutico.Classes.Pessoas;
using GerenciadorFarmaceutico.Classes.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorFarmaceutico.Classes
{
    internal class SubMain
    {
        public static List<Pessoa> pessoas = new();
        public static List<Produto> produtos= new();
        public static List<Venda> vendas= new();
        //ids
        public static int maxIdPessoa = 1;
        public static int maxIdProduto = 1;
        public static int maxIdVenda = 1;
        //
        public SubMain()
        {
            
        }

        public static void AddPessoa(Pessoa pessoa)
        {
            pessoas.Add(pessoa);
            maxIdPessoa++;
        }
        public static void AddProduto(Produto produto)
        {
            produtos.Add(produto);
            maxIdProduto++;
        }
        public static void AddVenda(Venda venda)
        {
            vendas.Add(venda);
            maxIdVenda++;
        }
        
        
    }
}

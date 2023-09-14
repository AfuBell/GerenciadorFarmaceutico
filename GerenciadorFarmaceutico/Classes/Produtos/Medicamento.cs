using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorFarmaceutico.Classes.Produtos
{
    public class Medicamento : Produto
    {
        public Medicamento()
        {
        }

        public Medicamento(int codigo, string _descricao, string _marca, string _lote, DateTime DataFabricacao, DateTime DataVencimento, string codigoDeBarras, double valor, int numRegistroAnvisa, string composicao, double dosagem) : base(codigo, _descricao, _marca, _lote, DataFabricacao, DataVencimento, codigoDeBarras, valor)
        {
            this.numRegistroAnvisa = numRegistroAnvisa;
            this.composicao = composicao;
            this.dosagem = dosagem;
        }

        public int numRegistroAnvisa { get; set; }
        public string composicao { get; set; } = string.Empty;
        public double dosagem { get; set; }
        public override double GetDesconto()
        {
            return Convert.ToDouble(1.1);
        }
    }
}

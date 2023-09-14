using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorFarmaceutico.Classes.Produtos
{
    internal class MedicamentoControlado : Medicamento
    {
        public MedicamentoControlado(int codigo, string _descricao, string _marca, string _lote, DateTime dataFabricacao, DateTime DataVencimento, string codigoDeBarras, double valor, int numRegistroAnvisa, string composicao, double dosagem) : base(codigo, _descricao, _marca, _lote, dataFabricacao, DataVencimento, codigoDeBarras, valor, numRegistroAnvisa, composicao, dosagem)
        {
        }
        public override double GetDesconto()
        {
            return Convert.ToDouble(1.03);
        }
    }
}

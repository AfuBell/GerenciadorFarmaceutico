using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorFarmaceutico.Classes.Produtos
{
    internal class MedicamentoInjetavel : Medicamento
    {
        public MedicamentoInjetavel(int codigo, string descricao, string marca, string lote, DateTime dataFabricacao, DateTime dataVencimento, string codigoDeBarras, double valor, int numRegistroAnvisa, string composicao, double dosagem) : base(codigo, descricao, marca, lote, dataFabricacao, dataVencimento, codigoDeBarras, valor, numRegistroAnvisa, composicao, dosagem)
        {
        }
        public override double GetDesconto()
        {
            return Convert.ToDouble(1);
        }
    }
}

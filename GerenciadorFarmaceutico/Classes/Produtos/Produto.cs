using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorFarmaceutico.Classes.Produtos
{
    public class Produto
    {
        public Produto()
        {
        }
        public override string ToString()
        {
            return descricao;
        }
        public Produto(int codigo, string _descricao, string _marca, string _lote, DateTime dataFabricacao, DateTime dataVencimento, string _codigoDeBarras, double valor)
        {
            this.Id = codigo;
            this.descricao = _descricao ?? throw new ArgumentNullException(nameof(_descricao));
            this.marca = _marca ?? throw new ArgumentNullException(nameof(_marca));
            this.lote = _lote ?? throw new ArgumentNullException(nameof(_lote));
            this.fabricacao = dataFabricacao;
            this.vencimento = dataVencimento;
            this.codigoDeBarras = _codigoDeBarras ?? throw new ArgumentNullException(nameof(_codigoDeBarras));
            this.valor = valor;
        }

        public int Id { get; set; }
        public string descricao { get; set; } = string.Empty;
        public string marca { get; set; } = string.Empty;
        public string lote { get; set; } = string.Empty;
        public DateTime fabricacao { get; set; }
        public DateTime vencimento { get; set; }
        public string codigoDeBarras { get; set; } = string.Empty;
        public double valor { get; set; }
        public virtual double GetDesconto()
        {
            return Convert.ToDouble(1.05);
        }
    }
}

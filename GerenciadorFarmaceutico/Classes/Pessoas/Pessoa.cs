using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorFarmaceutico.Classes.Pessoas
{
     public class Pessoa
    {
        public Pessoa(int id, string nome, string cpf, DateTime dataNascimento)
        {
            this.id = id;
            this.nome = nome ?? throw new ArgumentNullException(nameof(nome));
            this.cpf = cpf ?? throw new ArgumentNullException(nameof(cpf));
            this.dataNascimento = dataNascimento;
        }

        public int id { get; init; }
        public string nome { get; set; } = string.Empty;
        public string cpf { get; set; } = string.Empty;
        public DateTime dataNascimento { get; set; }
        public virtual string GetDataEspecial()
        {
            return string.Empty;
        }
    }
}

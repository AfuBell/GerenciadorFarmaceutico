using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorFarmaceutico.Classes.Pessoas
{
    internal class Funcionario : Pessoa
    {
        public Funcionario(int id, string nome, string cpf, DateTime dataNascimento, string ctps) : base(id, nome, cpf, dataNascimento)
        {
            this.ctps = ctps;
        }

        public string ctps { get; set; } = string.Empty;
        //retornar nome para as boxes de funcionarios mostrarem o nome no cadastrar venda
        public override string ToString()
        {
            return nome;
        }
        public override string GetDataEspecial()
        {
            return ctps;
        }
    }
}

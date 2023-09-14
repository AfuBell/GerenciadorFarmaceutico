using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorFarmaceutico.Classes.Pessoas
{
    internal class Cliente : Pessoa
    {
        public Cliente(int id, string nome, string cpf, DateTime dataNascimento, string email) : base(id, nome, cpf, dataNascimento)
        {
            emailo = email;
        }

        public string emailo { get; set; } = string.Empty;
        public override string GetDataEspecial()
        {
            return emailo;
        }
    }
}

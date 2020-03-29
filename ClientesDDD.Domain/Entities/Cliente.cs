using System;
using System.Collections.Generic;
using System.Text;

namespace ClientesDDD.Domain.Entities
{
    public class Cliente
    {
        public Cliente(Guid id, string nome, string sobrenome, DateTime dataNascimento)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            DataNascimento = dataNascimento;
        }

        public Cliente() { }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}

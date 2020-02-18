using System;
using System.Collections.Generic;
using System.Text;

namespace FornecedoresDDD.Dominio.Entidades
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}

using FornecedoresDDD.Aplicacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FornecedoresDDD.Aplicacao.Aplicacao
{
    public class Produto : IProduto
    {
        public void Adicionar(Dominio.Entidades.Produto obj)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Dominio.Entidades.Produto obj)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Dominio.Entidades.Produto obj)
        {
            throw new NotImplementedException();
        }

        public IList<Dominio.Entidades.Produto> Listar()
        {
            throw new NotImplementedException();
        }

        public Dominio.Entidades.Produto RecuperarPorId(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}

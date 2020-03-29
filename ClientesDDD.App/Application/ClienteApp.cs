using ClientesDDD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientesDDD.Domain.Entities;


namespace ClientesDDD.App.Application
{
    public class ClienteApp : ICliente
    {
        ICliente _cliente;

        public ClienteApp(ICliente cliente)
        {
            _cliente = cliente;
        }

        public void Adicionar(Cliente cliente)
        {
            _cliente.Adicionar(cliente);
        }

        public void Atualizar(Cliente cliente)
        {
            _cliente.Atualizar(cliente);
        }

        public void Excluir(Cliente cliente)
        {
            _cliente.Excluir(cliente);
        }

        public IList<Cliente> Listar()
        {
            return _cliente.Listar();
        }

        public Cliente RecuperarPorId(Guid id)
        {
            return _cliente.RecuperarPorId(id);
        }
    }
}

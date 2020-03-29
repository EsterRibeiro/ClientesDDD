using ClientesDDD.Domain.Entities;
using ClientesDDD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClientesDDD.Infra.Repositoriy
{
    public class ClienteRepository: BaseRepository<Cliente>, ICliente
    {
    }
}

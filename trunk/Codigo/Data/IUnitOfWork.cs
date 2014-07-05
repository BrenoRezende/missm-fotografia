using System;
using Data;
using Model;

namespace Data
{
    public interface IUnitOfWork
    {
        void Commit(bool shared);
        IRepositorioGenerico<tb_produto> RepositorioProduto { get; }
<<<<<<< .mine

=======
>>>>>>> .r120
        IRepositorioGenerico<tb_servico> RepositorioServico { get; }
<<<<<<< .mine

=======
>>>>>>> .r120
        IRepositorioGenerico<tb_tipo_evento> RepositorioTipoEvento { get; }
<<<<<<< .mine
=======

>>>>>>> .r120
    }
}

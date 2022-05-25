using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projFinal.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaId(int id);
        void Isere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}
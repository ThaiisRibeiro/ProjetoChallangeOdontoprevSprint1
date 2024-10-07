using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Interface
{
    //public interface InterfaceContasReceberApp : InterfaceGenericApp<ContasReceber>
    
     public interface InterfaceContasReceberApp
    {
        void Adcionar(ContasReceber Objeto);

        void Atualizar(ContasReceber Objeto);

        void Excluir(ContasReceber Objeto);

        ContasReceber ObterPorId(int Id);

        IList<ContasReceber> Listar();
    }

}


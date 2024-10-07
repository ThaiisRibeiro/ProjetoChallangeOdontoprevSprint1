using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Interface
{
    //public interface InterfaceAgendamentoApp : InterfaceGenericApp<Agendamento>
    public interface InterfaceAgendamentoApp
    {
        void Adcionar(Agendamento Objeto);

        void Atualizar(Agendamento Objeto);

        void Excluir(Agendamento Objeto);

        Agendamento ObterPorId(int Id);

        IList<Agendamento> Listar();
    }
}

using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    //public interface IPacienteRepository : InterfaceGeneric<Paciente>
    public interface IAgendamentoRepository
    {
        void Adcionar(Agendamento Objeto);

        void Atualizar(Agendamento Objeto);

        void Excluir(Agendamento Objeto);

        Agendamento ObterPorId(int Id);

        IList<Agendamento> Listar();
    }
}

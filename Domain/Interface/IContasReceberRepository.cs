using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    //public interface IPacienteRepository : InterfaceGeneric<Paciente>
        public interface IContasReceberRepository
    {
        void Adcionar(ContasReceber Objeto);

        void Atualizar(ContasReceber Objeto);

        void Excluir(ContasReceber Objeto);

        ContasReceber ObterPorId(int Id);

        IList<ContasReceber> Listar();
    }
}

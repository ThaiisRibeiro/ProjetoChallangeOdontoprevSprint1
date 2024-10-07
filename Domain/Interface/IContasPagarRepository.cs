using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    //public interface IPacienteRepository : InterfaceGeneric<Paciente>
        public interface IContasPagarRepository
    {
        void Adcionar(ContasPagar Objeto);

        void Atualizar(ContasPagar Objeto);

        void Excluir(ContasPagar Objeto);

        ContasPagar ObterPorId(int Id);

        IList<ContasPagar> Listar();
    }
}

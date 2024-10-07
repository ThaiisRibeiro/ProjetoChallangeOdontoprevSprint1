using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    //public interface IPacienteRepository : InterfaceGeneric<Paciente>
        public interface IPacienteRepository 
    {
        void Adcionar(Paciente Objeto);

        void Atualizar(Paciente Objeto);

        void Excluir(Paciente Objeto);

        Paciente ObterPorId(int Id);

        IList<Paciente> Listar();
    }
}

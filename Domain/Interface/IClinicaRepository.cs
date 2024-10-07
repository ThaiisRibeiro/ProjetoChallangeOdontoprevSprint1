using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    //public interface IPacienteRepository : InterfaceGeneric<Paciente>
        public interface IClinicaRepository
    {
        void Adcionar(Clinica Objeto);

        void Atualizar(Clinica Objeto);

        void Excluir(Clinica Objeto);

        Clinica ObterPorId(int Id);

        IList<Clinica> Listar();
    }
}

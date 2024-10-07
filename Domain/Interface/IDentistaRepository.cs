using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    //public interface IPacienteRepository : InterfaceGeneric<Paciente>
        public interface IDentistaRepository
    {
        void Adcionar(Dentista Objeto);

        void Atualizar(Dentista Objeto);

        void Excluir(Dentista Objeto);

        Dentista ObterPorId(int Id);

        IList<Dentista> Listar();
    }
}

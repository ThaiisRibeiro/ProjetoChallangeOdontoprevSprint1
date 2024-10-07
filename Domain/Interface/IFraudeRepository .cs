using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    //public interface IPacienteRepository : InterfaceGeneric<Paciente>
        public interface IFraudeRepository
    {
        void Adcionar(Fraude Objeto);

        void Atualizar(Fraude Objeto);

        void Excluir(Fraude Objeto);

        Fraude ObterPorId(int Id);

        IList<Fraude> Listar();
    }
}

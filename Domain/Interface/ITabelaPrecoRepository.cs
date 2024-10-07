using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    //public interface IPacienteRepository : InterfaceGeneric<Paciente>
        public interface ITabelaPrecoRepository
    {
        void Adcionar(TabelaPreco Objeto);

        void Atualizar(TabelaPreco Objeto);

        void Excluir(TabelaPreco Objeto);

        TabelaPreco ObterPorId(int Id);

        IList<TabelaPreco> Listar();
    }
}

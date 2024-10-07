using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Interface
{
   // public interface InterfacePacienteApp : InterfaceGenericApp<Paciente>
    
        public interface InterfacePacienteApp
        {
            void Adcionar(Paciente Objeto);

            void Atualizar(Paciente Objeto);

            void Excluir(Paciente Objeto);

        Paciente ObterPorId(int Id);

            IList<Paciente> Listar();
        }

    }


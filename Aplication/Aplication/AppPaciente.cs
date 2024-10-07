using Aplication.Interface;
using Domain.Entities;
using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Aplication
{
    public class AppPaciente : InterfacePacienteApp
    {

        IPacienteRepository _InterfacePaciente;

        public AppPaciente(IPacienteRepository InterfacePaciente)
        {
            _InterfacePaciente = InterfacePaciente;
        }

        public void Adcionar(Paciente Objeto)
        {
            _InterfacePaciente.Adcionar(Objeto);
        }


        public void Atualizar(Paciente Objeto)
        {
            _InterfacePaciente.Atualizar(Objeto);
        }

        public void Excluir(Paciente Objeto)
        {
            _InterfacePaciente.Excluir(Objeto);
        }

        public Paciente ObterPorId(int Id)
        {
            return _InterfacePaciente.ObterPorId(Id);
        }
        public IList<Paciente> Listar()
        {
            return _InterfacePaciente.Listar();
        }

    }
}

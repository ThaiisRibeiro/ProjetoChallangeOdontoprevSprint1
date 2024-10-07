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
    public class AppAgendamento : InterfaceAgendamentoApp
    {
     
      

            IAgendamentoRepository _InterfaceAgendamento;

            public AppAgendamento(IAgendamentoRepository InterfaceAgendamento)
            {
            _InterfaceAgendamento = InterfaceAgendamento;
            }

            public void Adcionar(Agendamento Objeto)
            {
            _InterfaceAgendamento.Adcionar( Objeto) ;
            }


            public void Atualizar(Agendamento Objeto)
            {
            _InterfaceAgendamento.Atualizar(Objeto);
            }

            public void Excluir(Agendamento Objeto)
            {
            _InterfaceAgendamento.Excluir(Objeto);
            }

            public Agendamento ObterPorId(int Id)
            {
                return _InterfaceAgendamento.ObterPorId(Id);
            }
            public IList<Agendamento> Listar()
            {
                return _InterfaceAgendamento.Listar();
            }

        }
    }


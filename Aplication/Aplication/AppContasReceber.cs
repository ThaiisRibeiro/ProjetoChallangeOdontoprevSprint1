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
    public class AppContasReceber : InterfaceContasReceberApp
    {
        




            IContasReceberRepository _InterfaceContasReceber;

            public AppContasReceber(IContasReceberRepository InterfaceContasReceber)
            {
            _InterfaceContasReceber = InterfaceContasReceber;
            }

            public void Adcionar(ContasReceber Objeto)
            {
            _InterfaceContasReceber.Adcionar(Objeto);
            }


            public void Atualizar(ContasReceber Objeto)
            {
            _InterfaceContasReceber.Atualizar(Objeto);
            }

            public void Excluir(ContasReceber Objeto)
            {
            _InterfaceContasReceber.Excluir(Objeto);
            }

            public ContasReceber ObterPorId(int Id)
            {
                return _InterfaceContasReceber.ObterPorId(Id);
            }
            public IList<ContasReceber> Listar()
            {
                return _InterfaceContasReceber.Listar();
            }

        }
    }


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
    public class AppContasPagar : InterfaceContasPagarApp
    {
        



            IContasPagarRepository _InterfaceContasPagar;

            public AppContasPagar(IContasPagarRepository InterfaceContasPagar)
            {
                _InterfaceContasPagar = InterfaceContasPagar;
            }

            public void Adcionar(ContasPagar Objeto)
            {
            _InterfaceContasPagar.Adcionar(Objeto);
            }


            public void Atualizar(ContasPagar Objeto)
            {
            _InterfaceContasPagar.Atualizar(Objeto);
            }

            public void Excluir(ContasPagar Objeto)
            {
            _InterfaceContasPagar.Excluir(Objeto);
            }

            public ContasPagar ObterPorId(int Id)
            {
            return _InterfaceContasPagar.ObterPorId(Id);
            }
            public IList<ContasPagar> Listar()
            {
            return _InterfaceContasPagar.Listar();
            }

        }
    }


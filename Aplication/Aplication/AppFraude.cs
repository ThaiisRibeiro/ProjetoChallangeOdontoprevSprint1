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
    public class AppFraude : InterfaceFraudeApp
    {
       
            IFraudeRepository _InterfaceFraude;

            public AppFraude(IFraudeRepository InterfaceFraude)
            {
                _InterfaceFraude = InterfaceFraude;
            }

            public void Adcionar(Fraude Objeto)
            {
            _InterfaceFraude.Adcionar(Objeto);
            }


            public void Atualizar(Fraude Objeto)
            {
            _InterfaceFraude.Atualizar(Objeto);
            }

            public void Excluir(Fraude Objeto)
            {
            _InterfaceFraude.Excluir(Objeto);
            }

            public Fraude ObterPorId(int Id)
            {
                return _InterfaceFraude.ObterPorId(Id);
            }
            public IList<Fraude> Listar()
            {
                return _InterfaceFraude.Listar();
            }
        }
}

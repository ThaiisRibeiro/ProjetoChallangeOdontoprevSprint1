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
    public class AppDentista : InterfaceDentistaApp
    {
        IDentistaRepository _InterfaceDentista;

        public AppDentista(IDentistaRepository InterfaceDentista)
        {
            _InterfaceDentista = InterfaceDentista;
        }

        public void Adcionar(Dentista Objeto)
        {
            _InterfaceDentista.Adcionar(Objeto);
        }


        public void Atualizar(Dentista Objeto)
        {
            _InterfaceDentista.Atualizar(Objeto);
        }

        public void Excluir(Dentista Objeto)
        {
            _InterfaceDentista.Excluir(Objeto);
        }

        public Dentista ObterPorId(int Id)
        {
            return _InterfaceDentista.ObterPorId(Id);
        }
        public IList<Dentista> Listar()
        {
            return _InterfaceDentista.Listar();
        }

    }
}


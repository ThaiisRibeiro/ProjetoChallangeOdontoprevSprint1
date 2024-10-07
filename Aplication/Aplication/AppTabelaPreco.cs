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
    public class AppTabelaPreco : InterfaceTabelaPrecoApp
    {


        ITabelaPrecoRepository _InterfaceTabelaPreco;

            public AppTabelaPreco(ITabelaPrecoRepository InterfaceTabelaPreco)
            {
            _InterfaceTabelaPreco = InterfaceTabelaPreco;
            }

            public void Adcionar(TabelaPreco Objeto)
            {
            _InterfaceTabelaPreco.Adcionar(Objeto);
            }


            public void Atualizar(TabelaPreco Objeto)
            {
                _InterfaceTabelaPreco.Atualizar(Objeto);
            }

            public void Excluir(TabelaPreco Objeto)
            {
            _InterfaceTabelaPreco.Excluir(Objeto);
            }

            public TabelaPreco ObterPorId(int Id)
            {
                return _InterfaceTabelaPreco.ObterPorId(Id);
            }
            public IList<TabelaPreco> Listar()
            {
                return _InterfaceTabelaPreco.Listar();
            }
        }
}

using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Interface
{
   // public interface InterfaceTabelaPrecoApp : InterfaceGenericApp<TabelaPreco>
    
        public interface InterfaceTabelaPrecoApp
    {
            void Adcionar(TabelaPreco Objeto);

            void Atualizar(TabelaPreco Objeto);

            void Excluir(TabelaPreco Objeto);

        TabelaPreco ObterPorId(int Id);

            IList<TabelaPreco> Listar();
        }

    }


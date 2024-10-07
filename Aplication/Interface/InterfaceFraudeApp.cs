using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Interface
{
    //public interface InterfaceFraudeApp : InterfaceGenericApp<Fraude>
    
        public interface InterfaceFraudeApp
    {
            void Adcionar(Fraude Objeto);

            void Atualizar(Fraude Objeto);

            void Excluir(Fraude Objeto);

        Fraude ObterPorId(int Id);

            IList<Fraude> Listar();
        }

    }


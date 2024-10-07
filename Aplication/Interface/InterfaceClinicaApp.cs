using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Interface
{
    //public interface InterfaceClinicaApp : InterfaceGenericApp<Clinica>
    
        public interface InterfaceClinicaApp
        {
            void Adcionar(Clinica Objeto);

            void Atualizar(Clinica Objeto);

            void Excluir(Clinica Objeto);

        Clinica ObterPorId(int Id);

            IList<Clinica> Listar();
        }

    }


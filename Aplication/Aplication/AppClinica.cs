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
    public class AppClinica : InterfaceClinicaApp
    {




        IClinicaRepository _InterfaceClinica;

            public AppClinica(IClinicaRepository InterfaceClinica)
            {
            _InterfaceClinica = InterfaceClinica;
            }

            public void Adcionar(Clinica Objeto)
            {
            _InterfaceClinica.Adcionar(Objeto);
            }


            public void Atualizar(Clinica Objeto)
            {
            _InterfaceClinica.Atualizar(Objeto);
            }

            public void Excluir(Clinica Objeto)
            {
            _InterfaceClinica.Excluir(Objeto);
            }

            public Clinica ObterPorId(int Id)
            {
                return _InterfaceClinica.ObterPorId(Id);
            }
            public IList<Clinica> Listar()
            {
                return _InterfaceClinica.Listar();
            }

        }
    }


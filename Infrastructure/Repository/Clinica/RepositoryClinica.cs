using Domain.Interface;
using Domain.Entities;
using Infrastructure.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
//using Microsoft.IdentityModel.Tokens;

namespace Infrastructure.Repository.Clinica
{
    //public class RepositoryPaciente : RepositoryGeneric<RepositoryPaciente>, IPacienteRepository //nome da interface//
    public class RepositoryClinica : IClinicaRepository, IDisposable //nome da interface//
    {
        private DbContextOptions<Context> _OptionsBuilder;

        public RepositoryClinica()
        {
            _OptionsBuilder = new DbContextOptions<Context>();
        }
        public void Adcionar(Domain.Entities.Clinica Objeto)
        {
            
           // throw new NotImplementedException();
            using (var banco = new Context(_OptionsBuilder))
            {
                banco.Set<Domain.Entities.Clinica>().Add(Objeto);
                banco.SaveChangesAsync();
            }
        }







        public void Atualizar(Domain.Entities.Clinica Objeto)
        {
            using (var banco = new Context(_OptionsBuilder))
            {
                banco.Set<Domain.Entities.Clinica>().Update(Objeto);
                banco.SaveChangesAsync();
            }
        }



        public void Excluir(Domain.Entities.Clinica Objeto)
        {
            using (var banco = new Context(_OptionsBuilder))
            {
                banco.Set<Domain.Entities.Clinica>().Remove(Objeto);
                banco.SaveChangesAsync();
            }
        }

        public IList<Domain.Entities.Clinica> Listar()
        {
            using (var banco = new Context(_OptionsBuilder))
            {
                return banco.Set<Domain.Entities.Clinica>().AsNoTracking().ToList();
            }
        }

        public Domain.Entities.Clinica ObterPorId(int Id)
        {
            using (var banco = new Context(_OptionsBuilder))
            {
                return banco.Set<Domain.Entities.Clinica>().Find(Id);
            }
        }
        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }






    }

}

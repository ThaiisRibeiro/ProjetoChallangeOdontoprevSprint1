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

namespace Infrastructure.Repository.ContasReceber
{
    //public class RepositoryPaciente : RepositoryGeneric<RepositoryPaciente>, IPacienteRepository //nome da interface//
    public class RepositoryContasReceber : IContasReceberRepository, IDisposable //nome da interface//
    {
        private DbContextOptions<Context> _OptionsBuilder;

        public RepositoryContasReceber()
        {
            _OptionsBuilder = new DbContextOptions<Context>();
        }
        public void Adcionar(Domain.Entities.ContasReceber Objeto)
        {
            
           // throw new NotImplementedException();
            using (var banco = new Context(_OptionsBuilder))
            {
                banco.Set<Domain.Entities.ContasReceber>().Add(Objeto);
                banco.SaveChangesAsync();
            }
        }







        public void Atualizar(Domain.Entities.ContasReceber Objeto)
        {
            using (var banco = new Context(_OptionsBuilder))
            {
                banco.Set<Domain.Entities.ContasReceber>().Update(Objeto);
                banco.SaveChangesAsync();
            }
        }



        public void Excluir(Domain.Entities.ContasReceber Objeto)
        {
            using (var banco = new Context(_OptionsBuilder))
            {
                banco.Set<Domain.Entities.ContasReceber>().Remove(Objeto);
                banco.SaveChangesAsync();
            }
        }

        public IList<Domain.Entities.ContasReceber> Listar()
        {
            using (var banco = new Context(_OptionsBuilder))
            {
                return banco.Set<Domain.Entities.ContasReceber>().AsNoTracking().ToList();
            }
        }

        public Domain.Entities.ContasReceber ObterPorId(int Id)
        {
            using (var banco = new Context(_OptionsBuilder))
            {
                return banco.Set<Domain.Entities.ContasReceber>().Find(Id);
            }
        }
        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }






    }

}

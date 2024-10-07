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

namespace Infrastructure.Repository.Fraude
{
    //public class RepositoryPaciente : RepositoryGeneric<RepositoryPaciente>, IPacienteRepository //nome da interface//
    public class RepositoryFraude : IFraudeRepository, IDisposable //nome da interface//
    {
        private DbContextOptions<Context> _OptionsBuilder;

        public RepositoryFraude()
        {
            _OptionsBuilder = new DbContextOptions<Context>();
        }
        public void Adcionar(Domain.Entities.Fraude Objeto)
        {
            
           // throw new NotImplementedException();
            using (var banco = new Context(_OptionsBuilder))
            {
                banco.Set<Domain.Entities.Fraude>().Add(Objeto);
                banco.SaveChangesAsync();
            }
        }







        public void Atualizar(Domain.Entities.Fraude Objeto)
        {
            using (var banco = new Context(_OptionsBuilder))
            {
                banco.Set<Domain.Entities.Fraude>().Update(Objeto);
                banco.SaveChangesAsync();
            }
        }



        public void Excluir(Domain.Entities.Fraude Objeto)
        {
            using (var banco = new Context(_OptionsBuilder))
            {
                banco.Set<Domain.Entities.Fraude>().Remove(Objeto);
                banco.SaveChangesAsync();
            }
        }

        public IList<Domain.Entities.Fraude> Listar()
        {
            using (var banco = new Context(_OptionsBuilder))
            {
                return banco.Set<Domain.Entities.Fraude>().AsNoTracking().ToList();
            }
        }

        public Domain.Entities.Fraude ObterPorId(int Id)
        {
            using (var banco = new Context(_OptionsBuilder))
            {
                return banco.Set<Domain.Entities.Fraude>().Find(Id);
            }
        }
        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }






    }

}

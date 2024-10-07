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

namespace Infrastructure.Repository.Dentista
{
    //public class RepositoryPaciente : RepositoryGeneric<RepositoryPaciente>, IPacienteRepository //nome da interface//
    public class RepositoryDentista : IDentistaRepository, IDisposable //nome da interface//
    {
        private DbContextOptions<Context> _OptionsBuilder;

        public RepositoryDentista()
        {
            _OptionsBuilder = new DbContextOptions<Context>();
        }
        public void Adcionar(Domain.Entities.Dentista Objeto)
        {
            
           // throw new NotImplementedException();
            using (var banco = new Context(_OptionsBuilder))
            {
                banco.Set<Domain.Entities.Dentista>().Add(Objeto);
                banco.SaveChangesAsync();
            }
        }







        public void Atualizar(Domain.Entities.Dentista Objeto)
        {
            using (var banco = new Context(_OptionsBuilder))
            {
                banco.Set<Domain.Entities.Dentista>().Update(Objeto);
                banco.SaveChangesAsync();
            }
        }



        public void Excluir(Domain.Entities.Dentista Objeto)
        {
            using (var banco = new Context(_OptionsBuilder))
            {
                banco.Set<Domain.Entities.Dentista>().Remove(Objeto);
                banco.SaveChangesAsync();
            }
        }

        public IList<Domain.Entities.Dentista> Listar()
        {
            using (var banco = new Context(_OptionsBuilder))
            {
                return banco.Set<Domain.Entities.Dentista>().AsNoTracking().ToList();
            }
        }

        public Domain.Entities.Dentista ObterPorId(int Id)
        {
            using (var banco = new Context(_OptionsBuilder))
            {
                return banco.Set<Domain.Entities.Dentista>().Find(Id);
            }
        }
        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }






    }

}

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

namespace Infrastructure.Repository.TabelaPreco
{
    //public class RepositoryPaciente : RepositoryGeneric<RepositoryPaciente>, IPacienteRepository //nome da interface//
    public class RepositoryTabelaPreco : ITabelaPrecoRepository, IDisposable //nome da interface//
    {
        private DbContextOptions<Context> _OptionsBuilder;

        public RepositoryTabelaPreco()
        {
            _OptionsBuilder = new DbContextOptions<Context>();
        }
        public void Adcionar(Domain.Entities.TabelaPreco Objeto)
        {
            
           // throw new NotImplementedException();
            using (var banco = new Context(_OptionsBuilder))
            {
                banco.Set<Domain.Entities.TabelaPreco>().Add(Objeto);
                banco.SaveChangesAsync();
            }
        }







        public void Atualizar(Domain.Entities.TabelaPreco Objeto)
        {
            using (var banco = new Context(_OptionsBuilder))
            {
                banco.Set<Domain.Entities.TabelaPreco>().Update(Objeto);
                banco.SaveChangesAsync();
            }
        }



        public void Excluir(Domain.Entities.TabelaPreco Objeto)
        {
            using (var banco = new Context(_OptionsBuilder))
            {
                banco.Set<Domain.Entities.TabelaPreco>().Remove(Objeto);
                banco.SaveChangesAsync();
            }
        }

        public IList<Domain.Entities.TabelaPreco> Listar()
        {
            using (var banco = new Context(_OptionsBuilder))
            {
                return banco.Set<Domain.Entities.TabelaPreco>().AsNoTracking().ToList();
            }
        }

        public Domain.Entities.TabelaPreco ObterPorId(int Id)
        {
            using (var banco = new Context(_OptionsBuilder))
            {
                return banco.Set<Domain.Entities.TabelaPreco>().Find(Id);
            }
        }
        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }






    }

}

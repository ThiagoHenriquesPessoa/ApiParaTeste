using Domain;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly SqlContext _sqlContext;

        public PessoaRepository(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }

        public Pessoa GetPessoa(string register)
        {
            return _sqlContext.Pessoa.FirstOrDefault(p => p.Register == register);
        }

        public int InsertPessoa(Pessoa pessoa)
        {
            _sqlContext.Add(pessoa);
            _sqlContext.SaveChanges();
            return pessoa.Id;
        }
    }
}

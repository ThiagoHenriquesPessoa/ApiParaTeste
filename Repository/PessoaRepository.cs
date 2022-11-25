using Domain;
using Infrastructure;

namespace Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly SqlContext _sqlContext;

        public PessoaRepository()
        {
        }

        public Pessoa GetPessoa(string register)
        {
            return _sqlContext.Pessoa.Where(p => p.Register == register).FirstOrDefault();
        }

        public int InsertPessoa(Pessoa pessoa)
        {
            try
            {
                _sqlContext.Add(pessoa);
                _sqlContext.SaveChanges();
                return pessoa.Id;
            }
            catch
            {
                return 0;
            }
        }
    }
}
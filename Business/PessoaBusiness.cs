using Domain;
using Repository;

namespace Business
{
    public class PessoaBusiness : IPessoaBusiness
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaBusiness(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public Pessoa GetPessoa(string register)
        {
            return _pessoaRepository.GetPessoa(register);
        }

        public int InsertPessoa(Pessoa pessoa)
        {
            var isPessoa = _pessoaRepository.GetPessoa(pessoa.Register);
            if (isPessoa != null && isPessoa.Id == pessoa.Id)
            {
                return isPessoa.Id;
            }
            Random randNum = new Random();
            pessoa.Id = randNum.Next(10, 1000);
            var result = _pessoaRepository.InsertPessoa(pessoa);
            return result;
        }
    }
}
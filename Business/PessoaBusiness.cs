using Domain;
using Microsoft.Win32;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var pessoa = _pessoaRepository.GetPessoa(register);
            if (pessoa == null)
            {
                return new Pessoa();
            }
            return pessoa;
        }
        public int InsertPessoa(Pessoa pessoa)
        {
            var isPessoa = _pessoaRepository.GetPessoa(pessoa.Register);
            if (isPessoa != null)
            {
                return isPessoa.Id;
            }
            var idPessoa = _pessoaRepository.InsertPessoa(pessoa);
            if (pessoa == null)
            {
                return 0;
            }
            return idPessoa;
        }
    }
}

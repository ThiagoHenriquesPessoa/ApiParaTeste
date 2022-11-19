using Domain;

namespace Repository
{
    public interface IPessoaRepository
    {
        Pessoa GetPessoa(string register);
        int InsertPessoa(Pessoa pessoa);
    }
}
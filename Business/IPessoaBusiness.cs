using Domain;

namespace Business
{
    public interface IPessoaBusiness
    {
        Pessoa GetPessoa(string register);

        int InsertPessoa(Pessoa pessoa);
    }
}
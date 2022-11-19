using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface IPessoaBusiness
    {
        Pessoa GetPessoa(string register);
        int InsertPessoa(Pessoa pessoa);
    }
}

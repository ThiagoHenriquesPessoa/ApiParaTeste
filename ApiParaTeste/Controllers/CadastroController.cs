using Business;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace ApiParaTeste.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CadastroController : Controller
    {
        private readonly IPessoaBusiness _pessoaBusiness;

        public CadastroController(IPessoaBusiness pessoaBusiness)
        {
            _pessoaBusiness = pessoaBusiness;
        }

        /// <summary>
        /// Get Estados Json - json/Pessoa/{register}
        /// </summary>
        /// <param name="register"></param>
        /// <returns></returns>
        [HttpGet("json/Pessoa/Resgata/{register}")]
        public Pessoa GetPessoa(string register)
        {
            return _pessoaBusiness.GetPessoa(register);
        }
                
        [HttpPost("json/Pessoa/Insert/")]
        public int InsertPessoa([FromBody]Pessoa pessoa)
        {
            return _pessoaBusiness.InsertPessoa(pessoa);
        }
    }
}

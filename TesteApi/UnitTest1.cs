using Business;
using Domain;
using Moq;
using Repository;

namespace TesteApi
{
    public class UnitTest1
    {

        private Mock<IPessoaRepository> _pessoaRepositoryMock;
        private PessoaBusiness _pessoaBusiness;
        Pessoa pessoa = new Pessoa
        {
            Id = 519,
            Register = "25425425425",
            Name = "Thiago",
            LastName = "Henriques",
            Phone = 22222222,
            Email = "thiago@gmail.com",
            Logradouro = "rua acre",
            Number = 257,
            State = "RN",
            Country = "Brazil",
            Zipcode = 59142240
        };
        Pessoa pessoaNova = new Pessoa
        {
            Id = 222,
            Register = "22222222222",
            Name = "Thiago",
            LastName = "Henriques",
            Phone = 22222222,
            Email = "thiago@gmail.com",
            Logradouro = "rua acre",
            Number = 257,
            State = "RN",
            Country = "Brazil",
            Zipcode = 59142240
        };

        public UnitTest1()
        {           
            _pessoaRepositoryMock = new Mock<IPessoaRepository>();
            _pessoaRepositoryMock.Setup(x => x.GetPessoa(It.IsAny<string>())).Returns(pessoa);
            _pessoaRepositoryMock.Setup(x => x.InsertPessoa(It.IsAny<Pessoa>())).Returns(222);
            _pessoaBusiness = new PessoaBusiness(_pessoaRepositoryMock.Object);
        }

        [Fact]
        public void BuscaPessoaCadastrada()
        {
            var result = _pessoaBusiness.GetPessoa("25425425425");
            Assert.Equal(pessoa, result);
        }

        [Fact]
        public void SalvaPessoaNoBancoPessoaExistente()
        {
            var result = _pessoaBusiness.InsertPessoa(pessoa);
            Assert.Equal(519, result);
        }

        [Fact]
        public void SalvaPessoaNoBancoPessoaNova()
        {
            var result = _pessoaBusiness.InsertPessoa(pessoaNova);
            Assert.Equivalent(222, result);
        }
    }
}
using ApiParaTeste.Controllers;
using Business;
using Domain;
using Infrastructure;
using Microsoft.IdentityModel.Tokens;
using Moq;
using Repository;

namespace TestProject
{
    public class UnitTest
    {
        private IPessoaRepository _pessoaRepository;
        private Pessoa pessoa = new Pessoa
        {
            Id = 516,
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


        [Fact]
        public void VerificaRegisterCadastrado()
        {
            var mockPessoa = new Mock<PessoaRepository>();
            var getPessoa = mockPessoa.Setup(p => p.GetPessoa("25425425425")).Returns(new Pessoa()); 
            Assert.Equal(pessoa, getPessoa);
        }
    }
}
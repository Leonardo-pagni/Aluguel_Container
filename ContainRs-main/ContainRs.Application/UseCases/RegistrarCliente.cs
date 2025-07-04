using ContainRs.Domain.Models;
using ContainRs.Application.Repositories;

namespace ContainRs.Application.UseCases
{
    public class RegistrarCliente
    {
        private readonly IClienteRepository repository;
        public RegistrarCliente(IClienteRepository repository, string nome, Email email, string cPF, string? celular, string? cep, string? rua, string? numero, string? complemento, string? bairro, string? municipio, string? estado, int idade)
        {
            Nome = nome;
            Email = email;
            CPF = cPF;
            Celular = celular;
            CEP = cep;
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Municipio = municipio;
            Estado = estado;
            this.repository = repository;
            Idade = idade;
        }

        public string Nome { get; }
        public Email Email { get; }
        public string CPF { get; }
        public string? Celular { get; }
        public string? CEP { get; }
        public string? Rua { get; }
        public string? Numero { get; }
        public string? Complemento { get; }
        public string? Bairro { get; }
        public string? Municipio { get; }
        public string? Estado { get; }
        public int Idade { get; }

        public async Task<Cliente> ExecutarAsync()
        {
            var cliente = new Cliente(Nome, Email, CPF)
            {
                Celular = Celular,
                CEP = CEP,
                Rua = Rua,
                Numero = Numero,
                Complemento = Complemento,
                Bairro = Bairro,
                Municipio = Municipio,
                Estado = Estado,
                Idade = Idade
            };
            await repository.AddAsync(cliente);
            
            return cliente;
        }
    }
}

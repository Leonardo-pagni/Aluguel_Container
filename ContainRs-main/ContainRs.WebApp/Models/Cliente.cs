namespace ContainRs.WebApp.Models;

public class Cliente
{
    private Cliente() { }//EF core
    public Cliente(string nome, Email email, string cpf )
    {
        Nome = nome;
        Email = email;
        CPF = cpf;
    }


    public Guid Id { get; set; }
    public string Nome { get; private set; }
    public Email Email { get; private set; }
    public string CPF { get; private set; }
    public string? Celular { get; set; }
    public string? CEP { get; set; }
    public string? Rua { get; set; }
    public string? Numero { get; set; }
    public string? Complemento { get; set; }
    public string? Bairro { get; set; }
    public string? Municipio { get; set; }
    public string? Cidade { get; set; }
    public string? Estado { get; set; }
    public int Idade { get; set; }
}

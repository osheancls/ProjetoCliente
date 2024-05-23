namespace ProjetoCliente.Models
{
    public class Cliente
    {
        //CRIANDO O ENCAPSILAMENTO DO PROJETO COM GET E SET

        public int Id { get; set; } //encapsulamento
        public string Nome { get; set; }
        public string Email { get;set; }
        public string Telefone { get; set; }
    }
}

namespace Agenda
{
    public class Contato
    {
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
    }

    public static class ContatosManager
    {
        public static List<Contato> Contatos { get; } = new List<Contato>();
    }
}

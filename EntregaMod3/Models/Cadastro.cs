using System.ComponentModel.DataAnnotations;

namespace entregaLohane.Models
{
    public class Cadastro
    {
        [Key]
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? email { get; set; }
        public int NumeroTelefone { get; set; }
        public string? CPF { get; set; }
        public virtual List<Destino>? Destinos { get; set; }
    }
}

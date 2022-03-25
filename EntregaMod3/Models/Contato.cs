using System.ComponentModel.DataAnnotations;

namespace entregaLohane.Models
{
    public class Contato
    {
        [Key]
        public int IdContato { get; set; }
        public string Nome { get; set; }
        public string email { get; set; }
        public string Mensagem { get; set; }
        
    }
}

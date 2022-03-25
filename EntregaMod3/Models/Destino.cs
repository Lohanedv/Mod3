using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace entregaLohane.Models
{
    public class Destino
    {
        [Key]
        public int id { get; set; }
        public string Nomedestino { get; set; }
        public int NumeroVoo { get; set; }
        public string dataida { get; set; }
        public string datavolta { get; set; }
        [ForeignKey("Cadastro")]
        public int IdCadastro { get; set; } 
        public virtual Cadastro Cadastro { get; set; }  

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Table("Loja")]
    public class Loja
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        [Required]
        public string Nome { get; set; }
        [MaxLength(2000)]
        public string Descricao { get; set; }
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace alexbarboza.Models
{
    [Table("genero")]
    public class Genero
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50, MinimumLength = 5, ErrorMessage = "A destreve dete ter entre 5 a 50 caracteres")]
        [Required]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public List<Livro> Livros { get; set; }
    }
}
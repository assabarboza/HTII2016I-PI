using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace alexbarboza.Models
{
    [Table("livros")]
    public class Livro
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100, MinimumLength = 20, ErrorMessage = "A destreve dete ter entre 5 a 50 caracteres")]
        [Required]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [Display(Name = "Gênero")]
        public string Genero { get; set; }

        public List<Autor> Autores { get; set; }
    }
}
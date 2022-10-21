using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCRUD_MVC_SQLServer.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Atenção! O campo Nome é obrigatório.", AllowEmptyStrings = false)]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Atenção! O campo nome deve ter entre 3 e 100 caracteres. ")]
        [Column("Nome")]
        [Display(Name = "Nome")]
        public string? Nome { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Domain.Entidades
{
    public class Produto : EntidadeBase
    {
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }
    }
}

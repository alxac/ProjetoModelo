using System.ComponentModel.DataAnnotations;

namespace Domain.Entidades
{
    public class Produto : EBase
    {
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }
    }
}

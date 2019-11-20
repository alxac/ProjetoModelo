using System.ComponentModel.DataAnnotations;

namespace Domain.Entidades
{
    public class EBase : Notifica.Notifica
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }
    }
}

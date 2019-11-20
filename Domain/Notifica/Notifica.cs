using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Notifica
{
    public class Notifica
    {
        public Notifica()
        {
            Notificacoes = new List<Notifica>();
        }

        [NotMapped]
        public string NomeProdriedade { get; set; }

        [NotMapped]
        public string Mensagem { get; set; }

        [NotMapped]
        public List<Notifica> Notificacoes;

    }
}

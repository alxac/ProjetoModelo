﻿using System.ComponentModel.DataAnnotations;

namespace Domain.Entidades
{
    public class EntidadeBase
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }
    }
}

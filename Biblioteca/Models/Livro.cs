using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Biblioteca.Models
{
    public partial class Livro
    {
        public int Id { get; set; }
        [DisplayName("NOME")]
        public string? Nome { get; set; }
        [DisplayName("AUTOR")]
        public string? Autor { get; set; }
        [DisplayName("EDIÇÃO")]
        public string? Edição { get; set; }
    }
}

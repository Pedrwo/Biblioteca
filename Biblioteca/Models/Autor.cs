using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Biblioteca.Models
{
    public partial class Autor
    {
        public int Id { get; set; }
        [DisplayName("NOME")]
        public string? Nome { get; set; }
    }
}

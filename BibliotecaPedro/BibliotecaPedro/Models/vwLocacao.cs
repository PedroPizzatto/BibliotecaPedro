//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BibliotecaPedro.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwLocacao
    {
        public int LocacaoId { get; set; }
        public int LivroId { get; set; }
        public string LivroNome { get; set; }
        public string Autor { get; set; }
        public int PessoaId { get; set; }
        public string PessoaNome { get; set; }
        public string CPF { get; set; }
        public System.DateTime InicioDt { get; set; }
        public Nullable<System.DateTime> TerminoDt { get; set; }
    }
}

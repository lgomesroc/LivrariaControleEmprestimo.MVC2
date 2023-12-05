using System;
using System.Collections.Generic;

namespace LivrariaControleEmprestimo.WEB.Models;

public partial class Livro
{
    public int id { get; set; }

    public string livroNome { get; set; }

    public string livroAutor { get; set; }

    public string livroEditora { get; set; }

    public DateTime livroAnoPublicacao { get; set; }

    public string livroEdicao { get; set; }

    public virtual Livro_Cliente_Emprestimo Livro_Cliente_Emprestimo { get; set; }
}

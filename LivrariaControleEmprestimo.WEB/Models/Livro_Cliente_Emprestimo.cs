using System;
using System.Collections.Generic;

namespace LivrariaControleEmprestimo.WEB.Models;

public partial class Livro_Cliente_Emprestimo
{
    public int id { get; set; }

    public int? lceIdLivro { get; set; }

    public int? lceIdCliente { get; set; }

    public DateTime? lceDataEmprestimo { get; set; }

    public DateTime? lceDataDevolucao { get; set; }

    public int? lceEntrega { get; set; }

    public virtual Livro id1 { get; set; }

    public virtual Cliente idNavigation { get; set; }
}

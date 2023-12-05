using System;
using System.Collections.Generic;

namespace LivrariaControleEmprestimo.WEB.Models;

public partial class Cliente
{
    public int id { get; set; }

    public string cliCPF { get; set; }

    public string cliNome { get; set; }

    public string cliEndereco { get; set; }

    public string cliCidade { get; set; }

    public string cliBairro { get; set; }

    public string cliNumero { get; set; }

    public string cliTelefoneCelular { get; set; }

    public string cliTelefoneFixo { get; set; }

    public virtual Livro_Cliente_Emprestimo Livro_Cliente_Emprestimo { get; set; }
}

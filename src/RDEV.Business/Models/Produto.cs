using System;
using System.Collections.Generic;
using System.Text;

namespace RDEV.Business.Models
{
    public class Produto
    {
        public Guid FornecedorId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public string Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        /* EF Relations */

        public Fornecedor Fornecedor { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiAcessivel.Api.Shareds.Domain
{
    public class Product
    {
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string? Modelo { get; set; }
        public DateTime DataCriacao { get; set; }
public DateTime DataAlteracao { get; set; }


    }
}

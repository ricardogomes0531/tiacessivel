using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiAcessivel.Api.Shareds.Repository.Querys
{
    public static class ProductQuery
    {
        public static string Insert =>
            @"insert into produto(Nome, Marca, Modelo, DataCriacao, DataAlteracao) values(@Nome, @Marca, @Modelo, @DataCriacao, @DataAlteracao)";
    }
}

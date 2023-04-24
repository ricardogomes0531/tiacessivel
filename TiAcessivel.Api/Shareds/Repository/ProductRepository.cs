using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TiAcessivel.Api.Shareds.Domain;
using TiAcessivel.Api.Shareds.Repository.Querys;

namespace TiAcessivel.Api.Shareds.Repository
{
    public class ProductRepository
    {
        private readonly IDbConnection _connection;
        private readonly IConfiguration _configuration;
        public ProductRepository(
            IConfiguration configuration
            )
        {
            _configuration = configuration;
            _connection = new SqlConnection(_configuration.GetSection("ConnectionStrings").Value);
            _connection.Open();
        }

        public async Task<bool> InsertProduct(Product product)
        {
            var query = await _connection.ExecuteAsync(ProductQuery.Insert, new
            {
                product.Nome,
                product.Marca,
                product.Modelo,
                product.DataCriacao,
                product.DataAlteracao
            }
            );
            if (query > 0)
            {
                return true;
            }
            return false;
                }
    }
}

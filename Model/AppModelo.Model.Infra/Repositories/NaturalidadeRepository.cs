using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;

namespace AppModelo.Model.Infra.Repositories
{
    public class NaturalidadeRepository
    {
        //CRUD - create - read   - update - delete
        //       insert - select - update - delete  
        public bool Inserir(string descricao)
        {
            //string interpolation
            var sql = $"INSERT INTO naturalidade (descricao) VALUES ('{descricao}')";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }
        public bool Atualizar(string descricao)
        {
            var sql = $"UPDATE naturalidade (descricao) VALUES ('{descricao}')";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;

        }
        public bool Remover(string descricao)
        {
            var sql = $"DELETE FROM naturalidade WHERE descricao = ('{descricao}')";
            //var sql = $"DELETE FROM nacionalidades WHERE (descricao) VALUES ('{descricao}')";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);
            return resultado > 0;
        }
        public IEnumerable<NaturalidadeEntity> ObterTodos()
        {
            var sql = "SELECT Id, descricao FROM naturalidade ORDER BY descricao ASC";

            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());

            var resultado = conexaoBd.Query<NaturalidadeEntity>(sql);

            return resultado;
        }
        public NaturalidadeEntity ObterPorId()
        {
            return new NaturalidadeEntity();
        }
    }
}

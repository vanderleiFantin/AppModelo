using AppModelo.Model.Domain.Entities;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModelo.Model.Infra.Repositories
{
    /// <summary>
    /// esse método faz uma inserção no banco de dados com os parâmetros abaixo. 
    /// </summary>
    /// <param name="nome"></param>
    /// <param name="dataNascimento"></param>
    /// <param name="sexo"></param>
    /// <param name="email"></param>
    /// <param name="telefone"></param>
    /// <param name="telefone_contato"></param>
    /// <param name="cep"></param>
    /// <param name="logradouro"></param>
    /// <param name="numero"></param>
    /// <param name="complemento"></param>
    /// <param name="bairro"></param>
    /// <param name="municipio"></param>
    /// <param name="uf"></param>
    /// <param name="nacionalidade"></param>
    /// <param name="naturalidade"></param>
    /// <returns>Cadastro do funcionário</returns>
    public class FuncionariosRepository
    {
        public object DataBases { get; private set; }

        public bool Inserir(string nome, DateTime dataNascimento, bool sexo, string email, string telefone, string telefone_contato, string cep, string logradouro, int numero, string complemento, string bairro, string municipio, string uf, int nacionalidade, int naturalidade)
        {
            var dataConvertida = dataNascimento.ToString("yyyy-MM-dd");

            var sql = $"INSERT INTO funcionarios (nome, data_nascimento, genero, email, telefone, telefone_contato, cep, logradouro, numero, complemento, bairro, municipio, uf, id_nacionalidade, id_naturalidade) VALUES ('{nome}', '{dataConvertida}', {sexo}, '{email}', '{telefone}', '{telefone_contato}', '{cep}', '{logradouro}', {numero}, '{complemento}', '{bairro}', '{municipio}', '{uf}', {nacionalidade}, {naturalidade})";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }
        /// <summary>
        /// Este método exclui o funcionário cadastrado.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Exclui o funcionário cadastrado no banco de dados</returns>
        public bool Remover(int id)
        {
            var sql = $"DELETE FROM funcionario WHERE (id) = ('{id}')";
            using IDbConnection conexaoBd = new MySqlConnection(Databases.MySql.ConectionString());
            var resultado = conexaoBd.Execute(sql);

            return resultado > 0;
        }

        /// <summary>
        /// Este método exibe os funcionários cadastrados em lista.
        /// </summary>
        /// <returns>Mostrar os funcionarios cadastrados na forma de lista no DataGridView</returns>
       
    }
}


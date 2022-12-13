namespace AppModelo.Model.Infra.Databases
{
    public static class MySql
    {
        /// <summary>
        /// Classe destinada a fazer conexão com o banco de dados.
        /// </summary>
        /// <returns>Este método faz conexão com o banco de dados</returns>
        public static string ConectionString()
        {
            var conn = "server=mysql.wwonline.com.br;database=wwonline13;uid=wwonline13;password=aluno22senai;";
            return conn;
        }
    }
}

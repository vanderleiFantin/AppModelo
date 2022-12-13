using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System;
using System.Collections.Generic;

namespace AppModelo.Controller.Cadastros
{
    /// <summary>
    /// Cadastrar - Inserir uma nova Nacionalidade no NacionalidadeRepository.
    /// </summary>
    /// <param name="descricao"></param>
    /// <returns>Insere a Nacionalidade no banco de dados</returns>
    public class NacionalidadeController
    {
        public bool Cadastrar(string descricao)
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.Inserir(descricao);
            return resposta;
        }
        public bool Delete(string descricao)
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.Remover(descricao);
            return resposta;
        }
        public bool Update(string descricao)
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.Atualizar(descricao);
            return (bool)resposta;
        }
        /// <summary>
        /// Método público que retorna uma lista do tipo NacionalidadeEntity
        /// </summary>
        /// <returns>Este método preenche uma lista advinda do NacionalidadeRepository</returns>
        public List<NacionalidadeEntity> ObterTodasNacionalidades()
        {
            var repositorio = new NacionalidadeRepository();
            var resposta = repositorio.ObterTodos();
            return (List<NacionalidadeEntity>)resposta;
        }

        public object Update(int idAtual, string text)
        {
            throw new NotImplementedException();
        }
    }
}

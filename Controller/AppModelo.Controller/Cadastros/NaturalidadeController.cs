using AppModelo.Model.Domain.Entities;
using AppModelo.Model.Infra.Repositories;
using System;
using System.Collections.Generic;

namespace AppModelo.Controller.Cadastros
{
    public class NaturalidadeController
    {
        /// <summary>
        /// Cadastrar - Inserir uma nova Naturalidade no NaturalidadeRepository.
        /// </summary>
        /// <param name="descricao"></param>
        /// <param name="status"></param>
        /// <returns>Insere a Naturalidade no banco de dados</returns>
        public List<NaturalidadeEntity> DataSource { get; set; }

        public bool Cadastrar(string descricao)
        {
            //quero colocar um botao de ativo e quero que avise se ja possui esse cadastro

            //var naturalidade = repositorio.ObterTodos(descricao);
           // if(naturalidade is not null) return false;
            var repositorio = new NaturalidadeRepository();
            
            var resposta = repositorio.Inserir(descricao);
            return resposta;
        }
        public bool Delete(string descricao)
        {
            var repositorio = new NaturalidadeRepository();
            var resposta = repositorio.Remover(descricao);
            return resposta;
        }
        public bool Update(string descricao)
        {
            var repositorio = new NaturalidadeRepository();
            var resposta = repositorio.Atualizar(descricao);
            return resposta;
        }

        public List<NaturalidadeEntity> ObterTodasNaturalidades()
        {
            var repositorio = new NaturalidadeRepository();
            var resposta = repositorio.ObterTodos();
            return (List<NaturalidadeEntity>)resposta;
        }

        
    }
}

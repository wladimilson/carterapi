using System;
using System.Linq;
using System.Collections.Generic;
using CarterAPI.Models;

namespace CarterAPI.Repositories
{
    public class PessoaRepository
    {
        private static Dictionary<int, Pessoa> pessoas = new Dictionary<int, Pessoa>();

        public List<Pessoa> GetAll(){
            return pessoas.Values.ToList();
        }

        public Pessoa Get(int id){
            return pessoas.GetValueOrDefault(id);
        }

        public void Add(Pessoa pessoa){
            pessoas.Add(pessoa.Id, pessoa);
        }

        public void Edit(Pessoa pessoa){
            pessoas.Remove(pessoa.Id);
            pessoas.Add(pessoa.Id, pessoa);
        }

        public void Delete(int id){
            pessoas.Remove(id);
        }
    }
}
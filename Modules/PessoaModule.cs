using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;
using Carter;
using Carter.ModelBinding;
using Carter.Request;
using Carter.Response;
using CarterAPI.Repositories;
using CarterAPI.Models;
using CarterAPI.OpenApi.PessoaEndpoint;

namespace CarterAPI.Modules
{
    public class PessoaModule : CarterModule
    {
        public readonly PessoaRepository repository;
        public PessoaModule()
        {
            repository = new PessoaRepository();
            Get<GetPessoa>("/pessoa/", (req, res) => {
                var pessoas = repository.GetAll();
                return res.AsJson(pessoas);
            });
            Get<GetPessoaById>("/pessoa/{id:int}", (req, res) =>
            {
                var id = req.RouteValues.As<int>("id");
                var pessoa = repository.Get(id);
                if(pessoa == null)
                {
                    res.StatusCode = 404;
                    return Task.CompletedTask;
                }
                return res.Negotiate(pessoa);
            });
            Post<PostPessoa>("/pessoa/", async (req, res) =>
            {
                var pessoa = await req.Bind<Pessoa>();

                repository.Add(pessoa);

                res.StatusCode = 201;
                await res.Negotiate(pessoa);
                return;
            });
            Put<PutPessoa>("/pessoa/{id:int}", async (req, res) =>
            {
                var pessoa = await req.Bind<Pessoa>();

                pessoa.Id = req.RouteValues.As<int>("id");

                repository.Edit(pessoa);

                res.StatusCode = 204;
                return;
            });
            Delete<DeletePessoa>("/pessoa/{id:int}", (req, res) =>
            {
                var id = req.RouteValues.As<int>("id");
                repository.Delete(id);
                res.StatusCode = 204;
                return Task.CompletedTask;
            });
        }
    }
}
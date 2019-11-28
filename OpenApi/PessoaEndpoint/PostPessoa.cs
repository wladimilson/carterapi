using System;
using Carter.OpenApi;
using CarterAPI.Models;

namespace CarterAPI.OpenApi.PessoaEndpoint
{
    public class PostPessoa: RouteMetaData
    {
        public override string Tag { get; } = "Pessoa";
        public override string Description { get; } = "Adiciona uma pessoa";
        
        public override RouteMetaDataRequest[] Requests { get; } =
        {
            new RouteMetaDataRequest
            {
                Request = typeof(Pessoa),
            }
        };

        public override RouteMetaDataResponse[] Responses { get; } = 
        { 
            new RouteMetaDataResponse 
            { 
                Code = 204, 
                Description = "Pessoa adicionada" 
            }
        };
        public override string OperationId { get; } = "Pessoa_PostPessoa";
    }
}
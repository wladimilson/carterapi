using System;
using Carter.OpenApi;
using CarterAPI.Models;

namespace CarterAPI.OpenApi.PessoaEndpoint
{
    public class PutPessoa: RouteMetaData
    {
        public override string Tag { get; } = "Pessoa";
        public override string Description { get; } = "Atualiza uma pessoa";
        
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
                Description = "Pessoa atualizada" 
            }
        };
        public override string OperationId { get; } = "Pessoa_PutPessoa";
    }
}
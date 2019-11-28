using System;
using Carter.OpenApi;
using CarterAPI.Models;

namespace CarterAPI.OpenApi.PessoaEndpoint
{
    public class DeletePessoa: RouteMetaData
    {
        public override string Tag { get; } = "Pessoa";
        public override string Description { get; } = "Exclui uma pessoa";

        public override RouteMetaDataResponse[] Responses { get; } = 
        { 
            new RouteMetaDataResponse 
            { 
                Code = 204, 
                Description = "Exclui Pessoa" 
            }
        };

        public override string OperationId { get; } = "Pessoa_DeletePessoa";
    }
}
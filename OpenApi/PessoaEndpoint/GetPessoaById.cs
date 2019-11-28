using System;
using Carter.OpenApi;
using CarterAPI.Models;

namespace CarterAPI.OpenApi.PessoaEndpoint
{
    public class GetPessoaById: RouteMetaData
    {
        public override string Tag { get; } = "Pessoa";
        public override string Description { get; } = "Obtém pessoa pelo id";

        public override RouteMetaDataResponse[] Responses { get; } =
        {
            new RouteMetaDataResponse
            {
                Code = 200, 
                Description = $"Uma Pessooa",
                Response = typeof(Pessoa)
            },
            new RouteMetaDataResponse
            {
                Code = 404,
                Description = $"Pessoa não encontrada"
            }
        };

        public override string OperationId { get; } = "Pessoa_GetPessoaById";
    }
}
using System;
using System.Collections.Generic;
using Carter.OpenApi;
using CarterAPI.Models;

namespace CarterAPI.OpenApi.PessoaEndpoint
{
    public class GetPessoa : RouteMetaData
    {
        public override string Tag { get; } = "Pessoa";
        public override string Description { get; } = "Retorna uma lista de pessoas";

        public override RouteMetaDataResponse[] Responses { get; } =
        {
            new RouteMetaDataResponse
            {
                Code = 200,
                Description = $"Uma lista de Pessoas",
                Response = typeof(IEnumerable<Pessoa>)
            }
        };

        public override string OperationId { get; } = "Pessoa_GetPessoa";
    }
}
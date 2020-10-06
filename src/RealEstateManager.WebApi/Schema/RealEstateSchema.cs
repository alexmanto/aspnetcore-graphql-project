using GraphQL.Utilities;
using RealEstateManager.WebApi.Mutations;
using RealEstateManager.WebApi.Queries;
using System;

namespace RealEstateManager.WebApi.Schema
{
    public class RealEstateSchema : GraphQL.Types.Schema
    {
        public RealEstateSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetRequiredService<PropertyQuery>();
            //Mutation = serviceProvider.GetRequiredService<PropertyMutation>();
        }
    }
}
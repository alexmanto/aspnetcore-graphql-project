using GraphQL.Utilities;
using RealEstateManager.WebApi.Queries;
using System;

namespace RealEstateManager.WebApi.Schema
{
    public class RealEstateSchema : GraphQL.Types.Schema
    {
        public RealEstateSchema(IServiceProvider provider)
            : base(provider)
        {
            Query = provider.GetRequiredService<PropertyQuery>();
        }
    }
}
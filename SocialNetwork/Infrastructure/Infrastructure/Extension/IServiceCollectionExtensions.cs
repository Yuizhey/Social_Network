

using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Extension;

public static class IServiceCollectionExtensions
{
    public static void AddInfrastructureLayer(this IServiceCollection collection)
    {
        collection.AddServices();
    }

    private static void AddServices(this IServiceCollection sericeCollection)
    {
        sericeCollection.AddTransient<IMediator, Mediator>();
    }
}
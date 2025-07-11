using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace TicketFlow.BuildingBlocks.Application.Abstractions;

public interface IInstaller
{
    void InstallerServices(IServiceCollection services, IConfiguration configuration);
}

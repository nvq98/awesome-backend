using OneOf;
using OneOf.Types;

namespace TicketFlow.BuildingBlocks.Application.Abstractions;

public interface IUnitOfWork
{
    Task<OneOf<None, Exception>> SaveChangesAsync(CancellationToken token = default);
}

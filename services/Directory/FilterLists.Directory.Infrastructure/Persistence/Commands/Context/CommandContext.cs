namespace FilterLists.Directory.Infrastructure.Persistence.Commands.Context;

internal class CommandContext : ICommandContext, IAsyncDisposable
{
    private readonly CommandDbContext _dbContext;

    public CommandContext(CommandDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async ValueTask DisposeAsync()
    {
        await _dbContext.DisposeAsync();
    }
}

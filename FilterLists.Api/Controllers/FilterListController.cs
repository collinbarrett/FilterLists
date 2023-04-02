using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FilterLists.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class FilterListController : ControllerBase
{
    private readonly FilterListsDbContext _dbContext;

    private readonly ILogger<FilterListController> _logger;

    public FilterListController(ILogger<FilterListController> logger, FilterListsDbContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<string?> Get(int id)
    {
        var list = await _dbContext.FilterLists.Where(f => f.Id == id).Include(f => f.ViewUrls)
            .SingleOrDefaultAsync(f => f.Id == id);
        return list?.ViewUrls.FirstOrDefault()?.Url.AbsoluteUri;
    }
}
using Hangfire.Dashboard;

namespace FilterLists.Archival.Infrastructure.Scheduling
{
    public class DashboardAuthorizationFilter : IDashboardAuthorizationFilter
    {
        public bool Authorize(DashboardContext context)
        {
            return true;
        }
    }
}

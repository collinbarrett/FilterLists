using MediatR;

namespace FilterLists.Agent.ListArchiver.Events
{
    public class ListReadyForCapture : INotification
    {
        public ListReadyForCapture(FilterList filterList)
        {
            FilterList = filterList;
        }

        public FilterList FilterList { get; }
    }
}
using MediatR;

namespace FilterLists.Agent.ListArchiver.Events
{
    public class ListReadyForCapture : INotification
    {
        public ListReadyForCapture(ListInfo listInfo)
        {
            ListInfo = listInfo;
        }

        public ListInfo ListInfo { get; }
    }
}
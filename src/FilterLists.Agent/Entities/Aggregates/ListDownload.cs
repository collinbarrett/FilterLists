using System.Net.Http;

namespace FilterLists.Agent.Entities.Aggregates
{
    public class ListDownload
    {
        public ListDownload(ListInfo listInfo, HttpResponseMessage httpResponseMessage)
        {
            ListInfo = listInfo;
            HttpResponseMessage = httpResponseMessage;
        }

        public ListInfo ListInfo { get; }

        public HttpResponseMessage HttpResponseMessage { get; }
    }
}
using System.Net.Http;

public class AgentHttpClient
{
    public AgentHttpClient(HttpClient client)
    {
        Client = client;
    }

    public HttpClient Client { get; }
}
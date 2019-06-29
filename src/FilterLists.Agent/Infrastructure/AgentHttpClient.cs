using System;
using System.Net.Http;

public class AgentHttpClient
{
    public AgentHttpClient(HttpClient client)
    {
        Client = client;
        Client.Timeout = TimeSpan.FromMinutes(10);
    }

    public HttpClient Client { get; }
}
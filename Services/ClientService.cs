using System;
using System.Linq;

public class ClientService
{
    Client client = new Client();
    Prospect prospect = new Prospect();

    public void RegisterNumber()
    {
        int total;

        int numClient = client.ClientList.Count();
        int numProspect = prospect.ProspectList.Count();

        total = numClient + numProspect;

        Console.WriteLine(total);
    }
}
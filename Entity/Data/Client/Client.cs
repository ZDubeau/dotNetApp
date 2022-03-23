using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Diagnostics;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
#pragma warning disable CA1050 // Declare types in namespaces
public class Client : IClient

#pragma warning restore CA1050 // Declare types in namespaces
{
    public long Id { get; set; }
    public string Lastname { get; set; }
    public string Firstname { get; set; }
    public ClientType ClientTypes { get; set; }
    public ICollection<Factor> Factors { get; set; }
#nullable disable
    public ICollection<Coordinate> ClientCoordinate { get; set; }
    public List<string> ClientList = new();

    // Constructor
    public Client() { }

    public Client(long id, string lastname, string firstname, ClientType clientTypes, ICollection<Factor> factors, ICollection<Coordinate> clientCoordinate, List<string> clientList)
    {
        Id = id;
        Lastname = lastname;
        Firstname = firstname;
        ClientTypes = clientTypes;
        Factors = factors;
        ClientCoordinate = clientCoordinate;
        ClientList = clientList;
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
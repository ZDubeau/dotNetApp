
using System.Diagnostics;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class Coordinate : ICoordinate
{
    public long Id { get; set; }
    public string Tel { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }
    public Client Clients { get; set; }

    // Constructor
    public Coordinate() { }

    public Coordinate(long id, string tel, string address, string email, Client clients)
    {
        Id = id;
        Tel = tel;
        Address = address;
        Email = email;
        Clients = clients;
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
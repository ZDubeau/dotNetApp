using System.Collections.Generic;
public class Client
{
    public long Id { get; set; }

    public string Lastname { get; set; }

    public string Firstname { get; set; }

    public ClientType ClientTypes { get; set; }

    public ICollection<Factor> Factors { get; set; }

    public ICollection<Coordinate> ClientCoordinate { get; set; }

    public List<string> ClientList = new List<string>();
}
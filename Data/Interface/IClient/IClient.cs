using System.Collections.Generic;

public interface IClient
{
    long Id { get; set; }
    string Lastname { get; set; }
    string Firstname { get; set; }
    ClientType ClientTypes { get; set; }
    ICollection<Factor> Factors { get; set; }
    ICollection<Coordinate> ClientCoordinate { get; set; }
}
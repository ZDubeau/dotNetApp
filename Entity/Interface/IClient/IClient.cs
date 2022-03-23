using System.Collections.Generic;

[System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1050:Declare types in namespaces", Justification = "<Pending>")]
public interface IClient
{
    long Id { get; set; }
    string Lastname { get; set; }
    string Firstname { get; set; }
    ClientType ClientTypes { get; set; }
    ICollection<Factor> Factors { get; set; }
    ICollection<Coordinate> ClientCoordinate { get; set; }
}
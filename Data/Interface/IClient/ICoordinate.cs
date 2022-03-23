
[System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1050:Declare types in namespaces", Justification = "<Pending>")]
public interface ICoordinate
{
    long Id { get; set; }
    string Tel { get; set; }
    string Address { get; set; }
    string Email { get; set; }
    Client Clients { get; set; }
}
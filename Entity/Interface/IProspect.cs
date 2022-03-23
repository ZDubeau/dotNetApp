using System;

public interface IProspect
{
    long Id { get; set; }
    string Lastname { get; set; }
    string Firstname { get; set; }
    string Tel { get; set; }
    string Address { get; set; }
    DateTime ContactDate { get; set; }
    Offer Offers { get; set; }
}
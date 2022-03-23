using System;

public interface IFactor
{
    long Id { get; set; }
    int Amount { get; set; }
    DateTime IssueDate { get; set; }
    DateTime PaymentDate { get; set; }
    string Status { get; set; }
    Client Clients { get; set; }
    Offer Offers { get; set; }
}
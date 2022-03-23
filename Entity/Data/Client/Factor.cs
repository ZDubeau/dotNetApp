using System;
using System.Collections.Generic;
using System.Diagnostics;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class Factor : IFactor
{
    public long Id { get; set; }
    public int Amount { get; set; }
    public DateTime IssueDate { get; set; }
    public DateTime PaymentDate { get; set; }
    public string Status { get; set; }

    public Client Clients { get; set; }
    public Offer Offers { get; set; }
    public List<string> FactorList = new List<string>();

    // Constructor
    public Factor() { }

    public Factor(long id, int amount, DateTime issueDate, DateTime paymentDate, string status, Client clients, Offer offers, List<string> factorList)
    {
        Id = id;
        Amount = amount;
        IssueDate = issueDate;
        PaymentDate = paymentDate;
        Status = status;
        Clients = clients;
        Offers = offers;
        FactorList = factorList;
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
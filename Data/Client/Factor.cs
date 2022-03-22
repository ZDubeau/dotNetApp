using System;
using System.Collections.Generic;

public class Factor
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
}
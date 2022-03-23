using System;
using System.Collections.Generic;
using System.Diagnostics;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class Prospect : IProspect
{
    public long Id { get; set; }
    public string Lastname { get; set; }
    public string Firstname { get; set; }
    public string Tel { get; set; }
    public string Address { get; set; }
    public DateTime ContactDate { get; set; }
    

    public Offer Offers { get; set; }

    // Constructor
    public Prospect() { }

    public Prospect(long id, string lastname, string firstname, string tel, string address, DateTime contactDate, Offer offers)
    {
        Id = id;
        Lastname = lastname;
        Firstname = firstname;
        Tel = tel;
        Address = address;
        ContactDate = contactDate;
        Offers = offers;
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
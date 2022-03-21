using System;
using System.Collections.Generic;
public class Offer
{

    public long Id { get; set; }

    public string Lastname { get; set; }

    public int Amount { get; set; }

    public DateTime ValidityDate { get; set; }

    public ICollection<Factor> Factors { get; set; }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class Offer : IOffer
{
    public long Id { get; set; }
    public string Lastname { get; set; }
    public int Amount { get; set; }
    public DateTime ValidityDate { get; set; }
    public ICollection<Factor> Factors { get; set; }

    public Prospect prospects { get; set; }

    // Constructor
    public Offer() { }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
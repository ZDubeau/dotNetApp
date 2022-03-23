using System;
using System.Collections.Generic;

public interface IOffer
{
    long Id { get; set; }
    string Lastname { get; set; }
    int Amount { get; set; }
    DateTime ValidityDate { get; set; }
    ICollection<Factor> Factors { get; set; }
    Prospect prospects { get; set; }
}
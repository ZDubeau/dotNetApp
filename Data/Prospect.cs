using System;
using System.Collections.Generic;

public class Prospect
{
    public long Id { get; set; }

    public string Lastname { get; set; }

    public string Firstname { get; set; }

    public string Tel { get; set; }

    public string Address { get; set; }

    public DateTime ContactDate { get; set; }

    public List<string> ProspectList = new List<string>();
}
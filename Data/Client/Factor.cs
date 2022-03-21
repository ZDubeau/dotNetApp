
public class Factor {

    public long Id { get; set; }

    public int Amount { get; set; }

    public Date IssueDate { get; set; }

    public Date PaymentDate { get; set; }

    public string Status { get; set; }

    public Client Clients { get; set; }

    public Offer Offers { get; set; }
}
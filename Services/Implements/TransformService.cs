using System;

namespace dotNetApp.Services.Implements
{
    public class TransformService
    {
        Client client = new Client();
        Prospect prospect = new Prospect();
        Offer offer = new Offer();
        string isAccepted = "Accepted";
        string factorStatus = new Factor().Status;

        DateTime yesterday = DateTime.Now.Date.AddDays(-1);

        public void TransformPtC()
        {
            if (prospect.ContactDate >= yesterday
                && prospect.Offers.Factors != null
                && factorStatus == isAccepted)
            {
                Console.WriteLine("Transform Prospect to Client");

            }
        }
    }
}
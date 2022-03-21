using System;

namespace dotNetApp.Services
{
    public class FactorService
    {
        Client client = new Client();
        Factor factor = new Factor();

        public void Payed()
        {
            factor.Clients.Equals(true);
            factor.Status = "paid";

            string paid = factor.Status;
            if (paid.Equals(true))
            {
                Console.WriteLine(paid);
            }
        }
    }
}
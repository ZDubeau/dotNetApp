using System;

namespace dotNetApp.Services.Implements
{
    public class FactorService
    {
        Client client = new Client();
        Factor factor = new Factor();

        public void AllPaid()
        {
            if (factor.Clients != null)
            {
                // factor.Status = "paid";
                string paid = factor.Status;

                if (paid == "paid")
                {
                    Console.WriteLine(paid);
                }
            }
        }
    }
}
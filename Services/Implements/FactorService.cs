using System;
using dotNetApp.Services.Interface;

namespace dotNetApp.Services.Implements
{
    public class FactorService : IFactorService
    {
        Client client = new Client();
        Factor factor = new Factor();

        public void AllPaid()
        {
            if (factor.Clients != null)
            {
                string paid = factor.Status;

                if (paid == "paid")
                {
                    Console.WriteLine(paid);
                }
            }
        }
    }
}
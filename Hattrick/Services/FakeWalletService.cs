using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Hattrick.Models;

namespace Hattrick.Services
{
    public class FakeWalletService : WalletService
    {
        public Task<Wallet[]> GetIncompleteItemsAsync()
        {
            var novcanik = new Wallet
            {
                Title = "Novcanik",
                Value = 1000
            };



            return Task.FromResult(new[] { novcanik
    });
        }
    }
}
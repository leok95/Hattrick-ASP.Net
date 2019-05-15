using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Hattrick.Models;

namespace Hattrick.Services
{
    public interface WalletService
    {
        Task<Wallet[]> GetIncompleteItemsAsync();
    }
}
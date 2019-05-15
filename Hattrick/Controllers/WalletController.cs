using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Hattrick.Services;
using Hattrick.Models;

namespace Hattrick.Controllers
{
    public class WalletController : Controller
    {
        private readonly WalletService _walletService;

        public WalletController(WalletService walletService)
        {
            _walletService = walletService;
        }

        public async Task<IActionResult> Index()
        {
            var items = await _walletService.GetIncompleteItemsAsync();

            var model = new ViewModel()
            {
                Items = items
            };

            return View(model);
        }
    }
}
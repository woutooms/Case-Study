using Cardio.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Contentful.Core;
using Contentful.Core.Models;
using Contentful.Core.Search;
using Microsoft.AspNetCore.Http.Extensions;

namespace Cardio.Controllers
{
    public class HomeController : Controller{
        private readonly ILogger<HomeController> _logger;
        private readonly IContentfulClient _client;

        public HomeController(ILogger<HomeController> logger, IContentfulClient client)
        {
            _logger = logger;
            _client = client;
        }

        public async Task<IActionResult> Index()
        {
            var cardio = await _client.GetEntries<CardioModel>();

            return View(cardio);
        }


        public async Task<IActionResult> Week1()
        {
            var cardio = await _client.GetEntries<CardioModel>();

            List<CardioModel> cardioModels = new List<CardioModel>();

            foreach (var model in cardio){
                if(model.Session == 1){
                    cardioModels.Add(model);
                }
            }
            return View(cardioModels.ToArray());
        }

        public async Task<IActionResult> Week2()
        {
            var cardio = await _client.GetEntries<CardioModel>();

            List<CardioModel> cardioModels = new List<CardioModel>();

            foreach (var model in cardio){
                if(model.Session == 2){
                    cardioModels.Add(model);
                }
            }
            
            return View(cardioModels.ToArray());
        }

        public async Task<IActionResult> Week3()
        {
            var cardio = await _client.GetEntries<CardioModel>();

            List<CardioModel> cardioModels = new List<CardioModel>();

            foreach (var model in cardio){
                if(model.Session == 3){
                    cardioModels.Add(model);
                }
            }
            
            return View(cardioModels.ToArray());
        }

        public async Task<IActionResult> Week4()
        {
            var cardio = await _client.GetEntries<CardioModel>();

            List<CardioModel> cardioModels = new List<CardioModel>();

            foreach (var model in cardio){
                if(model.Session == 4){
                    cardioModels.Add(model);
                }
            }
            
            return View(cardioModels.ToArray());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
                public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }

}

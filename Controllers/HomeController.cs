using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebItProject.Data;
using WebItProject.Models;
using WebItProject.ViewModels;

namespace WebItProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyContext _dbContext;
        private readonly IMapper _mapper;

        public HomeController(ILogger<HomeController> logger, MyContext myContext, IMapper mapper)
        {
            _logger = logger;
            _dbContext = myContext;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var data = _dbContext.SubscriptionTypes
                .ToList()//ilginç
                .Select(x => _mapper.Map<SubscriptionTypeViewModel>(x))
                .OrderBy(x => x.Price)
                .ToList();
            return View(data);
        }
    }
}

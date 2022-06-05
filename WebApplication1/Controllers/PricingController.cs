using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DAL;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class PricingController : Controller
    {
        private readonly AppDbContext _context;
        public PricingController(AppDbContext context)
        {
            _context = context;
        }
        //public IActionResult Index()
        //{
            
        //    return View(_context.Plans.Include(p => p.PlansFeatureItems).ThenInclude(pf => pf.FeatureItems).ToList());
        //}

        public async Task<IActionResult> Index()
        {
            List<FeatureItems> featureItems = await _context.FeatureItems.ToListAsync();
            List<Plans> plans = await _context.Plans.Include(p => p.PlansFeatureItems).ToListAsync();

            PricingViewModel pricingViewModel = new PricingViewModel()
            {
                FeatureItems = featureItems,
                Plans = plans
            };
            return View(pricingViewModel);
        }
    }
}

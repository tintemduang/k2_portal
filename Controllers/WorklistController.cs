using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using K2Portal.Models;
using K2Portal.Services;

namespace K2Portal.Controllers
{
    public class WorklistController : Controller
    {
        private readonly K2ApiService _k2ApiService;

        public WorklistController(K2ApiService k2ApiService)
        {
            _k2ApiService = k2ApiService;
        }

        public async Task<IActionResult> Index()
        {
            var worklist = await _k2ApiService.GetWorklist("41837");
            return View(worklist);
        }
    }
}
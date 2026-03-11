using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using K2Portal.Models;
using K2Portal.Services;

namespace K2Portal.Controllers
{
    public class HomeController : Controller
    {
        private readonly K2ApiService _k2ApiService;

        public HomeController(K2ApiService k2ApiService)
        {
            _k2ApiService = k2ApiService;
        }

        public async Task<IActionResult> Index()
        {
            var tasks = await _k2ApiService.GetK2Tasks();

            var sortedTasks = tasks
                .OrderByDescending(x => x.TaskStartDate)
                .ToList();

            return View(sortedTasks);
        }

        public async Task<IActionResult> K2Worklist()
        {
            var worklist = await _k2ApiService.GetWorklist("41837");
            return View(worklist);
        }
        public async Task<IActionResult> K2Tasks()
        {
            var tasks = await _k2ApiService.GetK2Tasks();
            return View(tasks);
        }
    }
}
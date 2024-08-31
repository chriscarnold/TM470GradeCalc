using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using TM470GradeCalc.Data;
using TM470GradeCalc.Models;

namespace TM470GradeCalc.Controllers
{
    public class HomeController : Controller
    {
        private readonly TM470Context _context;

        public HomeController(TM470Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Calculate(TM470GradeCalc.Models.GradeCalc model)
        {
            model.CalculationDate = DateTime.Now;
            double finalGrade = model.CalculateFinalGrade();
            _context.TM470Grades.Add(model);
            await _context.SaveChangesAsync();

            ViewBag.FinalGrade = finalGrade;
            ViewBag.Classification = model.GetGradeClassification(finalGrade);
            return View("Result");
        }

        [HttpGet]
        public async Task<IActionResult> Progression()
        {
            var results = await _context.TM470Grades.OrderBy(g => g.CalculationDate).ToListAsync();
            return View(results);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

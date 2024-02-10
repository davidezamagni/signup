using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using zamagni.davide._5i.Models;

namespace zamagni.davide._5i.Controllers;

public class HomeController : Controller
{
    private static List<Prodotto> Prodotti = new List<Prodotto>();
    private readonly ILogger<HomeController> _logger;
    private dbContext db = new dbContext();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpGet]
    public IActionResult SignUp()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Conferma(Prenotazione p)
    {
        db.Prenotaziones.Add(p);
        db.SaveChanges();
        return View(p);
    }

    public IActionResult Purchase()
    {
        return View();
    }

    public IActionResult Cart(Prodotto p)
    {
        Prodotti.Add(p);
        return View(Prodotti);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

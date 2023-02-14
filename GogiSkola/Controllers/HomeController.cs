using GogiSkola.Models;
using GogiSkola.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GogiSkola.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public List<Polaznik> Polaznici = new List<Polaznik> {
            new Polaznik
            {
                FullName = "Damir Majetić",
                Bio = "Godište: 2012. Član akademije Jedinstvo",
                ProfileURL = "../Images/Players/player1.jpg"
            },
            new Polaznik
            {
                FullName = "Mensur Mehić",
                Bio = "Godište: 2007. Član FK Jezerski",
                ProfileURL = "../Images/Players/player2.jpg"
            },
            new Polaznik
            {
                FullName = "Imran Bajrić",
                Bio = "Godište: 2013. Član akademije Jedinstvo",
                ProfileURL = "../Images/Players/player3.jpg"
            },
            new Polaznik
            {
                FullName = "Emir Hažiabdić",
                Bio = "Godište: 2013. Član NK Jedinstvo Bihać",
                ProfileURL = "../Images/Players/player4.jpg"
            },
            new Polaznik
            {
                FullName = "Naid Gagić",
                Bio = "Godište: 2013. Član škole 3E",
                ProfileURL = "../Images/Players/player5.jpg"
            },
            new Polaznik
            {
                FullName = "Tarik Hasimbegović",
                Bio = "Godište: 2007. Član NK Radnički Ripač",
                ProfileURL = "../Images/Players/player6.jpg"
            },
            new Polaznik
            {
                FullName = "Nilhan Begić",
                Bio = "Godište: 2011. Član akademije Jedinstvo",
                ProfileURL = "../Images/Players/player7.jpg"
            },
            new Polaznik
            {
                FullName = "Ali Ljubijankić",
                Bio = "Godište: 2015. Član akademije Jedinstvo",
                ProfileURL = "../Images/Players/player8.jpg"
            },
            new Polaznik
            {
                FullName = "Ajdin Kanurić",
                Bio = "Godište: 2007.",
                ProfileURL = "../Images/Players/player9.jpg"
            },
            new Polaznik
            {
                FullName = "Ishak Saltaga",
                Bio = "Godište: 2014.",
                ProfileURL = "../Images/Players/player10.jpg"
            }
        };

       

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var ViewModel = new HomePageViewModel
            {
                Polaznici = Polaznici
            };

            return View(ViewModel);
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
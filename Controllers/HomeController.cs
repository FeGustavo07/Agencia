using Agencia.Models;
using Microsoft.AspNetCore.Mvc;



namespace Agencia.Controllers
{
    public class HomeController : Controller
    {


        private Context _context;

        public HomeController(Context context)
        {
            _context = context;
        }


        public IActionResult Index()
        { 
            return View();
        }


        [HttpPost]

        public IActionResult Index(Clientes usuario)
        {
           
            if (usuario.Email != null)
            {
                return View("Destinos");
               
            }
            else
            {
                return View("Index");
            }
        }

        public IActionResult Destinos()
        {
            return View();
        }

        public IActionResult Promocoes()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Clientes cliente)
        {
            _context.Add(cliente);
            _context.SaveChanges();
            return View("Destinos");
        }

        [HttpPost]
        public IActionResult Contato(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();
            return View();
        }



    }
}

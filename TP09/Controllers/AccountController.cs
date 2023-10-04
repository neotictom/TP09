using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP09.Models;

namespace TP09.Controllers;

public class AccountController : Controller
{
    private readonly ILogger<AccountController> _logger;

    public AccountController(ILogger<AccountController> logger)
    {
        _logger = logger;
    }
    public IActionResult Login(){
        return View();
    }
    public IActionResult Registro(){
        return View();
    }
    public IActionResult GuardarCuenta(Usuario user)
    {
       
        BD.AgregarUsuario(user);    
        return View("Bienvenida");
        
    }
    public IActionResult Bienvenida(){
        return View();
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



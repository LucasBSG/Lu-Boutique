using Microsoft.AspNetCore.Mvc;
using LuBoutique.Models;

namespace LuBoutique.Controllers;

public class AccountController : Controller
{
    private readonly ILogger<AccountController> _logger;

    public AccountController(ILogger<AccountController> logger)
    {
        _logger = logger;
    }

    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            // TODO: Implementar autenticação real com banco de dados (Por enquanto, apenas redireciona para home)
            _logger.LogInformation("Tentativa de login para: {Email}", model.Email);
            return RedirectToAction("Index", "Home");
        }
        
        return View(model);
    }

    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(RegisterViewModel model)
    {
        if (ModelState.IsValid)
        {
            // TODO: Implementar cadastro real com banco de dados (Por enquanto, apenas redireciona para login)
            _logger.LogInformation("Novo cadastro para: {Email}", model.Email);
            return RedirectToAction("Login");
        }
        
        return View(model);
    }

    public IActionResult Logout()
    {
        // TODO: Implementar logout real
        _logger.LogInformation("Usuário fez logout");
        return RedirectToAction("Index", "Home");
    }
}

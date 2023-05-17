using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Rastreamento.Models;

namespace Rastreamento.Controllers;

public class ListarController : Controller
{
    private readonly ILogger<ListarController> _logger;

    public ListarController(ILogger<ListarController> logger)
    {
        _logger = logger;
    }

    public IActionResult Funcionario()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
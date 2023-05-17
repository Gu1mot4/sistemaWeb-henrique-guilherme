﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Rastreamento.Models;

namespace Rastreamento.Controllers;

public class CadastroController : Controller
{
    private readonly ILogger<CadastroController> _logger;

    public CadastroController(ILogger<CadastroController> logger)
    {
        _logger = logger;
    }

    public IActionResult CadastroVeiculo()
    {
        return View();
    }

    public IActionResult CadastroFuncionario()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}


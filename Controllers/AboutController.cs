
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SezwanNew.Models;

namespace SezwanNew.Controllers;

public class AboutController: Controller
{
    
    public IActionResult Index()
    {
        return View();
    }
    
}
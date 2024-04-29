using Microsoft.AspNetCore.Mvc;
using SezwanNew.Models;

namespace SezwanNew.Controllers;

public class SalesController: Controller
{
    public IActionResult Index()
    {
        return View();
    }
    
    
    
}
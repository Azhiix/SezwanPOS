using Microsoft.AspNetCore.Mvc;
using SezwanNew.Models;


namespace SezwanNew.Controllers;

public class ReportsController: Controller
{
    
    public IActionResult Index()
    {
        return View();
    }
    
}
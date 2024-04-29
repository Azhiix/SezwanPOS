using Microsoft.AspNetCore.Mvc;
using SezwanNew.Models;




namespace SezwanNew.Controllers;


public class LoginController:Controller
{
    
    public  IActionResult Index()
    {
        return View();
    }
    
}
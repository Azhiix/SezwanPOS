using Microsoft.AspNetCore.Mvc;
using SezwanNew.Models;




namespace SezwanNew.Controllers;


public class LoginController:Controller
{
    
    public  IActionResult Index()
    {
        return View();
    }
    
    public static List<User> Users = new List<User>();
    
    [HttpPost]
    public IActionResult Index(User user)
    {
        if (ModelState.IsValid)
        {
            Users.Add(user);
            return RedirectToAction("Index");
        }
        return View(user);
    }
    
}
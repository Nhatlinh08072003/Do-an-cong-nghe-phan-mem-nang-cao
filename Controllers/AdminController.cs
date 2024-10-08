using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Dream_Bridge.Models;

namespace Dream_Bridge.Controllers;

public class AdminController : Controller
{
    private readonly ILogger<AdminController> _logger;

    public AdminController(ILogger<AdminController> logger)
    {
        _logger = logger;
    }
    public IActionResult QLTaikhoan()
    {
        return View();
    }

    public IActionResult QLTintuc()
    {
        return View();
    }
    public IActionResult QLTruong()
    {
        return View();
    }
    public IActionResult TQuan()
    {
        return View();
    }
    public IActionResult QLTuvan()
    {
        return View();
    }
 public IActionResult QLDuHoc()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

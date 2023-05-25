using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstApp.Models;

namespace FirstApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var List=new List<StudentVm>(){
            new StudentVm(){Id=1,Name="one",Address="address1"},
            new StudentVm(){Id=2,Name="two",Address="address2"}
        };
        return View(List);

    }
    public IActionResult Test(){
        return View();
    }
    public IActionResult New(){
        return View();
    }
    public IActionResult New(TestVm){
        return View(new TestVm());
    }
    
    [HttpPost]
 public IActionResult New(TestVm){
return Ok(vm);
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

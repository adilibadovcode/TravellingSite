using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;
using TravellingSite.Contexts;
using TravellingSite.ViewModel.DestinationVM;
using TravellingSite.Models;

namespace TravellingSite.Areas.Admin.Controllers;

[Area("Admin")]
public class DestionationController : Controller
{
    TravelDBContext _db { get; }

    public DestionationController(TravelDBContext db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        return View();
    }

    public async Task<IActionResult> Create()
    {
        return View();
    }

    [HttpPost]

    public async Task<IActionResult> Create(DestinationCreateVM vm)
    {
        Destionation destionation = new Destionation()
        {
            Id = vm.Id,
            //Image=vm.Image,
            Price = vm.Price,
            StarCount = vm.StarCount,
            Title=vm.Title
        };
        await _db.Destionation.AddAsync(destionation);
        await _db.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

}

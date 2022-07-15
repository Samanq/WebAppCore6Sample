using Microsoft.AspNetCore.Mvc;
using WebAppCore6Sample.Mvc.Models;
using WebAppCore6Sample.Mvc.Services.Interfaces;

namespace WebAppCore6Sample.Mvc.Controllers;

public class ProductsController : Controller
{
    private readonly IProductHttpClientService _client;

    public ProductsController(IProductHttpClientService client)
    {
        _client = client;
    }

    public async Task<IActionResult> Index()
    {
        var products = await _client.GetAll();

        return View(products);
    }

    public async Task<IActionResult> Details(long id)
    {
        var product = await _client.GetById(id);
        return View(product);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View(new Product());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Product product)
    {
        if (ModelState.IsValid)
        {
            await _client.Create(product);
            return RedirectToAction("Index");
        }

        return View(product);
    }

    [HttpGet]
    public async Task<IActionResult> Edit(long id)
    {
        var product = await _client.GetById(id);
        if (product == null) return NotFound();

        return View(product);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Product product)
    {
        if (ModelState.IsValid)
        {
            await _client.Edit(product);
            return RedirectToAction("Index");
        }

        return View(product);
    }

    public async Task<IActionResult> Delete(long id)
    {
        var product = await _client.GetById(id);
        if (product == null) return NotFound();

        return PartialView("_Delete", product);
    }

    public async Task<IActionResult> ConfirmDelete(long id)
    {
        await _client.Delete(id);
        return RedirectToAction("Index");
    }
}

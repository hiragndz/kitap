using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ödev.Models;

namespace ödev.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
        {
            Kitap kitap = new Kitap
            {
                KitapAdı = "Bilinmeyen bir kadının mektubu",
                YazarAdı = "Stefan Zweig",
                YayınlanmaTarihi = new DateTime(2024, 04, 28),
                Türü = "Edebiyat",
                SayfaSayısı = 215,
                Fiyat = 130
            };

            return View(kitap);}


}
using Eletrodomestico.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eletrodomestico.Controllers
{
    public class EletroDomesticoController : Controller
    {
        public IActionResult Index()
        {
            List<Eletrodosmetico> eletro = new List<Eletrodosmetico>
            {
                new Televisor { marca = "LG", modelo = "LG 50 Led", ConsumoEnergetico = 80, TamanhoTela = 40, Smart = true },
                new Televisor { marca = "Samsung", modelo = "NeoQLED", ConsumoEnergetico = 80, TamanhoTela = 40, Smart = true },
                new Geladeira { marca = "EletroLux", modelo = "Frost Free", CapacidadeLitros = 431, TemFreezer = true },
                 
            };
            return View(eletro);
        }
    }
}

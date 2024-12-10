using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        //Instancia do tipo cliente 
        Cliente cliente1 = new Cliente(01, "Arthr A. Ferreira", "123.456.789-00", "arthur.antunes@sp.senai.br", "Madruga");
        Cliente cliente2 = new Cliente(02, "Wiliam Henry Gates III", "039.456.763-55", "bill@microsoft.com", "Bug");
        Cliente cliente3 = new Cliente(03, "Ada Lovelace", "800.777.920-50", "ada@ada.language.com", "Byron");
        Cliente cliente4 = new Cliente(04, "Linus Torvalds", "933.622.400-03", "torvalds@osdl.org", "Pinguim");
        Cliente cliente5 = new Cliente(05, "Grace Hopper", "911.702.988-00", "grace.hooper@cobol.com", "Loboc");

        //Lista de clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        // Instancia do tipo fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "C# PET S/A", "14.182.102.0001-80", "c-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "Ctrl Alt Dog", "15.386.698/0001-57", "ctrl@alt.dog.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "BootPet INC", "40.810.224/0001-09", "boots.pet@gatomania.us");
        Fornecedor fornecedor4 = new Fornecedor(04, "Tik Tok Dogs", "87.945.350/0001-83", "noisnamidia@tiktokdogs.uk");
        Fornecedor fornecedor5 = new Fornecedor(05, "Bifinho Forever", "18.760.641/0001-37", "contato@bff.us");

        // Lista de fornecedores
        //1:00:11
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores;

        return View();
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

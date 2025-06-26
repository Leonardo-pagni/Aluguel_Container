using ContainRs.WebApp.Data;
using ContainRs.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ContainRs.WebApp.Controllers;

public class RegistroController : Controller
{
    private readonly AppDbContext context;

    public RegistroController(AppDbContext context)
    {
        this.context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Sucesso() => View();

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> CreateAsync(RegistroViewModel form)
    {
        if (!ModelState.IsValid) return View("Index", form);

        if (form.Idade < 18)
        {
            TempData["ErrorMessage"] = "É necessário ter 18 anos para realizar o registro!";
            return View("Index", form);
        }
        var cliente = new Cliente(form.Nome, form.Email, form.CPF)
        {
            Celular = form.Celular,
            CEP = form.CEP,
            Rua = form.Rua,
            Numero = form.Numero,
            Complemento = form.Complemento,
            Bairro = form.Bairro,
            Municipio = form.Municipio,
            Estado = form.Estado,
            Idade = form.Idade
        };
        context.Clientes.Add(cliente);
        await context.SaveChangesAsync();

        return RedirectToAction("Sucesso");
    }
}

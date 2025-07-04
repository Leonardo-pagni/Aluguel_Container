﻿using ContainRs.Domain.Models;
using ContainRs.WebApp.Data;
using ContainRs.WebApp.Models;
using ContainRs.Application.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace ContainRs.WebApp.Controllers
{
    [ApiController]
    [Route("api/registros")]
    public class ApiRegistroController : ControllerBase
    {
        private readonly AppDbContext context;

        public ApiRegistroController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(RegistroViewModel request)
        {
            var useCase = new RegistrarCliente(
                context, request.Nome, new Email(request.Email),
                request.CPF, request.Celular, request.CEP,
                request.Rua, request.Numero, request.Complemento,
                request.Bairro, request.Municipio, UfStringConverter.From(request.Estado), request.Idade);

            var cliente = new Cliente(request.Nome, new Email(request.Email), request.CPF)
            {
                Celular = request.Celular,
                CEP = request.CEP,
                Rua = request.Rua,
                Numero = request.Numero,
                Complemento = request.Complemento,
                Bairro = request.Bairro,
                Municipio = request.Municipio,
                Estado = UfStringConverter.From(request.Estado),
                Idade = request.Idade
            };

            await useCase.ExecutarAsync();

            return Ok();
        }
    }
}

using System;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
	[HttpGet("ObterDataHoraAtual")]
	public IActionResult ObterDataAtual()
	{
		var obj = new
		{
			Data = DateTime.Now.ToLongDateString(),
			Hora = DateTime.Now.ToShortTimeString()
		};

		return Ok(obj);
		
	}

    [HttpGet("Apresentar/{nome}")]
    public IActionResult Apresentar(string nome)
	{
		var mensagem = $"Olá {nome} é um prazer ter você na nossa API, seja muito bem vindo!";

		return Ok(new { mensagem });
	}
}

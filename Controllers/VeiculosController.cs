using System;
using Microsoft.AspNetCore.Mvc;
using mf_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace mf_backend.Controllers
{
	public class VeiculosController : Controller
	{
		private readonly AppDbContext _context;
		public VeiculosController(AppDbContext context)
		{
			_context = context;

		}

		public async Task<IActionResult> Index()
		{
			var dados = await _context.Veiculos.ToListAsync();
			return View(dados);
		}

	}
}


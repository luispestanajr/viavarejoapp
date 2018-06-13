using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VIAVAREJO.API.Data;

namespace VIAVAREJO.API.Controllers
{
  [Route("api/[controller]")]
  public class LocalizacoesController : Controller
  {
    private readonly DataContext _context;
    public LocalizacoesController(DataContext context)
    {
      _context = context;
    }

    // GET api/localizacoes
    [HttpGet]
    public async Task<IActionResult> Get()
    {
      var localizacoes = await _context.Localizacoes.ToListAsync();
      
      return Ok(localizacoes);
    }
  }
}
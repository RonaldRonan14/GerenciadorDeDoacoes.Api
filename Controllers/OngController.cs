using GerenciadorDeDoacoes.Application.Interfaces;
using GerenciadorDeDoacoes.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace GerenciadorDeDoacoes.Api.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class OngController : ControllerBase
{
    private readonly ICadastroOngService _service;

    public OngController(ICadastroOngService service) =>
        _service = service;

    [HttpGet]
    public async Task<ActionResult<CadastroOngModel>> GetByCnpjAsync(string cnpj)
    {
        try
        {
            return Ok(await _service.GetByCnpjAsync(cnpj));
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(ex.Message);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    public async Task<ActionResult<CadastroOngModel>> AddAsync(CadastroOngModelCreate ong)
    {
        try
        {
            return Created("api/v1/Ong", await _service.AddAsync(ong));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut]
    public async Task<IActionResult> UpdateAsync(CadastroOngModelUpdate ong)
    {
        try
        {
            await _service.UpdateAsync(ong);
            return NoContent();
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(ex.Message);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete]
    public async Task<IActionResult> RemoveAsync(string cnpj)
    {
        try
        {
            await _service.RemoveAsync(cnpj);
            return NoContent();
        }
        catch (KeyNotFoundException ex)
        {
            return NotFound(ex.Message);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}

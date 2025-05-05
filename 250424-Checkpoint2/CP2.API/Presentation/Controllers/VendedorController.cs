using CP2.API.Application.Interfaces;
using CP2.API.Application.Dtos;
using CP2.API.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Swashbuckle.AspNetCore.Annotations;

namespace CP2.API.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendedorController : ControllerBase
    {
        private readonly IVendedorApplicationService _applicationService;

        public VendedorController(IVendedorApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        /// <summary>
        /// Retorna uma lista de todos os vendedores
        /// </summary>
        /// <returns>Uma lista dos vendedores cadastrados</returns>
        /// <response code="200">Retorna a lista de vendedores com sucesso</response>
        /// <response code="400">Retorna se não for possível obter os dados</response>
        [HttpGet]
        [SwaggerOperation(Summary = "Lista todos os vendedores", Description = "Este endpoint retorna uma lista completa de todos os vendedores cadastrados.")]
        [ProducesResponseType(typeof(IEnumerable<VendedorEntity>), 200)]
        [ProducesResponseType(400)]
        public IActionResult Get()
        {
            var objModel = _applicationService.ObterTodosVendedores();

            if (objModel is not null)
                return Ok(objModel);

            return BadRequest("Não foi possível obter os dados");
        }

        /// <summary>
        /// Retorna um vendedor específico por ID
        /// </summary>
        /// <param name="id">ID do vendedor a ser retornado</param>
        /// <returns>Vendedor encontrado</returns>
        /// <response code="200">Vendedor encontrado com sucesso</response>
        /// <response code="400">Retorna se não for possível obter os dados</response>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(VendedorEntity), 200)]
        [ProducesResponseType(400)]
        public IActionResult GetPorId(int id)
        {
            var objModel = _applicationService.ObterVendedorPorId(id);

            if (objModel is not null)
                return Ok(objModel);

            return BadRequest("Não foi possível obter os dados");
        }

        /// <summary>
        /// Cria um novo vendedor
        /// </summary>
        /// <param name="entity">Dados do vendedor a ser criado</param>
        /// <returns>Vendedor criado com sucesso</returns>
        /// <response code="200">Vendedor criado com sucesso</response>
        /// <response code="400">Retorna se não for possível salvar os dados</response>
        [HttpPost]
        [ProducesResponseType(typeof(VendedorEntity), 200)]
        [ProducesResponseType(400)]
        public IActionResult Post([FromBody] VendedorDto entity)
        {
            try
            {
                var objModel = _applicationService.SalvarDadosVendedor(entity);

                if (objModel is not null)
                    return Ok(objModel);

                return BadRequest("Não foi possível salvar os dados");
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    Error = ex.Message,
                    status = HttpStatusCode.BadRequest,
                });
            }
        }

        /// <summary>
        /// Atualiza os dados de um vendedor
        /// </summary>
        /// <param name="id">ID do vendedor a ser atualizado</param>
        /// <param name="entity">Dados do vendedor atualizados</param>
        /// <returns>Vendedor atualizado com sucesso</returns>
        /// <response code="200">Vendedor atualizado com sucesso</response>
        /// <response code="400">Retorna se não for possível atualizar os dados</response>
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(VendedorEntity), 200)]
        [ProducesResponseType(400)]
        public IActionResult Put(int id, [FromBody] VendedorDto entity)
        {
            try
            {
                var objModel = _applicationService.EditarDadosVendedor(id, entity);

                if (objModel is not null)
                    return Ok(objModel);

                return BadRequest("Não foi possível salvar os dados");
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    Error = ex.Message,
                    status = HttpStatusCode.BadRequest,
                });
            }
        }

        /// <summary>
        /// Deleta um vendedor pelo ID
        /// </summary>
        /// <param name="id">ID do vendedor a ser deletado</param>
        /// <returns>Vendedor deletado com sucesso</returns>
        /// <response code="200">Vendedor deletado com sucesso</response>
        /// <response code="400">Retorna se não for possível deletar os dados</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(VendedorEntity), 200)]
        [ProducesResponseType(400)]
        public IActionResult Delete(int id)
        {
            var objModel = _applicationService.DeletarDadosVendedor(id);

            if (objModel is not null)
                return Ok(objModel);

            return BadRequest("Não foi possível deletar os dados");
        }
    }
}

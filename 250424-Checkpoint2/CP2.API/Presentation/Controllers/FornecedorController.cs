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
    public class FornecedorController : ControllerBase
    {
        private readonly IFornecedorApplicationService _applicationService;

        public FornecedorController(IFornecedorApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        /// <summary>
        /// Lista todos os fornecedores
        /// </summary>
        /// <remarks>
        /// Retorna uma lista completa de todos os fornecedores cadastrados
        /// </remarks>
        /// <response code="200">Retorna a lista de fornecedores</response>
        /// <response code="400">Retorna se não for possível obter os dados</response>
        [HttpGet]
        [SwaggerOperation(Summary = "Lista todos os fornecedores", Description = "Este endpoint retorna uma lista completa de todos os fornecedores cadastrados.")]
        [ProducesResponseType(typeof(IEnumerable<FornecedorEntity>), 200)]
        [ProducesResponseType(400)]
        public IActionResult Get()
        {
            var objModel = _applicationService.ObterTodosFornecedores();

            if (objModel is not null)
                return Ok(objModel);

            return BadRequest("Não foi possível obter os dados.");
        }

        /// <summary>
        /// Seleciona um fornecedor específico pelo ID
        /// </summary>
        /// <param name="id">ID do fornecedor</param>
        /// <remarks>
        /// Retorna as informações do fornecedor correspondente ao ID informado
        /// </remarks>
        /// <response code="200">Retorna o fornecedor encontrado</response>
        /// <response code="400">Retorna se não for possível obter os dados</response>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(FornecedorEntity), 200)]
        [ProducesResponseType(400)]
        public IActionResult GetPorId(int id)
        {
            var objModel = _applicationService.ObterFornecedorPorId(id);

            if (objModel is not null)
                return Ok(objModel);

            return BadRequest("Não foi possível obter os dados.");
        }

        /// <summary>
        /// Cria um novo fornecedor
        /// </summary>
        /// <param name="entity">Dados do fornecedor a ser criado</param>
        /// <remarks>
        /// Cria um novo fornecedor com os dados fornecidos
        /// </remarks>
        /// <response code="200">Fornecedor criado com sucesso</response>
        /// <response code="400">Retorna se não for possível criar os dados</response>
        [HttpPost]
        [ProducesResponseType(typeof(FornecedorEntity), 200)]
        [ProducesResponseType(400)]
        public IActionResult Post([FromBody] FornecedorDto entity)
        {
            try
            {
                var objModel = _applicationService.SalvarDadosFornecedor(entity);

                if (objModel is not null)
                    return Ok(objModel);

                return BadRequest("Não foi possível salvar os dados.");
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
        /// Atualiza os dados de um fornecedor existente
        /// </summary>
        /// <param name="id">ID do fornecedor a ser atualizado</param>
        /// <param name="entity">Novos dados do fornecedor</param>
        /// <remarks>
        /// Atualiza os dados de um fornecedor com base no ID fornecido
        /// </remarks>
        /// <response code="200">Fornecedor atualizado com sucesso</response>
        /// <response code="400">Retorna se não for possível salvar os dados</response>
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(FornecedorEntity), 200)]
        [ProducesResponseType(400)]
        public IActionResult Put(int id, [FromBody] FornecedorDto entity)
        {
            try
            {
                var objModel = _applicationService.EditarDadosFornecedor(id, entity);

                if (objModel is not null)
                    return Ok(objModel);

                return BadRequest("Não foi possível salvar os dados.");
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
        /// Deleta um fornecedor específico pelo ID
        /// </summary>
        /// <param name="id">ID do fornecedor a ser deletado</param>
        /// <remarks>
        /// Exclui o fornecedor correspondente ao ID informado
        /// </remarks>
        /// <response code="200">Fornecedor deletado com sucesso</response>
        /// <response code="400">Retorna se não for possível deletar os dados</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(FornecedorEntity), 200)]
        [ProducesResponseType(400)]
        public IActionResult Delete(int id)
        {
            var objModel = _applicationService.DeletarDadosFornecedor(id);

            if (objModel is not null)
                return Ok(objModel);

            return BadRequest("Não foi possível deletar os dados.");
        }
    }
}

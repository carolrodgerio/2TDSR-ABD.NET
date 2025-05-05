using CP2.API.Application.Interfaces;
using CP2.API.Application.Dtos;
using CP2.API.Domain.Entities;
using CP2.API.Domain.Interfaces;

namespace CP2.API.Application.Services
{
    public class FornecedorApplicationService : IFornecedorApplicationService
    {
        private readonly IFornecedorRepository _repository;

        public FornecedorApplicationService(IFornecedorRepository repository)
        {
            _repository = repository;
        }

        public FornecedorEntity? ObterFornecedorPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public IEnumerable<FornecedorEntity> ObterTodosFornecedores()
        {
            return _repository.ObterTodos();
        }

        public FornecedorEntity SalvarDadosFornecedor(FornecedorDto fornecedorDto)
        {
            
            var fornecedor = new FornecedorEntity
            {
                
            };

            return _repository.Salvar(fornecedor);
        }

        public FornecedorEntity EditarDadosFornecedor(int id, FornecedorDto fornecedorDto)
        {
            var fornecedor = _repository.ObterPorId(id);

            if (fornecedor != null)
            {
               
                return _repository.Editar(fornecedor);
            }

            return null;
        }

        public FornecedorEntity DeletarDadosFornecedor(int id)
        {
            return _repository.Deletar(id);
        }
    }

}

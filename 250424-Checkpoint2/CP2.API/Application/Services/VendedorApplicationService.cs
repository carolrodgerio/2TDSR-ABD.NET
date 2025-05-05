using CP2.API.Application.Interfaces;
using CP2.API.Application.Dtos;
using CP2.API.Domain.Entities;
using CP2.API.Domain.Interfaces;

namespace CP2.API.Application.Services
{
    public class VendedorApplicationService : IVendedorApplicationService
    {
        private readonly IVendedorRepository _repository;

        public VendedorApplicationService(IVendedorRepository repository)
        {
            _repository = repository;
        }

        public VendedorEntity? ObterVendedorPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public IEnumerable<VendedorEntity> ObterTodosVendedores()
        {
            return _repository.ObterTodos();
        }

        public VendedorEntity SalvarDadosVendedor(VendedorDto vendedorDto)
        {

            var vendedor = new VendedorEntity
            {

            };

            return _repository.Salvar(vendedor);
        }

        public VendedorEntity EditarDadosVendedor(int id, VendedorDto vendedorDto)
        {
            var vendedor = _repository.ObterPorId(id);

            if (vendedor != null)
            {
                return _repository.Editar(vendedor);
            }

            return null;
        }

        public VendedorEntity DeletarDadosVendedor(int id)
        {
            return _repository.Deletar(id);
        }
    }

}

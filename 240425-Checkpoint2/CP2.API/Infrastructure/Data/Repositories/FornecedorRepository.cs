using CP2.API.Infrastructure.Data.AppData;
using CP2.API.Domain.Entities;
using CP2.API.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CP2.API.Infrastructure.Data.Repositories
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly ApplicationContext _context;

        public FornecedorRepository(ApplicationContext context)
        {
            _context = context;
        }

        public FornecedorEntity? Adicionar(FornecedorEntity fornecedor)
        {
            _context.Fornecedor.Add(fornecedor);
            _context.SaveChanges();
            return fornecedor;
        }

        public FornecedorEntity? ObterPorId(int id)
        {
            return _context.Fornecedor.FirstOrDefault(f => f.Id == id);
        }

        public IEnumerable<FornecedorEntity> ObterTodos()
        {
            return _context.Fornecedor.ToList();
        }

        public FornecedorEntity? Atualizar(int id, FornecedorEntity fornecedor)
        {
            var existingFornecedor = _context.Fornecedor.FirstOrDefault(f => f.Id == id);
            if (existingFornecedor == null)
                return null;

            existingFornecedor.Nome = fornecedor.Nome;
            existingFornecedor.CNPJ = fornecedor.CNPJ;
            existingFornecedor.Endereco = fornecedor.Endereco;
            existingFornecedor.Telefone = fornecedor.Telefone;
            existingFornecedor.Email = fornecedor.Email;
            existingFornecedor.CriadoEm = fornecedor.CriadoEm;

            _context.SaveChanges();
            return existingFornecedor;
        }

        public FornecedorEntity? Deletar(int id)
        {
            var fornecedor = _context.Fornecedor.FirstOrDefault(f => f.Id == id);
            if (fornecedor == null)
                return null;

            _context.Fornecedor.Remove(fornecedor);
            _context.SaveChanges();
            return fornecedor;
        }
    }
}

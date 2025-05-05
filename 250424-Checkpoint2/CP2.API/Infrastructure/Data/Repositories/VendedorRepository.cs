using CP2.API.Infrastructure.Data.AppData;
using CP2.API.Domain.Entities;
using CP2.API.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CP2.API.Infrastructure.Data.Repositories
{
    public class VendedorRepository : IVendedorRepository
    {
        private readonly ApplicationContext _context;

        public VendedorRepository(ApplicationContext context)
        {
            _context = context;
        }

        public VendedorEntity? Adicionar(VendedorEntity vendedor)
        {
            _context.Vendedor.Add(vendedor);
            _context.SaveChanges();
            return vendedor;
        }

        public VendedorEntity? ObterPorId(int id)
        {
            return _context.Vendedor.FirstOrDefault(v => v.Id == id);
        }

        public IEnumerable<VendedorEntity> ObterTodos()
        {
            return _context.Vendedor.ToList();
        }

        public VendedorEntity? Atualizar(int id, VendedorEntity vendedor)
        {
            var existingVendedor = _context.Vendedor.FirstOrDefault(v => v.Id == id);
            if (existingVendedor == null)
                return null;

            existingVendedor.Nome = vendedor.Nome;
            existingVendedor.Email = vendedor.Email;
            existingVendedor.Telefone = vendedor.Telefone;
            existingVendedor.DataNascimento = vendedor.DataNascimento;
            existingVendedor.Endereco = vendedor.Endereco;
            existingVendedor.DataContratacao = vendedor.DataContratacao;
            existingVendedor.ComissaoPercentual = vendedor.ComissaoPercentual;
            existingVendedor.MetaMensal = vendedor.MetaMensal;
            existingVendedor.CriadoEm = vendedor.CriadoEm;

            _context.SaveChanges();
            return existingVendedor;
        }

        public VendedorEntity? Deletar(int id)
        {
            var vendedor = _context.Vendedor.FirstOrDefault(v => v.Id == id);
            if (vendedor == null)
                return null;

            _context.Vendedor.Remove(vendedor);
            _context.SaveChanges();
            return vendedor;
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VShop.Context;
using VShop.Models;

namespace VShop.Repositories
{
    public class ProuductRepository : IProductRepository
    {
        private readonly AppDbContext _context;
        public ProuductRepository(AppDbContext context)
        {
            _context = context;            
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetById(int id)
        {
            return await _context.Products.Where(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Product> Create(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<Product> Update(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<Product> Delete(int id)
        {
            var product = await GetById(id);
            _context.Remove(product);
            await _context.SaveChangesAsync();
            return product;
        }
    }
}

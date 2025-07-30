
using DiarioFit;
using DiarioFit.Intf.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DiarioFit.Server.Services.Base
{
    public class DiarioFitBaseService<T> : ICRUDServer<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public DiarioFitBaseService(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>(); // retorna o dbset crrespondente ao tipo T<<<
        }
        
        public async Task<T> CreateAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);

            if (entity == null) return false;

            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
            return true;

        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.AsNoTracking().ToListAsync();
        }

        public async Task<T?> GetAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<T> UpdateAsync(int id, T entity)
        {
            _dbSet.Attach(entity); //attach monitora a entidade existente
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;

        }
    }
}

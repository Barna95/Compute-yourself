using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace API.Data.Services.Base;

public class BaseService<T> : IBaseService<T> where T : class, IEntityBase, new()
{
    private readonly AppDbContext _context;

    public BaseService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<T> AddAsync(T entity)
    {
        var currentEntity = await _context.Set<T>().AddAsync(entity);
        await _context.SaveChangesAsync();
        return currentEntity.Entity;
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
        EntityEntry entityEntry = _context.Entry<T>(entity);
        entityEntry.State = EntityState.Deleted;
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties)
    {
        IQueryable<T> query = _context.Set<T>();
        query = includeProperties.Aggregate(query, (current, includeProperties) => current.Include(includeProperties));
        return await query.ToListAsync();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
    }

    public async Task UpdateAsync(int id, T entity)
    {
        EntityEntry entityEntry = _context.Entry(entity);
        entityEntry.State = EntityState.Modified;

        await _context.SaveChangesAsync();
    }
}
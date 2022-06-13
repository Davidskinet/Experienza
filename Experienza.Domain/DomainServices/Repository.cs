using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Domain.DomainServices
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        #region Properties
        private ExperienzaDBContext _context;
        private DbSet<TEntity> _dbset;

        #endregion

        #region Buildrs
        public Repository(ExperienzaDBContext context)
        {
            _context = context;
            _dbset = context.Set<TEntity>();
        }
        #endregion

        #region Methods
        public async Task<IEnumerable<TEntity>> GetAsync()
           => await Task.FromResult(_dbset.ToList());

        public async Task<TEntity> GetAsyncById(Guid id)
            => await Task.FromResult(_dbset.Find(id));

        public async Task DeleteAsync(TEntity id)
        {
            var dataToDelete = await Task.FromResult(_dbset.Find(id));
            await Task.FromResult(_dbset.Remove(dataToDelete));
        }
        public async Task AddAsync(TEntity data)
            => await Task.FromResult(_dbset.Add(data));

        public async Task Save()
            => await Task.FromResult(_context.SaveChanges());

        public async Task UpdateAsync(TEntity data)
        {
            _dbset.Find(data);
            await Task.FromResult(_context.Entry(data).State = EntityState.Modified);
        }
        #endregion

    }
}

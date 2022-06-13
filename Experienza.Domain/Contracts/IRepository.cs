namespace Domain.DomainServices
{
    public interface IRepository<TEntity>
    {
        Task<IEnumerable<TEntity>> GetAsync();
        Task<TEntity> GetAsyncById(Guid id);
        Task AddAsync(TEntity data);
        Task DeleteAsync(TEntity id);
        Task UpdateAsync(TEntity data);
        Task Save();
    }
}


namespace DiarioFit.Intf.Interfaces
{
    public interface ICRUDServer<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T?> GetAsync(int id);
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(int id, T entity);
        Task<bool> DeleteAsync(int id);

    }
}

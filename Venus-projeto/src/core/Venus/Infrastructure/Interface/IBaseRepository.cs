namespace Infrastructure.Interface
{
    public interface IBaseRepository<T>
    {
        Task<int> UpdateAsync(T obj);
        Task<int> InsertAsync(T obj);
        Task<int> DeleteAsync(string id);
        Task<T> Get(string id);
        Task<IEnumerable<T>> GeAll();

    }
}

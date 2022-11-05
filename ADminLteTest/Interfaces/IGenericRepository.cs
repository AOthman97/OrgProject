namespace ADminLteTest.Interfaces
{
    public interface IGenericRepositroy<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetTById(object Id);
        Task<bool> Insert(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(object Id);
    }
}

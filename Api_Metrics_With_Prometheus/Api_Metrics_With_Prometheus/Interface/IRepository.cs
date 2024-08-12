namespace Api_Metrics_With_Prometheus.Interface
{
    
        public interface IRepository<T> where T : class
        {
            //Create
            Task CreateAsync(T model);

            //Read
            Task<IEnumerable<T>> GetAllAsync();
            Task<T> GetByIdAsync(long id);
           

            //Update
            Task UpdateAsync(T model);

            //Delete
            Task DeleteAsync(long id);
        }
    
}

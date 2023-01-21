namespace WebAPIApp.Repository
{
    public interface IGenericRepository<T> where T : class, new()
    {
        //Crud Create update read delete

        T Add(T entity);
        T Delete(T entity);
        T GetById(int id);

        List<T> GetAll();
        T UpdateById(T entity, int id);

    }
}
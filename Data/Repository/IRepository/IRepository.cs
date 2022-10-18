using System.Linq.Expressions;

namespace RockyProject.Data.Repository.IRepository
{
    public interface IRepository<T> where T :class
    {
        // features 
        T Find(int id);

        //generics c#
        
        IEnumerable<T> GetAll(
            Expression<Func<T,bool>> filter = null,
            Func<IQueryable<T>,IOrderedQueryable<T>> orderBy = null,
            string  includeProperties = null,
            bool isTracking = true
            );
        //first or default
        T FirstOrDefault(
            // where condition
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null,
            bool isTracking = true

            );

        void Add(T enitity);
        void Remove(T enitity);
        void RemoveRange(IEnumerable<T> entity);
        void Save();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.Repository
{
    public interface IRepositoryBase<T> where T : class
    {
        bool Create(T entity);
        bool Update(T entity, T entity2);
        bool Delete(T entity);
        ICollection<T> GetAll();
        int Find(T entity);
        bool CheckTables(T entity);
        T GetByID(T entity);
    }
}

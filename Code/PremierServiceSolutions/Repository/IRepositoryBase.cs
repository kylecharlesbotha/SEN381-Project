using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremierServiceSolutions.Repository
{
    public interface IRepositoryBase<T> where T : class
    {
        /// <summary>
        /// Method to create new record
        /// </summary>
        bool Create(T entity);
        /// <summary>
        /// Method to update existing record
        /// </summary>
        bool Update(T entity, T entity2);
        /// <summary>
        /// Method to change the state of Object to 0 to show it is deleted
        /// </summary>
        bool Delete(T entity);

        /// <summary>
        /// Method to get all records back
        /// </summary>
        ICollection<T> GetAll();

        /// <summary>
        /// Method to get count of records where ID = item
        /// </summary>
        int Find(T entity);

        /// <summary>
        /// Method to check that any foreign keys have records in primary key table
        /// </summary>
        bool CheckTables(T entity);

        /// <summary>
        /// Method to get record of type object
        /// </summary>
        T GetByID(T entity);
    }
}

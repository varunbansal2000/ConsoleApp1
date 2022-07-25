using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataAccess
{
    public interface IDataAccess<TEntity,  TPk>
    {
        // Get all Records
        IEnumerable<TEntity> Get();
        // Get a single records based on the id
        TEntity Get(TPk id);
        // Create a new Record
        TEntity Craete(TEntity entity);
        // Update
        TEntity Update(TPk id, TEntity entity);
        // Delete
        TEntity Delete(TPk id);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIMS_Domain.Interfaces.Repositories
{
    public interface IRepository<T> where T : class
    {
        bool Create(T entity);

        T Read(Guid id);
        IEnumerable<T> ReadAll();
        bool Update(T entity);
        bool Delete(Guid id);
    }
}

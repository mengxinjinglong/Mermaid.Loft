using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mermaid.Loft.Infrastructure.Ioc.BaseRepository
{
    public interface IRepository<T> where T:class
    {
        void Insert(T t);

        void Update(T t);

        void Delete(T t);

        T SelectBy(object key);

        IList<T> SelectAll();
    }
}

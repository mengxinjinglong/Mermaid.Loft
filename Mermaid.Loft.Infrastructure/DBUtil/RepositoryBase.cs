using Mermaid.Loft.Infrastructure.DomainBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mermaid.Loft.Infrastructure.DBUtil
{
    public interface RepositoryBase<T> where T : EntityBase
    {
        void Insert(T t);

        void Update(T t);

        void DeletePhysical(T t);

        void DeleteLogic(T t);

        T SelectBy(object obj);

        IList<T> SelectAll();
    }
}

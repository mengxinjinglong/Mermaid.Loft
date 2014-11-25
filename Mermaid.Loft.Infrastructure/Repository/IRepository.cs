using Mermaid.Loft.Infrastructure.DomainBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mermaid.Loft.Infrastructure.Repository
{
    public interface IRepository<T> where T : EntityBase
    {
        void CreateTable();
        void InsertItem(T t);

        void UpdateItem(T t);

        void DeleteItemPhysical(T t);

        void DeleteItemLogic(T t);

        T SelectItemBy(object obj);

        IList<T> SelectItemAll();
    }
}

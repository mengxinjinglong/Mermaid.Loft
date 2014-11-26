using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mermaid.Loft.Infrastructure.DomainBase
{
    public class MasterBase
    {
        /// <summary>
        /// 类型
        /// </summary>
        private string _type;
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        /// <summary>
        /// 名称
        /// </summary>
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        /// <summary>
        /// 数据表名
        /// </summary>
        private string _tableName;
        public string TableName
        {
            get { return _tableName; }
            set { _tableName = value; }
        }
        private string _rootPage;
        public string RootPage
        {
            get { return _rootPage; }
            set { _rootPage = value; }
        }

        private string _sql;
        public string Sql
        {
            get { return _sql; }
            set { _sql = Sql; }
        }
    }
}

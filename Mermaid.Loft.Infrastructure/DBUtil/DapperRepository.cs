using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;

using Mermaid.Loft.Infrastructure.DomainBase;
using System.Data;
using Dapper;
using System.IO;
using System.Threading;

namespace Mermaid.Loft.Infrastructure.DBUtil
{
    public abstract class DapperRepository<T>:RepositoryBase<T> where T: EntityBase
    {
        #region - Base Members -
        private static readonly string DB_FILE = Environment.CurrentDirectory + @"\mylofter.db";
        private static readonly string CONNECTION = "Data Source=" + Environment.CurrentDirectory + @"\mylofter.db;Version=3;Password=mylofter123;";
        /// <summary>
        /// 数据表名称
        /// </summary>
        protected string TABLE_NAME = string.Empty;
        /// <summary>
        /// 创建数据表
        /// </summary>
        protected string SQL_TABLE_CREATE = string.Empty;
        /// <summary>
        /// 插入数据
        /// </summary>
        protected string SQL_INSERT = string.Empty;
        /// <summary>
        /// 修改数据
        /// </summary>
        protected string SQL_UPDATE = string.Empty;
        /// <summary>
        /// 物理删除数据
        /// </summary>
        protected string SQL_DELETE_PHYSICAL = string.Empty;
        /// <summary>
        /// 逻辑删除数据
        /// </summary>
        protected string SQL_DELETE_LOGIC = string.Empty;
        /// <summary>
        /// 读取符合条件的数据
        /// </summary>
        protected string SQL_SELECTBY = string.Empty;
        /// <summary>
        /// 读取所有数据
        /// </summary>
        protected string SQL_SELECTALL = string.Empty;
        /// <summary>
        /// 检查数据表是否存在
        /// </summary>
        private const string SQL_CHECK_TABLE = " select count(*) from sqlite_master where type='table' and name='{0}' ";
        #endregion

        #region - Base Methods - 
        public DapperRepository()
        {
            CheckFile();
        }
        /// <summary>
        /// 检查数据表是否存在，不存在则创建
        /// </summary>
        public void CheckTable()
        {
            try
            {
                using (IDbConnection connection = OpenConnection())
                {
                    var tableCount = connection
                        .Query<int>(string.Format(SQL_CHECK_TABLE, TABLE_NAME));
                        //.First();
                    if (tableCount.First() < 1)
                    {
                        this.Create();
                    }
                }
            }
            catch
            { 
                
            }
            
        }
        /// <summary>
        /// 检查db文件，不存在则创建
        /// </summary>
        protected void CheckFile()
        {
            if (!File.Exists(DB_FILE))
            {
                //创建完成后，立马释放资源
                File.Create(DB_FILE)
                    .Dispose();
            }
        }
        protected IDbConnection OpenConnection()
        {
            var sqliteConnection = new SQLiteConnection(CONNECTION);
            sqliteConnection.Open();
            return sqliteConnection;
        }

        protected IList<T> Query(string sql, object obj)
        {
            using (IDbConnection connection = OpenConnection())
            {
                return connection.Query<T>(sql, obj).ToList();
            }
        }

        protected void Execute(string sql, T entity)
        {
            using (IDbConnection connection = OpenConnection())
            {
                connection.Execute(sql, entity);
            }
        }
        #endregion

        #region - Protected Methods -
        /// <summary>
        /// 
        /// </summary>
        public void Create()
        {
            this.Execute(SQL_TABLE_CREATE,null);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public void Insert(T entity)
        {
            this.Execute(SQL_INSERT, entity);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public void Update(T entity)
        {
            this.Execute(SQL_UPDATE, entity);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public void DeletePhysical(T entity)
        {
            this.Execute(SQL_DELETE_PHYSICAL, entity);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public void DeleteLogic(T entity)
        {
            this.Execute(SQL_DELETE_LOGIC, entity);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public T SelectBy(object obj)
        {
            return this.Query(SQL_SELECTBY, obj).FirstOrDefault();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IList<T> SelectAll()
        {
            return this.Query(SQL_SELECTALL, null);
        }
        #endregion

    }
}

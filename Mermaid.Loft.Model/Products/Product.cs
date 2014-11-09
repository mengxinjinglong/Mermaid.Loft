using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Mermaid.Loft.Infrastructure.DomainBase;

namespace Mermaid.Loft.Model.Products
{
    public class Product : EntityBase
    {
        /// <summary>
        /// 产品ID
        /// </summary>
        private string _productId;

        public string ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }
        private string _productName;
        /// <summary>
        /// 产品名称
        /// </summary>
        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }
        /// <summary>
        /// 产品地址
        /// </summary>
        private string _url;

        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }
        /// <summary>
        /// 产品所属用户
        /// </summary>
        private string _userId;

        public string UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        private DateTime _createDate;

        public DateTime CreateDate
        {
            get { return _createDate; }
            set { _createDate = value; }
        }
        /// <summary>
        /// 货源地址
        /// </summary>
        private string _sourceUrl;

        public string SourceUrl
        {
            get { return _sourceUrl; }
            set { _sourceUrl = value; }
        }
        /// <summary>
        /// 产品分类
        /// </summary>
        private string _categories;

        public string Categories
        {
            get { return _categories; }
            set { _categories = value; }
        }
        private string _description;
        /// <summary>
        /// 描述
        /// </summary>
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        private DateTime _updateDate;
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime UpdateDate
        {
            get { return _updateDate; }
            set { _updateDate = value; }
        }


    }
}

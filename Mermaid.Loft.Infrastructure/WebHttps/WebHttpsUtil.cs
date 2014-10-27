using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Mermaid.Loft.Infrastructure.WebHttps
{
    public class WebHttpsUtil
    {
        
        public static string Reponse(string url)
        {
            string result = string.Empty;
            using (var webClient = new WebClient())
            {
                var resultByte = webClient.DownloadData(url);
                result = ASCIIEncoding.UTF8.GetString(resultByte);
            }
            return result;
        }
    }
}

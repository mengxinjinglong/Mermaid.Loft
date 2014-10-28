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
                webClient.Headers.Add("Accept-Language", "zh-cn");
                webClient.Headers.Add("UA-CPU", "x86");
                //_client.Headers.Add("Accept-Encoding","gzip, deflate");
                webClient.Headers.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; SV1; .NET CLR 1.1.4322; .NET CLR 2.0.50727)");
                result = webClient.DownloadString(url);

            }
            return result;
        }

        public static string ReponseUtf8(string url)
        {
            string result = string.Empty;
            using (var webClient = new WebClient())
            {
                webClient.Headers.Add("Accept-Language", "zh-cn");
                webClient.Headers.Add("UA-CPU", "x86");
                //_client.Headers.Add("Accept-Encoding","gzip, deflate");
                webClient.Headers.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; SV1; .NET CLR 1.1.4322; .NET CLR 2.0.50727)");
                var resultByte = webClient.DownloadData(url);
                result = ASCIIEncoding.UTF8.GetString(resultByte);

            }
            return result;
        }

        public static string WebRequestString(string url)
        {
            WebRequest request = HttpWebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream resStream = response.GetResponseStream();
            StreamReader sr = new StreamReader(resStream, System.Text.Encoding.Default);
            var result = sr.ReadToEnd();
            resStream.Close();
            sr.Close();
            return result;
        }
       
    }
}

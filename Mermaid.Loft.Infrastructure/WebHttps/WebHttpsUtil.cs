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
        
        public string Reponse(string url)
        {
            string result = string.Empty;
            using (var webClient = new WebClient())
            {
                var stream = webClient.OpenRead(url);
                var streamReader = new StreamReader(stream);
                result = streamReader.ReadToEnd();
            }
            return result;
        }
    }
}

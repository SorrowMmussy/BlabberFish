using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BlabberFish.API_Structure;

namespace BlabberFish
{
    class Teleport_API<T>
    {
        static public T DownloadJSON(string link, Dictionary<string, string> replaces)
        {
            
            T data;
            using (WebClient wc = new WebClient())
            {
                string json = wc.DownloadString(link);

                foreach (KeyValuePair<string, string> kvp in replaces)
                {
                    json = json.Replace(kvp.Key, kvp.Value);
                }
                
                data = JsonConvert.DeserializeObject<T>(json);
            }

            return data;



        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using RestSharp;

namespace DrugsProject3._0.Tools
{
    public class ImaggaService
    {
        public  void Show()
        {
            string apiKey = "acc_7538f1603895112";
            string apiSecret = "4b52d330a53d90b457e7adb7aa4aa52c";
            string imageUrl = "https://www.google.com/search?q=%D7%AA%D7%A8%D7%95%D7%A4%D7%94&safe=active&rlz=1C1EKKP_enIL775IL775&sxsrf=ALeKk01Nrw3hh5I3AK3EvQEHTWa7vaEMqg:1604962588333&source=lnms&tbm=isch&sa=X&ved=2ahUKEwjB9dHHx_bsAhVRzhoKHambCCIQ_AUoAXoECAQQAw&biw=1396&bih=657#imgrc=GCkuk-oXQ0Oe7M";

            string basicAuthValue = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(String.Format("{0}:{1}", apiKey, apiSecret)));

            var client = new RestClient("https://api.imagga.com/v2/tags");
            client.Timeout = -1;

            var request = new RestRequest(Method.GET);
            request.AddParameter("image_url", imageUrl);
            request.AddHeader("Authorization", String.Format("Basic {0}", basicAuthValue));

            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            Console.ReadLine();
        }
    }
}

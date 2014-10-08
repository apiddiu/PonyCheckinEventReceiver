using System;
using System.Collections.Specialized;
using System.Net;

namespace PonyCheckinEventReceiver.Communication
{
    public static class ItemSynchronization
    {
        private const String SynchServiceUrl = "http://hchbaec5815/PonyEventListener/CheckedIn";

        public static void SendData(String itemUrl)
        {
            try
            {
                using (var wb = new WebClient())
                {
                    wb.DownloadString(SynchServiceUrl);

                    //var data = new NameValueCollection();
                    //data["itemUrl"] = itemUrl;

                    //var response = wb.UploadValues(SynchServiceUrl, "POST", data);
                }
            }
            catch (Exception)
            {
                ;
            }
        }
    }
}

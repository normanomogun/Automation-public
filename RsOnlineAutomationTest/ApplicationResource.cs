using System.Configuration;

namespace RsOnlineAutomationTest
{
    public class ApplicationResource
    {
        public static string BaseUrl
        {
            get
            {
                var url = ConfigurationManager.AppSettings["siteUrl"];
                return url;
            }
        }

    }
}
using PayPal.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShoppingStore
{
    public class PaypalConfiguration
    {
        public readonly static string clientId;
        public readonly static string clientSecret;


        static PaypalConfiguration()
        {
            var config = getconfig();
            clientId = "AWsIaxpQ_pN2azF-ylzbrTXbbaA3DIPMZEG2mBHrGHF1NYhjevTuRI0VSxiggw4vtZDMcapUdkSu5trp";
            clientSecret = "EARzh0e-cChon4k01xmlRlgxBo9IG3v5lynoay3PdPgCeOQPUQVL0nrMEbhZnTavpt5kEJRj3i5XBq0O";
        }

        private static Dictionary<string, string> getconfig()
        {
            return PayPal.Api.ConfigManager.Instance.GetProperties();
        }

        private static string GetAccessToken()
        {
            string accessToken = new OAuthTokenCredential(clientId, clientSecret, getconfig()).GetAccessToken();
            return accessToken;
        }
        public static APIContext GetAPIContext()
        {
            APIContext apicontext = new APIContext(GetAccessToken());
            apicontext.Config = getconfig();
            return apicontext;
        }
    }
}
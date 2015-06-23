using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Gunners
{
    class SettingsManager
    {
        internal static void Save()
        {
            global::Web_Gunners.Properties.Settings.Default.Save();

        }
       
        internal static void SetUserAgentString(string p)
        {
            global::Web_Gunners.Properties.Settings.Default.useragent_string = p;
        }
        internal static string GetUserAgentString()
        {
            return global::Web_Gunners.Properties.Settings.Default.useragent_string;
        }
       
        internal static void SetCookieString(string p)
        {

            global::Web_Gunners.Properties.Settings.Default.Cookie_string = p;
        }
        internal static string GetCookieString()
        {
            return global::Web_Gunners.Properties.Settings.Default.Cookie_string;
        }
        
        internal static bool UseCookie()
        {
          return   global::Web_Gunners.Properties.Settings.Default.use_cookie;
        }
        internal static void UseCookie(bool use)
        {
            global::Web_Gunners.Properties.Settings.Default.use_cookie = use;
        }
        
        internal static void SetAuthString(string p)
        {
             global::Web_Gunners.Properties.Settings.Default.Auth_String=p;
        }
        internal static string GetAuthString()
        {
            return global::Web_Gunners.Properties.Settings.Default.Auth_String;
        }

        internal static bool UseAuthorization()
        {
            return global::Web_Gunners.Properties.Settings.Default.Use_Auth;
        }
        internal static void UseAuthorization(bool use)
        {
             global::Web_Gunners.Properties.Settings.Default.Use_Auth=use;
        }

        

        internal static void TextSearchColor(System.Drawing.Color case_)
        {
            global::Web_Gunners.Properties.Settings.Default.TextSearchColor=case_;
        }
        internal static System.Drawing.Color TextSearchColor()
        {
            return global::Web_Gunners.Properties.Settings.Default.TextSearchColor;
        }

        internal static decimal GetPortNumber()
        {
            decimal p = 80;
            string prxstr = GetProxyString();
            if(prxstr.Contains(":"))
            {
                string[] sepdbycln = prxstr.Split(new char [] {':'});
                string prt = sepdbycln[1].Trim();
                if (decimal.TryParse(prt, out p))
                    return decimal.Parse(prt);
            }
            return p;
        }

        private static string GetProxyString()
        {    return global::Web_Gunners.Properties.Settings.Default.Proxy_String; }
        private static void SetProxyString(string  s )
        {
             global::Web_Gunners.Properties.Settings.Default.Proxy_String=s;

        }

        internal static string GetHostString()
        { 
            string prxstr = GetProxyString();
            if (prxstr.Contains(":"))
                return prxstr.Split(new char[] { ':' })[0];
            
            return prxstr;
        }

        internal static bool UseProxy()
        { return global::Web_Gunners.Properties.Settings.Default.Use_CustomeProxy; }
        internal static void UseProxy(bool l)
        {  global::Web_Gunners.Properties.Settings.Default.Use_CustomeProxy=l; }


        internal static bool Use_ProxyInIsolatedWindow()
            { return global::Web_Gunners.Properties.Settings.Default.Use_ProxyInIsolatedWindow; }

         
        internal static bool UserAgent()
        { return global::Web_Gunners.Properties.Settings.Default.Send_UserAgent; }
        internal static void UserAgent(bool  b)
        {  global::Web_Gunners.Properties.Settings.Default.Send_UserAgent=b; }


        internal static int TimeOut()
        {
            return global::Web_Gunners.Properties.Settings.Default.TimeOut;
        }
        internal static void TimeOut(int i)
        {
             global::Web_Gunners.Properties.Settings.Default.TimeOut=i;
        }
    }
}

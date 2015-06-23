using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Gunners
{
    class MisterCoder
    {



        public static string Base64Encode(string plainText)
        {
            try
            {
                var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
                return System.Convert.ToBase64String(plainTextBytes);
            }
            catch { return ""; }
        }
        public static string Base64Decode(string base64EncodedData)
        {
            try
            {
                var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
                return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
            }
            catch { return ""; }
        }
        public static string UrlEncode(  string s )
        {
            try
            {
               return   Uri.EscapeUriString(s);
       }
            catch { return ""; }
        }
        public static string UrlDecode(string s)
        {
            try
            {
                return Uri.UnescapeDataString(s);
            }
            catch { return ""; }

        }

        public static string HtmlDecode(string p)
        {
           return System.Net.WebUtility.HtmlDecode(p);
 
        }
        public static string HtmlEncode(string p)
        {
            return System.Net.WebUtility.HtmlEncode(p);

        }

        internal static string ToAscii(string p,string post="")
        {
            string res = "";
            foreach(char c in p)
            {
                int i = c;
                res += (i.ToString()+post);
            }
            return res.Substring(0, res.Length - post.Length);;
        }

        internal static string FromAscci(string p, string sep,bool skippedSaved=false)
        {
            try
            {
                string res="";
                    string[] chars = p.Split(new char [] {char.Parse(sep)});
                    foreach(string num in chars)
                    { 
                        string num2=num.Trim();
                        if (num2.IsNumber() == false)
                        {
                            if (skippedSaved)
                                res += "?";
                            continue; 
                        }
                        int n = int.Parse(num2);
                        char c = ((char)n);
                        res += c;
                    }

            return res;}
        catch{return "";}

        }
    }
}

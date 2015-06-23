using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Gunners
{
     public class String2{
        public string key = "";
        public RequestStatue value = RequestStatue.Wait;
        public long id = 0;
        public String2(string s, RequestStatue k,long l)
        {
            key = s;
            value = k;
            id = l;

        }
        public String2(string s, long l)
        {
            key = s;
            value = RequestStatue.Wait;
            id = l;

        }
        public String2(string s )
        {
            key = s;
            value = RequestStatue.Wait;

        }
         public string GetUrl ()
        {
             if(this.key.Contains("url"))
             {
                 return key.Substring(key.IndexOf("url"), 20);
             }
             return key;
        }

    }
     public static class Extender
     {
         public static bool IsIntegrChar(this char c)
         {
             return (c >= '0' && c <= '9');
         }
         public static long CurrentStamp()
         {
             string s = DateTime.Now.Year.ToString();
             s += DateTime.Now.Month.ToString();
             s += DateTime.Now.Day.ToString();
             s += DateTime.Now.Hour.ToString();
             s += DateTime.Now.Minute.ToString();
             s += DateTime.Now.Second.ToString();
             return long.Parse(s);

         }
         public static bool Is_Aa_Zz_19_Char(this char c)
         {

             return ((c >= '0' && c <= '9') || (c >= 'A' && c < 'Z') || (c >= 'a' && c < 'z'));
         }
         public static bool Is_Aa_Zz_Char(this char c)
         {
             return ((c >= 'A' && c < 'Z') || (c >= 'a' && c < 'z'));
         }
         public static string AlphaNumOnly(this string s)
         {
             // returns numberandchars onnly in a string 
             string res = "";
             foreach (char c in s)
                 if (c.Is_Aa_Zz_19_Char())
                     res += c;
             return res;
         }
         public static string Variable(this string s)
         {
             // returns numberandchars onnly in a string 
             bool frstLetter = false;
             string res = "";

             foreach (char c in s)
                 if (c.Is_Aa_Zz_Char() || (c == '_') || (res.Length > 0 && c.Is_Aa_Zz_19_Char()))
                     res += c;

             return res;
         }
         public static bool IsValidProxyString(this string p)
         {
             if (p.IsUrl() == false)
                 return false;
             if (p.Contains(":") == false)
                 return false;
             string[] sepd = p.Split(new char[] { ':' });
             string port = sepd[1].Trim();
             return port.IsNumber();
         }
         public static bool IsUrl(this string s)
         {

             try
             {
                 new Uri(s); return true;

             }
             catch { return false; }
         }
         public static bool isValidHost(this string s)
         {
             foreach (char c in s)
                 if (!((c > 64 && c <= 'z') || (c == '.') || (c >= '0' && c <= '9')))
                     return false;
             return (s.Length > 1 && (s.TrimDots() != ""));

         }
         public static void HighlightNo(this RichTextBox r, Color color)
         {
             string s = r.Text;
             r.Text = "";

             int length = r.TextLength;  // at end of text
             r.AppendText(s);
             r.SelectionStart = length;
             r.SelectionLength = s.Length;
             r.SelectionColor = color;
         }
         public static int HighlightText(this RichTextBox myRtb, string word, Color color)
         {
             int matches = 0;
             int s_start = myRtb.SelectionStart, startIndex = 0, index;
             if (word == "")
                 return 0;
             while ((index = myRtb.Text.ToLower().IndexOf(word.ToLower(), startIndex)) != -1)
             {
                 myRtb.Select(index, word.Length);
                 myRtb.SelectionColor = color;

                 startIndex = index + word.Length;
                 matches++;
             }

             myRtb.SelectionStart = s_start;
             myRtb.SelectionLength = 0;
             myRtb.SelectionColor = Color.Black;
             return matches;
         }
         public static string StripStart(this string s, char c)
         {
             while (s[0] == c)
             {
                 s = s.Substring(1);
             }
             return s;

         }
         public static string StripEnd(this string s, char c)
         {
             while (s[s.Length - 1] == c)
             {
                 s = s.Substring(0, s.Length - 1);
             }
             return s;

         }
         public static string TrimDots(this string s)
         {
             string res = "";
             foreach (char c in s)
                 if (c != '.')
                     res += c;
             return res;
         }
         public static bool ValidTextFile(this string s)
         {

             try
             {
                 string ss = System.IO.File.ReadAllText(s);
                 if (ss.Contains('�'))
                     return false;

                 return true;
             }
             catch { return false; }
         }
         public static string Revers(this string s)
         {
             string res = "";

             for (int i = s.Length - 1; i >= 0; i--)
                 res += s[i];
             return res;

         }
         public static string TrimHost(this string s)
         {
             try
             {
                 if (s.ToLower().StartsWith("www."))
                     return s.Substring(4);

                 else if (s.ToLower().StartsWith("http://"))
                     return s.Substring(7);

                 else if (s.ToLower().StartsWith("https://"))
                     return s.Substring(8);

                 else if (s.ToLower().StartsWith("ftp://"))
                     return s.Substring(6);
                 return s;
             }
             catch { return ""; }
         }
         public static bool IsNumber(this string s)
         {
             int i = 0;
             if (int.TryParse(s, out i))
                 return true;
             return false;
         }
         public static List<string> GetCookieValues(this string s)
         {
             //admin=0;id=3;v
             List<string> newx = new List<string>();
             if (s.Contains(";"))
             {
                 string[] splitedbysemicolon = s.Split(new char[] { ';' });
                 foreach (string two in splitedbysemicolon)
                 {
                     if (two == "")
                         continue;

                     else if (two.Contains("=") == false)
                         newx.Add(two);
                     else
                     {//admin=1
                         string[] sepdbyequal = two.Split(new char[] { '=' });
                         if (sepdbyequal[1] != "")
                             newx.Add(sepdbyequal[1]);
                     }
                 }
             }
             else if (s.Contains("="))
             {//admin=1


                 string[] sepdbyequal = s.Split(new char[] { '=' });
                 if (sepdbyequal[1] != "")
                     newx.Add(sepdbyequal[1]);
             }
             else
                 newx.Add(s);

             return newx;
         }
         public static string GetDomain(this string s)
         {
             /////// http://www.comans.net/fuckyou
             /////// http://comans.net/fuckyou
             /////// comans.net/fuckyou
             /////// comans.net/fuckyou
             try
             {

                 string[] depd_by_slash = s.Split(new char[] { '/' });

                 if (depd_by_slash.Length > 2)
                     return depd_by_slash[2];
                 else
                     if (depd_by_slash.Length > 1)
                         return depd_by_slash[0];
                     else
                         return s;
             }
             catch { return s; }
         }
         internal static int GetrandomeNumber()
         {
             return new Random().Next(1, 99999999);
         }
         public static string GetHost(this string url)
         {
             // http://localhost.com/vuln/all.php?exp=Via
             string u = "";
             if (url.ToLower().StartsWith("https"))
             {
                 u = url.Substring(8);
             }
             else if (url.ToLower().StartsWith("http"))
             {
                 u = url.Substring(7);

             }
             bool firstslash = false;
             string res = "";
             foreach (char c in u)
             { //localhost.com/vuln/all.php?exp=Via
                 if (firstslash == false && c != '/')
                     res += c;
                 else if (c == '/')
                     firstslash = true;
             }

             return res;
         }
         public static string GetPage(this string url)
         {
             // https://localhost.com/vuln/all.php?exp=Via
             string u = url.GetHost();
             // localhost.com/vuln/all.php?exp=Via
             string res = "";
             bool slashed = false;
             foreach (char c in u)
             {
                 if (c == '/')
                     slashed = true;
                 if (slashed)
                     res += c;

             }

             return res;
         }
         public static string ReadFileTXT(this string s)
         {
             return System.IO.File.ReadAllText(s);
         }
     }
     public class ScriptAnalysiz
     { 
         public string Document = "";
         public int Scripts = 0;
         public int InLinkScript = 0;
         public ScriptAnalysiz(string n = "", int allscripts = 0, int linkScript = 0)
         {
             Document= n;
             Scripts = allscripts;
             InLinkScript = linkScript;
         }

         internal static ScriptAnalysiz Copy(ScriptAnalysiz p)
         {
             ScriptAnalysiz s = new ScriptAnalysiz();
             s.Document = p.Document;
             s.Scripts = p.Scripts;
             s.InLinkScript = p.InLinkScript;
             return s;
         }
     }
    
}

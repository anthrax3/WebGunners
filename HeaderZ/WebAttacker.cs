using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace Web_Gunners
{


    public class AttackDetails
    {

        public bool UseCookie = false;
        public bool SendUserAgent = true;
        public int timout = 100000;
        public string Payload = "";
        public string UserAgentString = "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.81 Safari/537.36";
        public AttackDetails()
        {
            UseCookie = false;
            SendUserAgent = true;
            //UseAdvInjection = false;
            timout = 100000;
            Payload = "";
            UserAgentString = "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.81 Safari/537.36";

        }
        public AttackDetails(bool tru)
            : this()
        {
            LoadFromSettings();
        }


        public string CookieString { get; set; }

        public bool
            UseAuth { get; set; }

        public string authString { get; set; }

        internal void LoadFromSettings()
        {  
            this.SendUserAgent = SettingsManager.UserAgent();
            this.UserAgentString = SettingsManager.GetUserAgentString();

            this.timout = SettingsManager.TimeOut();

            this.UseAuth = SettingsManager.UseAuthorization();
            this.authString = SettingsManager.GetAuthString();

            this.UseCookie = SettingsManager.UseCookie();
            this.CookieString = SettingsManager.GetCookieString();
            
        }

        public string URL { get; set; }

        public string GetInjection()
        {
            // if (UseAdvInjection)return Payload;else
            return Payloads.GetPayload(Payload_.string_);
        }



        public string Target { get { return trgt.Trim(); } set { this.trgt = value.Trim(); } }
        private string trgt = "";
        internal string GetSingleTarget()
        {
            return Target;
        }

        internal string AttackStatue()
        {
            throw new NotImplementedException();
        }

        public bool UseAdvInjection { get; set; }

        public string Owner { get; set; }
    }
      
    public class __HTTTPAttack_
    {
        ///   Allowed headers can be Set as MyReq.Headers.Add("myheader","Myvale");
        /// Protected headers can be Set as MyReq.ProtectedHeader="MyVal";
        public static List<string> _Allowed_Headers_ = new List<string>() { "Accept-Charset", "Accept-Encoding", "Accept-Language", "Accept-Datetime", "Authorization", "Cache-Control", "Content-MD5", "From", "If-Match", "If-None-Match", "If-Range", "If-Unmodified-Since", "Max-Forwards", "Origin", "Pragma", "Proxy-Authorization", "TE", "Upgrade", "Via", "Warning", "X-Requested-With", "DNT", "X-Forwarded-Host", "X-Forwarded-Proto", "Front-End-Https", "X-Http-Method-Override", "X-ATT-DeviceId", "X-Wap-Profile", /*"Proxy-Connection",*/ "X-UIDH", "X-Csrf-TokenAccept" };
        public static List<string> _Protected_Headers_ = new List<string>() { "Connection", "User-Agent", "Referer", "Proxy-Connection", "Expect", "Range", "Date", "If-Modified-Since", "Cookie", "Connection", "Content-Length", "Accept", "Content-Type" };
        
        public Dictionary<string, string> Request_Headers = new Dictionary<string, string>();
        public Dictionary<string, string> Response_Headers = new Dictionary<string, string>();

        public List<StringStringbool> Get_Parameters  = new List<StringStringbool>();
        public Dictionary<string, string> Post_Parameters= new Dictionary<string, string>();
        
        public List<StrBool> TargetedHeaders = new List<StrBool>();
        public StrBool TargetHeader = new StrBool(false, "");

        public void SetTargetHeader(string s)
        {

            this.TargetHeader.string_ = s;
            this.PayLoadOF = Payload_.string_;

            if (s.ToLower() == "x-forwarded-for")
                this.PayLoadOF = Payload_.ip;
            else if (s.ToLower() == "cookie")
                this.PayLoadOF = Payload_.cookie;


        }
        public string _Url
        {

            get { return _url; }
            set
            {
                if (_url.IsUrl())
                    _url = value;
                Host = _url.GetHost();
            }
        }
        private string _url = "";

        _ARank_ _Attack_Type = _ARank_.Single;

        public bool _Use_Cookie = false;
        public string _Cokie_String = "";

        public bool _Use_Auth = false;
        public string _Auth_String = "";

        public string _UserAgentString = "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.81 Safari/537.36";
        public bool _Send_UserAgent = true;

        //  public bool _Use_AdvInjection = false;
        private string _Payload = "_inj_by_ge_";
        public string Payload
        {
            get { return _Payload; }
            set { if (_Payload != "")this._Payload = value; else  _Payload = "_inj_by_ge_"; }
        }


        private int timeout = 100000;

        public int TimeOut
        {
            get { return timeout; }
            set { if (value > 5000)timeout = value; else timeout = 100000; }
        }
        public Payload_ PayLoadOF = Payload_.string_;

        public int infected = 0;
        public string DocumentText = "";
        public string statueCode = "";
        public string StatueDesc = "";
        public bool Succeeded = false;
        public bool HasError = false;
        public bool HasWarning = false;
        public bool Processed = false;
        //ctor and initializing 
        public __HTTTPAttack_(string target = "http://google.com")
        {
            GetFromSettings();
            this.Id = __HTTTPAttack_.GenerateId();
            if (target.IsUrl())
                this._url = target;
            else
                this.Id = target;
            
        }

        private void GetFromSettings()
        {
            if (global::Web_Gunners.Properties.Settings.Default.use_cookie)
            {
                this._Use_Cookie = true;
                this.Add_RequestHeader("cookie", global::Web_Gunners.Properties.Settings.Default.Cookie_string);
            }
            if (global::Web_Gunners.Properties.Settings.Default.Send_UserAgent == false)
            {
                this._Send_UserAgent = true;
                this._UserAgentString = global::Web_Gunners.Properties.Settings.Default.useragent_string;
            }
            if (global::Web_Gunners.Properties.Settings.Default.Use_Auth)
            {
                this._Use_Auth = true;
                this.Add_RequestHeader("Authorization", global::Web_Gunners.Properties.Settings.Default.Auth_String);
            }
        }

        private static string GenerateId()
        { 
            string res = System.DateTime.Now.Minute.ToString();
            res += (((System.DateTime.Now.Second<10)?"0":"")+System.DateTime.Now.Second.ToString());
            res += (((System.DateTime.Now.Millisecond<10)?"0":"")+System.DateTime.Now.Millisecond.ToString());

            return res;
        }
        public __HTTTPAttack_(bool p,Payload_ p2=Payload_.string_)
            : this()
        {
            this.Processed = p;
            this.Payload = Payloads.GetPayload(p2);
        }
        public void LoadFromSettings(bool _get_payload_from_Settings_)
        {
            if (_get_payload_from_Settings_)
                this._Payload = global::Web_Gunners.Properties.Settings.Default.UserInjection_String;
            // this._Use_AdvInjection = global::Web_Gunners.Properties.Settings.Default.UseAdvInj;

            this._Send_UserAgent = !global::Web_Gunners.Properties.Settings.Default.Send_UserAgent;
            this._UserAgentString = global::Web_Gunners.Properties.Settings.Default.useragent_string;
            this.TimeOut = global::Web_Gunners.Properties.Settings.Default.TimeOut;
            this._Use_Auth = global::Web_Gunners.Properties.Settings.Default.Use_Auth;
            this._Auth_String = global::Web_Gunners.Properties.Settings.Default.Auth_String;

            this._Use_Cookie = global::Web_Gunners.Properties.Settings.Default.use_cookie;
            this._Cokie_String = global::Web_Gunners.Properties.Settings.Default.Cookie_string;
        }

        /// Getting Payload
        public string GetInjection(string postfix = "")
        {
            if (Payload == "")
                Payload = Payloads.GetPayload(this.PayLoadOF) + postfix;
            return this.Payload;
        }

        /// Set and Get Req and Res Headers
        public void Add_RequestHeader(string p1, string p2,bool handle_Protected=false)
        { /// stores all headers
            p1 = p1.Trim();
           foreach (KeyValuePair<string, string> it in Request_Headers)
                if (it.Key == p1.Trim())
                {
                    Request_Headers[p1] = p2; 
                    return;
                }


            Request_Headers.Add(p1, p2);
        }
        public void Add_ResponseHeader(string p1, string p2)
        {
            p1 = p1.Trim();
            foreach (KeyValuePair<string, string> it in Response_Headers)
                if (it.Key == p1.Trim())
                {
                    Response_Headers[p1] = p2; return;
                }


            Response_Headers.Add(p1, p2);
        }
        public string Get_RequestHeaderValue(string hn)
        {
            foreach (KeyValuePair<string, string> it in Request_Headers)
                if (it.Key == hn)
                    return it.Value;

            return null;
        }
        public string Get_ResponseHeaderValue(string hn)
        {
            foreach (KeyValuePair<string, string> it in Response_Headers)
                if (it.Key == hn)
                    return it.Value;

            return null;
        }

        //// Attacking
        public static AttackProcess AttackHeader(AttackDetails _AD_)
        {
            bool injecct_cookie = (global::Web_Gunners.Properties.Settings.Default.use_cookie);

            string _Header = _AD_.GetSingleTarget();

            AttackProcess ___________Atk_Proc = new AttackProcess();
            try
            {
                ////url
                var request = (HttpWebRequest)WebRequest.Create(_AD_.URL);
                request.Timeout = _AD_.timout;

                ___________Atk_Proc.url = _AD_.URL;

                //Default Headers/////////
                if (global::Web_Gunners.Properties.Settings.Default.Send_UserAgent)
                    request.UserAgent = "";
                else
                    request.UserAgent = global::Web_Gunners.Properties.Settings.Default.useragent_string;
                ___________Atk_Proc.Add_RequestHeader("User-Agent", request.UserAgent);

                request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
                ___________Atk_Proc.Add_RequestHeader("Accept", request.Accept);



                //Check protected headers
                if (_Header.ToLower() == "referer")
                    request.Referer = _AD_.GetInjection();


                else if (_Header.ToLower() == "user-agent")
                    request.UserAgent = _AD_.GetInjection();

                else if (_Header.ToLower() == "connection")
                    request.Connection = _AD_.GetInjection();


                else if (_Header.ToLower() == "accept")
                    request.Accept = _AD_.GetInjection();


                else if (_Header.ToLower() == "cookie") /// it is cookie injection Attack
                    injecct_cookie = true;

                else // unknown header
                    request.Headers.Add(_Header, _AD_.GetInjection());

                // check cookie to send 
                string cokStr = "";

                if (global::Web_Gunners.Properties.Settings.Default.use_cookie && !injecct_cookie) // use default cookie
                    cokStr = (global::Web_Gunners.Properties.Settings.Default.Cookie_string); // request.Headers.Add("cookie", global::Web_Gunners.Properties.Settings.Default.Cookie);
                else if (injecct_cookie) /// inject cookie
                    cokStr = Payloads.GetPayload(Payload_.cookie);//request.Headers.Add("cookie", Payloads.GetPayload(Payload_.cookie));

                request.Headers.Add("cookie", cokStr);
                ___________Atk_Proc.Add_RequestHeader("cookie", cokStr);



                /// Saving request Details 
                ___________Atk_Proc.Add_RequestHeader("Referer", request.Referer);
                ___________Atk_Proc.Add_RequestHeader("User-Agent", request.UserAgent);
                ___________Atk_Proc.Add_RequestHeader("connection", request.Connection);
                ___________Atk_Proc.Add_RequestHeader("Accept", request.Accept);
                ___________Atk_Proc.Add_RequestHeader(_Header, _AD_.GetInjection());


                /// getting document
                /// 
                var response = (HttpWebResponse)request.GetResponse();
                ___________Atk_Proc.DocumentText = new StreamReader(response.GetResponseStream()).ReadToEnd();

                /// Saving response headers
                WebHeaderCollection __respHEADERScollection = response.Headers;
                for (int i = 0; i < __respHEADERScollection.Count; i++)
                {
                    String header__ = __respHEADERScollection.GetKey(i);
                    String[] values = __respHEADERScollection.GetValues(header__);
                    if (values.Length > 0)
                        ___________Atk_Proc.Add_ResponseHeader(header__, values[0]);

                    else
                        ___________Atk_Proc.Add_ResponseHeader(header__, "");

                }


                ___________Atk_Proc.statueCode = response.StatusCode.ToString();
                ___________Atk_Proc.StatueDesc = response.StatusDescription;
                ___________Atk_Proc.injectionPayload = _AD_.GetInjection();

                return ___________Atk_Proc;
            }
            catch { return new AttackProcess(); }
        }
        public bool Attack_Single_Header(StrBool _Header)
        {

            try
            {
                ////url
                var request = (HttpWebRequest)WebRequest.Create(this._Url);
                request.Timeout = this.TimeOut;

                //Default Headers/////////
                request.UserAgent = this.GetUserAgent();
                request.Accept = this.Accept;
                this.Add_RequestHeader("User-Agent", request.UserAgent);
                this.Add_RequestHeader("Accept", request.Accept);
                // send cookie or not
                if (this._Use_Cookie)
                {
                    request.Headers.Add("cookie", this._Cokie_String);
                    this.Add_RequestHeader("cookie", this._Cokie_String);
                }
                // send Auth or not
                if (this._Use_Auth)
                {
                    this.Add_RequestHeader("Authorization", this._Auth_String);
                    request.Headers.Add("Authorization", this._Auth_String);
                }

                //Check if selected header is a protected header
                if (_Header.string_.ToLower() == "referer")
                {
                    request.Referer = this.GetInjection();
                    this.Add_RequestHeader("Referer", this.GetInjection());

                }
                else if (_Header.string_.ToLower() == "user-agent")
                {
                    request.UserAgent = this.GetInjection();
                    this.Add_RequestHeader("User-Agent", this.GetInjection());
                }
                else if (_Header.string_.ToLower() == "connection")
                {
                    request.Connection = this.GetInjection();
                    this.Add_RequestHeader("Connection", this.GetInjection());
                }

                else if (_Header.string_.ToLower() == "accept")
                {
                    request.Accept = this.GetInjection();
                    this.Add_RequestHeader("Accept", this.GetInjection());

                }

                else if (_Header.string_.ToLower() == "cookie") /// it is cookie injection Attack
                {
                    this.Add_RequestHeader("cookie", this.GetInjection());
                    request.Headers.Add("cookie", this.GetInjection());
                }

                else // unknown header
                {
                    request.Headers.Add(_Header.string_, this.GetInjection());
                    this.Add_RequestHeader(_Header.string_, this.GetInjection());

                }

                /// getting document
                var response = (HttpWebResponse)request.GetResponse();
                this.DocumentText = new StreamReader(response.GetResponseStream()).ReadToEnd();

                /// Saving response headers
                WebHeaderCollection __respHEADERScollection = response.Headers;
                for (int i = 0; i < __respHEADERScollection.Count; i++)
                {
                    String header__ = __respHEADERScollection.GetKey(i);
                    String[] values = __respHEADERScollection.GetValues(header__);
                    if (values.Length > 0)
                        this.Add_ResponseHeader(header__, values[0]);

                    else
                        this.Add_ResponseHeader(header__, "");

                }


                this.statueCode = response.StatusCode.ToString();
                this.StatueDesc = response.StatusDescription;

                this.Succeeded = true; this.HasError = false; this.HasWarning = false;

                bool inf = this.DocumentText.ToString().Contains(this.GetInjection().ToLower());
                if (inf)
                    infected++;
                return inf;
            }
            catch (Exception exp) { this.Succeeded = false; this.HasError = true; this.HasWarning = false; this.Message = exp.Message; }
            return false;
        }

        private string GetUserAgent()
        {
            return (this._Send_UserAgent) ? this._UserAgentString : "";
        }
        public bool IsVulnTo(string hd)
        {
            this.TargetHeader.string_ = hd;
            return Attack_Current_Header(hd);
        }
        public string Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
        public string Message = "";


        public bool IsCurrentHeaderVulnerable()
        {
            return (this.TargetHeader != null) ? TargetHeader.statue_ : false;
        }

        public void SetTargetedHeaders(List<string> list)
        {
            if (this.TargetedHeaders == null)
                this.TargetedHeaders = new List<StrBool>();

            this.TargetedHeaders.Clear();
            foreach (string h in list)
                this.TargetedHeaders.Add(new StrBool(false, h));

        }

        public bool Attack_Current_Header(string payload________ = "")
        {

            string _Header = this.TargetHeader.string_;

            try
            {
                ////url
                var request = (HttpWebRequest)WebRequest.Create(this._Url);
                request.Timeout = this.TimeOut;

                //Default Headers/////////
                request.Accept = this.Accept;
                // send cookie or not
                if (this._Use_Cookie)
                {
                    request.Headers.Add("cookie", this._Cokie_String);
                    this.Add_RequestHeader("cookie", this._Cokie_String);
                }
                // send Auth or not
                if (this._Use_Auth)
                {
                    this.Add_RequestHeader("Authorization", this._Auth_String);
                    request.Headers.Add("Authorization", this._Auth_String);
                }
                // user agent
                if (this._Send_UserAgent)
                    request.UserAgent = this.GetUserAgent();


                //Check if selected header is a protected header
                if (_Header.ToLower() == "referer")
                {
                    request.Referer = this.GetInjection();
                    this.Add_RequestHeader("Referer", this.GetInjection());

                }
                else if (_Header.ToLower() == "user-agent")
                {
                    request.UserAgent = this.GetInjection();
                    this.Add_RequestHeader("User-Agent", this.GetInjection());
                }
                else if (_Header.ToLower() == "Proxy-Connection")
                {
                    request.Proxy = new WebProxy(Payloads.GetPayload(Payload_.ip), int.Parse(Payloads.GetPayload(Payload_.Port)));
                    this.Add_RequestHeader("Referer", this.GetMInjection("Referer"));

                }

                else if (_Header.ToLower() == "connection")
                {
                    request.Connection = this.GetInjection();
                    this.Add_RequestHeader("Connection", this.GetInjection());
                }

                else if (_Header.ToLower() == "accept")
                {
                    request.Accept = this.GetInjection();
                    this.Add_RequestHeader("Accept", this.GetInjection());

                }

                else if (_Header.ToLower() == "cookie") /// it is cookie injection Attack
                {
                    this.Add_RequestHeader("cookie", this.GetInjection());
                    request.Headers.Add("cookie", this.GetInjection());
                }

                else // unknown header
                {
                    request.Headers.Add(_Header, this.GetInjection());
                    this.Add_RequestHeader(_Header, this.GetInjection());

                }


                this.Add_RequestHeader("User-Agent", request.UserAgent);
                this.Add_RequestHeader("Accept", request.Accept);
                this._Method = request.Method;

                /// Sending Req
                var response = (HttpWebResponse)request.GetResponse();
                if (this.CatchServerError(response.Server))
                    return false;

                this.DocumentText = new StreamReader(response.GetResponseStream()).ReadToEnd();
                Thread.Sleep(100);
                /// Saving response headers
                WebHeaderCollection __respHEADERScollection = response.Headers;
                for (int i = 0; i < __respHEADERScollection.Count; i++)
                {
                    String header__ = __respHEADERScollection.GetKey(i);
                    String[] values = __respHEADERScollection.GetValues(header__);
                    if (values.Length > 0)
                        this.Add_ResponseHeader(header__, values[0]);

                    else
                        this.Add_ResponseHeader(header__, "");

                }


                this.statueCode = response.StatusCode.ToString();
                this.StatueDesc = response.StatusDescription;


                string inj = this.GetInjection();
                bool res = false;

                if (PayLoadOF != Payload_.cookie)
                    res = this.DocumentText.ToString().Contains(inj.ToLower());
                else
                {
                    if (this.DocumentText.ToString().Contains(inj.ToLower()))
                        res = true;

                    else
                    {
                        List<string> cok_vals = GetInjection().GetCookieValues();
                        foreach (string s in cok_vals)
                            if (this.DocumentText.ToString().Contains(s.ToLower()))
                            {
                                res = true;
                                break;
                            }
                    }

                }
                this.TargetHeader.statue_ = res;
                this.Message = "Used payload ➙   " + this.Payload; if (this.Payload.Length > 52) this.Payload = this.Payload.Substring(0, 48);
                this.Succeeded = this.Processed = true;
                this.HasError = this.HasWarning = false;
                if (res)
                    infected++;
                return res;
            }
            catch (Exception exp) { this.Succeeded = this.HasWarning = this.Processed = false; this.HasError = true; this.Message = exp.Message; }
            return false;
        }

        private bool CatchServerError(string p)
        {
            if(p.Trim()=="")
            {
                HasError = false;
                HasWarning = true;
                Succeeded = false;
                Message = "Server Connection Error";
                return true;
            }
            else
            {

                HasError = false;
                HasWarning = false;
                Succeeded = true;
                return false;
            } 
        }
        public void Attack_Current_HeaderS()
        {
            for (int i = 0; i < this.TargetedHeaders.Count; i++)
            {
                if (TargetedHeaders[i] == null)
                    continue;
                if (TargetedHeaders[i].string_ == "")
                    continue;
                this.TargetHeader = TargetedHeaders[i];
                TargetedHeaders[i].statue_ = Attack_Current_Header();

            }
        }
        public bool Attack_All_Headers()
        {

            string _Header;
            int skiped = 0;
            try
            {
                ////url
                var request = (HttpWebRequest)WebRequest.Create(this._Url);
                request.Timeout = this.TimeOut;
                //Default Headers/////////
                request.Accept = this.Accept;
                request.UserAgent = this.GetUserAgent();
                this.Add_RequestHeader("User-Agent", request.UserAgent);
                this.Add_RequestHeader("Accept", request.Accept);
                // send cookie or not
                if (this._Use_Cookie)
                {
                    request.Headers.Add("cookie", this._Cokie_String);
                    this.Add_RequestHeader("cookie", this._Cokie_String);
                }
                // send Auth or not
                if (this._Use_Auth)
                {
                    this.Add_RequestHeader("Authorization", this._Auth_String);
                    request.Headers.Add("Authorization", this._Auth_String);
                }


                foreach (StrBool singlehed in this.TargetedHeaders)
                {
                    _Header = singlehed.string_;

                    //Check if selected header is a protected header
                    if (_Header.ToLower() == "referer")
                    {
                        request.Referer = this.GetInjection();
                        this.Add_RequestHeader("Referer", this.GetMInjection("Referer"));
                    }

                    else if (_Header.ToLower() == "Proxy-Connection")
                    {
                        request.Proxy = new WebProxy(Payloads.GetPayload(Payload_.ip), int.Parse(Payloads.GetPayload(Payload_.Port)));
                        this.Add_RequestHeader("Referer", this.GetMInjection("Referer"));

                    }
                    else if (_Header.ToLower() == "user-agent")
                    {
                        request.UserAgent = this.GetMInjection("User-Agent");
                        this.Add_RequestHeader("User-Agent", request.UserAgent);
                    }
                    else if (_Header.ToLower() == "connection")
                    {
                        request.Connection = this.GetMInjection("Connection");
                        this.Add_RequestHeader("Connection", request.Connection);
                    }

                    else if (_Header.ToLower() == "accept")
                    {
                        request.Accept = this.GetMInjection("Accept");
                        this.Add_RequestHeader("Accept", request.Accept);

                    }


                    else if (_Header.ToLower() == "cookie") /// it is cookie injection Attack
                    {
                        this.Add_RequestHeader("cookie", this.GetMInjection("cookie"));
                        request.Headers.Add("cookie", this.GetMInjection("cookie"));
                    }

                    else // unknown header
                    {
                        try
                        {
                            string injv = this.GetMInjection(_Header);
                            request.Headers.Add(_Header.ToLower(), injv);
                            this.Add_RequestHeader(_Header.ToLower(), injv);
                        }
                        catch { skiped++; Message = "Some headers could not be included"; }
                    }
                }

                this.Add_RequestHeader("User-Agent", request.UserAgent);
                this._Method = request.Method;
                /// getting document
                var response = (HttpWebResponse)request.GetResponse();
                this.DocumentText = new StreamReader(response.GetResponseStream()).ReadToEnd();
                Thread.Sleep(100);
                /// Saving response headers
                WebHeaderCollection __respHEADERScollection = response.Headers;
                for (int i = 0; i < __respHEADERScollection.Count; i++)
                {
                    String header__ = __respHEADERScollection.GetKey(i);
                    String[] values = __respHEADERScollection.GetValues(header__);
                    if (values.Length > 0)
                        this.Add_ResponseHeader(header__, values[0]);

                    else
                        this.Add_ResponseHeader(header__, "");

                }


                this.statueCode = response.StatusCode.ToString();
                this.StatueDesc = response.StatusDescription;


                bool final_result = false;
                infected = 0;
                for (int i = 0; i < this.TargetedHeaders.Count; i++)
                {
                    string inj = this.GetMInjection(TargetedHeaders[i].string_);
                    bool res = false;

                    if (PayLoadOF != Payload_.cookie)
                        res = this.DocumentText.ToLower().ToString().Contains(inj.ToLower());
                    else
                    {
                        if (this.DocumentText.ToString().Contains(inj.ToLower()))
                            res = true;

                        else
                        {
                            List<string> cok_vals = GetInjection().GetCookieValues();
                            foreach (string s in cok_vals)
                                if (this.DocumentText.ToString().Contains(s.ToLower()))
                                {
                                    res = true;
                                    break;
                                }
                        }
                    }
                    if (res == true)
                    { final_result = true; infected++; }
                    TargetedHeaders[i].statue_ = res;

                }

                this.Succeeded = this.Processed = true;
                this.HasError = this.HasWarning = false;

                this.Message = "Vulnerable = " + infected + "         skipped = " + skiped + "          not Vulnerable =  " + (this.TargetedHeaders.Count - skiped - infected);
                return final_result;
            }
            catch (Exception exp) { this.Message=(exp.Message); this.Succeeded = false; this.HasError = true; this.HasWarning = false; this.Message = exp.Message; }
            return false;

        }

        private string GetMInjection(string p)
        {
            return "inj_" + p + "_cted";
        }

        internal int GetVulned()
        {
            int i = 0;
            foreach (StrBool s in this.TargetedHeaders)
                if (s.statue_) i++;
            return i;

        }

        internal static __HTTTPAttack_ Copy(__HTTTPAttack_ _old_)
        {
            __HTTTPAttack_ _new_ = new __HTTTPAttack_();
            _new_.UseHTTPS = _old_.UseHTTPS;
            _new_.port = _old_.port;
            _new_.Host = _old_.Host;
            _new_.owner=_old_.owner;
            _new_.Id = _old_.Id;
            _new_._Method = _old_._Method;
            _new_._Attack_Type = _old_._Attack_Type;
            _new_._Auth_String = _old_._Auth_String;
            _new_._Cokie_String = _old_._Cokie_String;
            _new_._Payload = _old_._Payload;
            _new_._Send_UserAgent = _old_._Send_UserAgent;
            _new_.TimeOut = _old_.TimeOut;
            _new_._Url = _old_._Url;
            _new_._Use_Auth = _old_._Use_Auth;
            _new_._Use_Cookie = _old_._Use_Cookie;
            _new_._UserAgentString = _old_._UserAgentString;
            _new_.Accept = _old_.Accept;
            _new_.DocumentText = _old_.DocumentText;
            _new_.HasError = _old_.HasError;
            _new_.HasWarning = _old_.HasWarning;
            _new_.infected = _old_.infected;
            _new_.Message = _old_.Message;
            _new_.Payload = _old_.Payload;
            _new_.PayLoadOF = _old_.PayLoadOF;
            _new_.Processed = _old_.Processed;
            foreach (KeyValuePair<string, string> it in _old_.Request_Headers)
                _new_.Add_RequestHeader(it.Key, it.Value);

            foreach (KeyValuePair<string, string> it in _old_.Response_Headers)
                _new_.Add_ResponseHeader(it.Key, it.Value);
            _new_.TargetHeader = _old_.TargetHeader;
            _new_.statueCode = _old_.statueCode;
            _new_.Succeeded = _old_.Succeeded;
            _new_.StatueDesc = _old_.StatueDesc;

            return _new_;
        }

        public string _Method = "";

        public string Id { get; set; }
        internal string[] ToStringArray()
        {
            List<string> l = new List<string>();
            l.Add(this._Attack_Type.ToString());
            l.Add(this._Auth_String.ToString());
            l.Add(this._Cokie_String);
            l.Add(this._Method);
            l.Add(this._Payload);
            // l.Add(this._Send_UserAgent);
            l.Add(this.TimeOut.ToString());
            l.Add(this._Url);
            l.Add(this._Use_Auth.ToString());
            l.Add(this._Use_Cookie.ToString());
            l.Add(this._UserAgentString);
            l.Add(this.Accept);
            l.Add(this.DocumentText);
            l.Add(this.HasError.ToString());
            l.Add(this.HasWarning.ToString());
            l.Add(this.Id);
            l.Add(this.infected.ToString());
            l.Add(this.Message);
            l.Add(this.PayLoadOF.ToString());
            l.Add(this.Processed.ToString());
            l.Add(this.Request_Headers.ToString());
            l.Add(this.Response_Headers.ToString());
            // l.Add(this.SingleHeader);
            l.Add(this.statueCode);
            l.Add(this.StatueDesc);
            l.Add(this.Succeeded.ToString());
            l.Add(TargetedHeaders.ToString());
            l.Add(this.TargetHeader.string_);

            return l.ToArray();
        }


        internal static string ResponseFromRequest(string[] p)
        {

            if (p.Length < 1)
                return null;
            /// Vars
            __HTTTPAttack_ a = new __HTTTPAttack_();
            string respText = "";
            string page = "";
            string host = "";

            //get the method 
            if (p[0].Contains(" ")==false)
                return null;
            string [] sepdbyspace = p[0].Split(new char[] { ' ' });
            a._Method = sepdbyspace[0].Trim().ToUpper();
            page = sepdbyspace[1].Trim().ToUpper();

            foreach(string line in p )
            {
                if (line.Contains(":")==false)
                    continue;

                string hd = "";
                string val = "";
                string lower;

                
                    string[] head_Val = line.Split(new char[] { ':' });
                    hd = head_Val[0].Trim();
                    val = head_Val[1].Trim();
                    lower = hd.Trim().ToLower(); 

                if (hd != "")
                    a.Add_RequestHeader(hd, val);
                if (lower == "host")
                    host = val;
                 }

            if (host == "")
                return null;
            a._url = "http://" + host +((host[host.Length-1]!='/' && page[page.Length-1]!='/')?"/":"")+ page;

             a.SendRequest();
             return a.ReturnHoleResponse();
             
        }

        public  string ReturnHoleResponse()
        {
            string res = "";
            foreach(KeyValuePair<string,string> k in this.Response_Headers )
                res += (k.Key+": "+k.Value+Environment.NewLine);

            res += Environment.NewLine + Environment.NewLine;
            res += this.DocumentText;


                return res;
        }

       
        public static void SetGLobalProxy(string proxy , int p =80)
        {
            WebProxy proxyObject = new WebProxy(proxy, p);
            proxyObject.BypassProxyOnLocal = true;
            WebRequest.DefaultWebProxy=proxyObject;
        }
        private static bool IsProtectedHeader(string hd)
        {

            string lower = hd.ToLower();
            return (lower=="user-agent" || lower=="referer" || lower=="accept" || lower=="connection" || lower=="proxy-connection" );
        }
          
        public bool SendRequest()
        {      ////url

            try
            {
                var request = (HttpWebRequest)WebRequest.Create(this._Url);
                request.Timeout = (this.TimeOut);
                this.Host = request.Host;
                
                try
                {
                    foreach (KeyValuePair<string, string> hd in this.Request_Headers)
                    {
                        if (__HTTTPAttack_.IsProtectedHeader(hd.Key))
                        {
                            string low = hd.Key.ToLower();
                            if (low == "user-agent"&& (this.PayLoadOF==Payload_.UserAgent || this._Send_UserAgent))
                                request.UserAgent = hd.Value;
                            else if (low == "proxy connection")
                                request.Connection = hd.Value;

                            else if (low == "referer")
                                request.Referer = hd.Value;
                            else if (low == "connection")
                                request.Connection = hd.Value;
                            else if (low == "accept")
                                request.Accept = hd.Value;

                        }
                        else if (hd.Key.ToLower().Trim() == "cookie")
                            request.Headers.Add(hd.Key.ToLower(), hd.Value);
                        else
                            request.Headers.Add(hd.Key, hd.Value);

                    }

                }
                catch { }



                var response = (HttpWebResponse)request.GetResponse();
                this.DocumentText = new StreamReader(response.GetResponseStream()).ReadToEnd();
               // Thread.Sleep(100);
                /// Saving response headers
                WebHeaderCollection __respHEADERScollection = response.Headers;
                for (int i = 0; i < __respHEADERScollection.Count; i++)
                {
                    String header__ = __respHEADERScollection.GetKey(i);
                    String[] values = __respHEADERScollection.GetValues(header__);
                    if (values.Length > 0)
                        this.Add_ResponseHeader(header__, values[0]);

                    else
                        this.Add_ResponseHeader(header__, "");
                }

                this.statueCode = response.StatusCode.ToString();
                this.StatueDesc = response.StatusDescription;
                this.Succeeded = true; this.HasError = false; this.HasWarning = false;
                this.Message = "Succeeded " ;
                return true;
            }
            catch (Exception ex){ this.Succeeded = false; this.HasError = true; this.Message = ex.Message; ;return false; }
            }
          
        

public string Host
{
  get;
  set ;
}public string owner { get; set; }

        internal bool SetFromHoleRequest(string[] p,bool sendRequest=true)
        {
            if (p.Length < 1)
                return false;
            /// Vars 
            string respText = "";
            string page = "";
            string host = "";

            //get the method 
            if (p[0].Contains(" ") == false)
                return false;
            string[] sepdbyspace = p[0].Split(new char[] { ' ' });
            this._Method = sepdbyspace[0].Trim().ToUpper();
            page = sepdbyspace[1].Trim().ToUpper();

            int counter = -1;
            foreach (string line in p)
            {
                counter++;
                if (counter == 0)
                    continue;
                if (line.Contains(":") == false)
                    continue;

                string hd = "";
                string val = "";
                string lower;


                string[] head_Val = line.Split(new char[] { ':' });
                hd = head_Val[0].Trim();
                val = head_Val[1].Trim();
                lower = hd.Trim().ToLower();

                if (hd != "")
                    this.Add_RequestHeader(hd, val);
                if (lower == "host")
                    host = val;
            }

            if (host == "")
                return false;

            host=host.TrimHost();/////// www.gooogle.com >>> google.com

            this._url = "http://" + host + ((host[host.Length - 1] != '/' && page[page.Length - 1] != '/') ? "/" : "") + page.GetPage();
            if (sendRequest)
                this.SendRequest();
            return true;
         
        }


        internal string GetMethod()
        {
            if (_Method == "")
                return "GET";
            else
                return _Method;
        }

        internal string GetURI()
        {
            if(this._url.Contains(":"))
            {

            }
            return "http"+((this.UseHTTPS)?"s://":"://")+this.Host + ":" + this.Port.ToString();
        }

        private int port = 80;

        public int Port
        {
            get { return port; }
            set
            {
                if (value > 0 && value < 65536)
                    port = value;
            }
        }
        public bool UseHTTPS = false;

        internal static string DownloadString(string url)
        {
            try
            {
                WebClient client = new WebClient();
                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
                Stream data = client.OpenRead(url);
                StreamReader reader = new StreamReader(data);
                string s = reader.ReadToEnd();
                data.Close();
                reader.Close();
                return s;
            }
            catch (Exception v) { return v.Message; }
        }

        public void ParameterizeGET(string p)
        {
            if (p.Contains("?"))
            {
                string[] sepd = p.Split(new char[] { '?' });

                this._Url = sepd[0];

                if (sepd[1].Trim() == "")
                    return;
                if (sepd[1].Contains("&"))
                {
                    string[] sepdbyAND = sepd[1].Split(new char[] { '&' });
                    foreach (string parAndVal in sepdbyAND)
                    {
                        if (parAndVal.Trim() == "")
                            continue;
                        else if (parAndVal.Contains("=") == false)
                            this.AddGetparameter(parAndVal.Trim(), "");
                        else
                        {
                            string[] sepdByEq = parAndVal.Split('=');
                            this.AddGetparameter(sepdByEq[0].Trim(), sepdByEq[1].Trim());
                        }
                    }

                }
                else if (sepd[1].Contains("=") == false)
                    this.AddGetparameter(sepd[1].Trim(), "");
                else if (sepd[1].Contains("="))
                {
                    string[] sepdByEq = sepd[1].Split();
                    this.AddGetparameter(sepdByEq[0].Trim(), sepdByEq[1].Trim());
                }


            }
            else this._Url = p;
            if (p.Contains(":"))
            {
                string[] sepdByColon = p.Split(new char[] { ':' });
                string port = sepdByColon[1].Trim();
                if (port.IsNumber())
                    this.Port = int.Parse(port);
            }

        }

        public void AddGetparameter(string p1, string p2)
        {
            p1 = p1.Trim();
            p2 = p2.Trim();
            
            for(int i=0;i<this.Get_Parameters.Count;i++)
                if (Get_Parameters[i].key.Trim() == p1)
                {
                    this.Get_Parameters[i].value = p2;
                    return;
                }
            this.Get_Parameters.Add(new StringStringbool(p1, p2));
              
        }

        internal string Summary()
        {
            if (this.HasError)
                return "Error " + this.Message;
            if (this.HasWarning)
                return "Warning " + this.Message;
            if (this.Succeeded)
                return "Succeeded " + this.Message;
            else
                return "Did not launch";


        }

        internal static string[] GetParamers(string url)
        {
            List<string> l = new List<string>();

            url=url.Trim();

            if (url == "")
                return null;
            if (url.Contains("?") == false)
                return null;

            string parsString = url.Split(new char[] { '?' })[1];
            if (parsString.Trim() == "")
                return null;

            if (parsString.Contains("&"))
            { /// a=1&b=2
                string[] sepdbyand = parsString.Split(new char[] { '&' });
                foreach(string p_and_v in sepdbyand)
                {
                    if (p_and_v.Trim() == "")
                        continue;
                    else if (p_and_v.Contains("="))
                    {
                        string[] sepdByEq = p_and_v.Split(new char[] { '=' });
                        if (sepdbyand[0] != "")
                            l.Add(sepdByEq[0]);
                    }
                    else
                        l.Add(p_and_v);
                }
            } // ?a=1
            else if (parsString.Contains("="))
            {

            }
            else
                l.Add(parsString);
                
            
            return l.ToArray();
        }



        internal bool GET_XSSER()
        {
            if(Get_Parameters.Count<1)
                return false ;
            string url = this._url+"?"+Get_Parameters[0].key+"="+Get_Parameters[0].value;

            if (Get_Parameters.Count > 1)
                for (int i = 1; i < this.Get_Parameters.Count; i++)
                    url += ("&" + Get_Parameters[i].key + "=" + Get_Parameters[i].value);

            this._url = url;
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(this._Url);
                 
                    
                request.Timeout = (this.TimeOut);
                this.Host = request.Host;

                try
                {
                    foreach (KeyValuePair<string, string> hd in this.Request_Headers)
                    {
                        if (__HTTTPAttack_.IsProtectedHeader(hd.Key))
                        {
                            string low = hd.Key.ToLower();
                            if (low == "user-agent" && (this.PayLoadOF == Payload_.UserAgent || this._Send_UserAgent))
                                request.UserAgent = hd.Value;
                            else if (low == "proxy connection")
                                request.Connection = hd.Value;

                            else if (low == "referer")
                                request.Referer = hd.Value;
                            else if (low == "connection")
                                request.Connection = hd.Value;
                            else if (low == "accept")
                                request.Accept = hd.Value;

                        }
                        else if (hd.Key.ToLower().Trim() == "cookie")
                            request.Headers.Add(hd.Key.ToLower(), hd.Value);
                        else
                            request.Headers.Add(hd.Key, hd.Value);

                    }
                }
                catch { }



                var response = (HttpWebResponse)request.GetResponse();
                this.DocumentText = new StreamReader(response.GetResponseStream()).ReadToEnd();
                Thread.Sleep(100);
                /// Saving response headers
                WebHeaderCollection __respHEADERScollection = response.Headers;
                for (int i = 0; i < __respHEADERScollection.Count; i++)
                {
                    String header__ = __respHEADERScollection.GetKey(i);
                    String[] values = __respHEADERScollection.GetValues(header__);
                    if (values.Length > 0)
                        this.Add_ResponseHeader(header__, values[0]);

                    else
                        this.Add_ResponseHeader(header__, "");
                }

                this.ScanDocumentAndResponseHeaders_Get();
                this.statueCode = response.StatusCode.ToString();
                this.StatueDesc = response.StatusDescription;
                this.Succeeded = true; this.HasError = false; this.HasWarning = false;
                this.Message = "Succeeded ";
                return true;
            }
            catch (Exception ex) { this.Succeeded = false; this.HasError = true; this.Message = ex.Message; ;return false; }


        }

        private void ScanDocumentAndResponseHeaders_Get()
        {
            this.infected = 0;
            string Victorator = this.DocumentText + Environment.NewLine;

            foreach (KeyValuePair<string, string> kv in this.Response_Headers)
                Victorator += (kv.Key + kv.Value + Environment.NewLine);

            Victorator = Victorator.ToLower();
            for(int i=0;i<this.Get_Parameters.Count;i++)
                if(Victorator.Contains(Get_Parameters[i].value.ToLower()))
                {
                    Get_Parameters[i].statue=true;
                    infected++;
                }
        }

        internal string GetXsserSummary()
        {
           // if (this._Method == "GET")
           // {
                string res = "";
                foreach (StringStringbool s in this.Get_Parameters)
                    res += (s.key + ":" + s.value + " =>" + s.statue + Environment.NewLine);
                return res;
           // }
            //else
               // return "";
        }

        internal static string ReturnAllResponse(string st)
        {
            return "<br /> </br><br /> <h2>Welcome no implementaion </h2> </br><br /> </br><br /> </br>";
        }

        //internal static __HTTTPAttack_ SetUpFromHoleRequest(string st)
        //{
        //    __HTTTPAttack_ a = new __HTTTPAttack_();
        //    int i=0;
        //    foreach (string h in st.Split(new char[] { '\n'}))
        //    {
        //        if (i != 0)
        //        {
        //            string[] sepdbyColn = h.Split(new char[] { ':' });
        //            if (h.Contains(":"))
        //                a.Add_RequestHeader(sepdbyColn[0].Trim(), sepdbyColn[1].Trim());
        //            else
        //                a.Add_RequestHeader(sepdbyColn[0].Trim(), "");

        //        }
        //        i++;
        //    }
        //    a.SetFromHoleRequest(st.Split(new char []{'\r'}));
        //    a.GuessHostAndUrl(st);

        //    return a;
        //}

        private void GuessHostAndUrl(string st)
        {
            
            string [] sepd_by = st.Split(new char [] {' '});
            if (sepd_by[0].IsUrl())
                this._url = sepd_by[1];
            else
            {
                string[] sepdbylines = st.Split(new char[] { '\r' });
                foreach(string l in sepdbylines)
                {
                    if(l.Contains("Host"))
                    {
                        string[] sepd_byColn = l.Split(new char[] { ':' });
                        this.Host = this._url = sepdbylines[1];
                    }
                }
            }
        }

        internal static string LoadScriptSource(string link)
        {
            try
            {
                __HTTTPAttack_ a = new __HTTTPAttack_(link);
                a.LoadFromSettings(false);
                a.SendRequest();
                return a.DocumentText;
            }
            catch { return ""; } 

        }

        internal string ReturnResponseHeaders()
        {
            string res = "";
            foreach (KeyValuePair<string, string> k in this.Response_Headers)
                res += (k.Key + ":" + k.Value + Environment.NewLine);
            return res;
        }
    }
        public class AttackProcess
        {
            public WebRequest Req;
            //     public Dictionary<string, string> Headers = new Dictionary<string, string>();
            public List<string> TargetedHeaders = new List<string>();
            public Dictionary<string, string> Request_Headers = new Dictionary<string, string>();
            public Dictionary<string, string> Response_Headers = new Dictionary<string, string>();
            public WebResponse Res;
            public int infected = 0;
            public string DocumentText = "";
            public string statueCode = "";
            public string StatueDesc = "";
            public string url = "";
            public string injectionPayload = "";
            public bool Succeeded = false;
            public string error = "";
            public bool HasWarning = false;
            public AttackProcess(string r, string sc, string sd = "")
            { 
                DocumentText = r;
                statueCode = sc;
                statueCode = sd
                    ;
            }
            public AttackProcess(bool prox = false)
            {
                this.Processed = prox;
            }
            public AttackProcess(string sour, HttpStatusCode sc, string sd = "")
            {
                DocumentText = sour;
                statueCode = sc.ToString();
                statueCode = sd;
            }
            public AttackProcess(bool suc, string note)
            {
                Succeeded = suc;
                error = note;
            }
            public AttackProcess()
            {
                DocumentText = "";
                statueCode = "00";
                StatueDesc = "Error";
                this.Succeeded = false;

            }
            internal string GetSingleTarget()
            {
                if (this.TargetedHeaders == null) return "";
                else if (TargetedHeaders.Count > 0)
                    return this.TargetedHeaders[0];
                else return "";
            }
            public int MakeAresult()
            {
                infected = 0;
                if (this.DocumentText.Contains("_injected_user-agent_"))
                    infected++;
                if (this.DocumentText.Contains("_injected_cookie_"))
                    infected++;

                if (this.DocumentText.Contains("_injected_referer_"))
                    infected++;
                if (this.DocumentText.Contains("_injected_x-forwarded-for_"))
                    infected++;

                foreach (string h in __HTTTPAttack_._Allowed_Headers_)
                    if (DocumentText.Contains("_injected_" + h))
                        infected++;
                return infected;
            }
            public bool NormalInjectable()
            {
                return (DocumentText.Contains("fuckkcuf"));
            }

            internal bool InectableTo(string x = "")
            {
                return (DocumentText.Contains(x));
            }

            internal bool CookieReflected()
            {
                if (DocumentText.Contains("injected_cookie")) return true;
                else return
               (DocumentText.ToLower().Contains("_injected_cookie_"));

            }

            public string warning { get; set; }

            public void Add_RequestHeader(string p1, string p2)
            {
                p1 = p1.Trim();
                foreach (KeyValuePair<string, string> it in Request_Headers)
                    if (it.Key == p1.Trim())
                    {
                        Request_Headers[p1] = p2; return;
                    }


                Request_Headers.Add(p1, p2);
            }
            public void Add_ResponseHeader(string p1, string p2)
            {
                p1 = p1.Trim();
                foreach (KeyValuePair<string, string> it in Response_Headers)
                    if (it.Key == p1.Trim())
                    {
                        Response_Headers[p1] = p2; return;
                    }


                Response_Headers.Add(p1, p2);
            }
            public string Get_RequestHeaderValue(string hn)
            {
                foreach (KeyValuePair<string, string> it in Request_Headers)
                    if (it.Key == hn)
                        return it.Value;

                return null;
            }
            public string Get_ResponseHeaderValue(string hn)
            {
                foreach (KeyValuePair<string, string> it in Response_Headers)
                    if (it.Key == hn)
                        return it.Value;

                return null;
            }

            public bool Processed = false;

        }
        public class Payloads
        {
            public static string GetPayload(Payload_ p)
            {
                switch (p)
                {
                    case Payload_.empty: return "";
                    default:
                    case Payload_.Port: return "9999";
                    case Payload_.string_:
                    case Payload_.fuck: return "fuckkcuf";
                    case Payload_.url: return "http://_inj_referer_ected__.net";
                    case Payload_.integer: return "1111014041";
                    case Payload_.ip: return "141.141.141.141";
                    case Payload_.alert: return "<ScripT>alert(17730);</ScripT>";
                    case Payload_.cookie: return "c_user=_inj_cookie_ected__;";//p=_injected_cookie_;;user=gersy;id=1; __utma= __utma;__utmc=__utmc;__utmz=__utmz;phpsessid=phpsessid;auth_token=gersy_auth_token;language_id=1_language_id";
                    case Payload_.UserAgent: return "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.65 Safari/537.36";
                    case Payload_.SpecialChars: return "'\'>!>->\"--><img src='4' onerror='prompt('199');<!--'<!--";
                }
            }
            public static DateTime GetPayload_DateFormat(Payload_ p)
            {
                if (p == Payload_.ifModifiedSince)
                    return new DateTime(2, 2, 2, 2, 2, 2);
                else
                    return new DateTime(1, 1, 1, 1, 1, 1);

            }

            public static string GuessPayload(string p)
            {
                p = p.Trim().ToLower();
                Payload_ pay = Payload_.string_;
                if (p == "x-forwarded-for")
                    pay = Payload_.ip;
                else if (p == "referer")
                    pay = Payload_.url;
                else if (p == "date" || p == "lastmodified")
                    pay = Payload_.Date;

                else if (p == "cookie")
                    pay = Payload_.cookie;
                return Payloads.GetPayload(pay);

            }

            internal static string Percent(string p)
            {
                int i=0; 
                if (p.Contains("'"))
                    i += 10;
                if (p.Contains("\""))
                    i += 10;

                if (p.Contains("!"))
                    i += 10;
                
                if (p.Contains("\\"))
                    i += 20;
                
                if (p.Contains("/"))
                    i += 10;

                if (p.Contains("<"))
                    i += 20;

                if (p.Contains(">"))
                    i += 20;
                if (i < 20)
                    i = 20;
                return "%"+i.ToString();
            }
        }
        public class _Request_Commiter
        {
            public static List<string> _Protected_Headers_ = new List<string>() { "Connection", "Host", "User-Agent", "Referer", "Proxy-Connection", "Expect", "Range", "Date", "If-Modified-Since", "Cookie", "Connection", "Content-Length", "Accept", "Content-Type" };
            public const string Connection = "Connection", UserAgent = "User-Agent", Referer = "Referer", ProxyConnection = "Proxy-Connection", Expect = "Expect", Range = "Range", Date = "Date", IfModSince = "If-Modified-Since", cookie = "Cookie", ContentLength = "Content-Length", Accept = "Accept", ContentType = "Content-Type";
            public Dictionary<string, string> _HeaderS = new Dictionary<string, string>();
            public string statue = "IDLE";
            public WebResponse Res;
            public string url = "";
            bool suc = false;
            public _Request_Commiter()
            {

            }
            public string Proceed()
            {
                try
                {
                    if (url.IsUrl() == false)
                        return "BadUrl";

                    var Req = (HttpWebRequest)WebRequest.Create(url);
                 
                    foreach (KeyValuePair<string, string> kvp in _HeaderS)
                        if (_Protected_Headers_.Contains(kvp.Key) == false)
                            Req.Headers.Add(kvp.Key, kvp.Value);
                        else
                        {
                            string h = kvp.Key.ToLower();
                            //ua ref acc conn contyp  exp ifmodsin date 
                            if (h == "user-agent" || h == "useragent")
                                Req.UserAgent = kvp.Value;
                            else if (h == "referer")
                                Req.Referer = kvp.Value;
                            else if (h == "accept")
                                Req.Accept = kvp.Value;
                            else if (h == "connection")
                                Req.Connection = kvp.Value;
                            else if (h == "contenttype" || h == "content-type")
                                Req.ContentType = kvp.Value;
                            else if (h == "expect")
                                Req.Expect = kvp.Value;

                        }
                    Res = Req.GetResponse();
                    statue = "Succeed";
                    return "true";
                }
                catch (Exception z)
                {
                    statue = "failed";
                    return z.Message;
                }
            }
        }
        public class StrBool
        {
            public string string_ = "";
            public bool statue_ = false;
            public StrBool(string s = "", bool b = false)
            {
                string_ = s;
                statue_ = b;

            }
            public StrBool(bool b = false, string s = "")
            {
                string_ = s;
                statue_ = b;

            }
        }
    public class RequestDetails
    {
        private string _host = "google.com";

        public string host 
        {
            get { return _host; }
            set { if(value!="")_host = value; }
        }
        private decimal _port = 80;

        public decimal port
        {
            get { return _port; }
            set { if (value > 0 && value < 65535)_port = value; }
        }
        public RequestDetails(string host="",int port=80,bool s=false,int t=10)
        {
            this.host = host;
            this.port = port;
            this.useHttps = s;
            TimeOut = t;


        }
        public RequestDetails(int port=80,string host="", bool s=false )
        {

            this.host = host;
            this.port = port;
            this.useHttps = s;
        }

        internal string GetUrl()
        {

            return "http" + ((this.useHttps) ? "s://" : "://") + host +":" + port;
        }

        public bool useHttps = false;
        public int TimeOut=11;

        internal bool IsDefaulTimeOut()
        {
            return TimeOut == 11;
        }
    }
    public enum Payload_ { empty, fuck, integer, string_, ip, alert, referer, cookie, Date, ifModifiedSince, url, Port, UserAgent, SpecialChars }
        public enum _ARank_
        { Single, Many };
        public enum _AType_ { str_, int_, url_, mobile_, fax_, ip_, script_ }
        public enum _Statue_ { Vulnerable, Safe };
        public class StringStringbool 
        {
            public string key = "";
            public string value = "";
            public bool statue = false;
            public StringStringbool(string k , string v="",bool b=false)
            {
                key = k;
                value = v;
                statue = b;
            }
        
        }
      
}



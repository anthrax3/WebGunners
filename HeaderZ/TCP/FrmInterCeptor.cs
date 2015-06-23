using Web_Gunners;
using Web_Gunners.Forms.Tools;
using ProxyTool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Gunners.Forms.Tools
{
    public partial class FrmInterCeptor : Form
    {
        public enum InterCeptionMode { request,response}

        public List<String2> Reqs = new List<String2>();
        public string __Current_request = "";
        public InterCeptionMode _InterceptionMode = InterCeptionMode.request;

        public bool __IntercepStatue_ = false;
        public bool __Listening = false;
        

        public FrmInterCeptor()
        {
            InitializeComponent();
        }

        private void FrmInterCeptor_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            __Listening = !__Listening;
            if (__Listening)
            {
                this.Notify("Starting Proxy Tool...");
                ThreadPool.QueueUserWorkItem(StartServer);
                this.__IntercepStatue_ = true;
            }
            else
            {
                ThreadPool.QueueUserWorkItem(StopServer);
                this.Notify("Proxy off...");

            }
            checkControls();
        }

        public void Notify(string p)
        
        { 
            Invoke(new Action(() => lblNotf.Text=(p)));

        }

        public void WriteLine(string p)
         {
             Invoke(new Action(() => RtxbxBody.AppendText(p)));
        }
        HttpServer Server__;
         void StartServer(object state)
        {
            Server__ = new HttpServer();
            Server__.frm_obj=this;
            Server__.Start(int.Parse(NM_watcher_port.Value.ToString()));
        }
        void StopServer(object state)
         {
             if (this.__Listening)
                 return;

             Server__.stop();

         }

         internal RequestStatue GetStatue(long st)
         {
             if (this.__IntercepStatue_)
             {
                 foreach (String2 k in this.Reqs)
                     if (k.id == st)
                         return k.value;

                 return RequestStatue.Wait;

             }
             else return RequestStatue.Pass;
         }


         internal void AddRequest(string st,long id)
         {
             this._InterceptionMode = InterCeptionMode.request;
             foreach (String2 s2 in this.Reqs)
                 if (s2.id == id)
                 { 
                     s2.value = RequestStatue.Wait;
                     ReBuildListBox();
                        return;
                 }
             this.Reqs.Add(new String2(st,id));
             ReBuildListBox();
             checkControls();
         }

         private void ReBuildListBox()
         {
           //  Invoke(new Action(() => listBox1.Items.Clear()));

             Invoke(new Action(() => RtxbxBody.Text = ("")));
        //     Invoke(new Action(() => richTextBox1.Text= ("")));
              
             bool filled = false;
             foreach (String2 s in Reqs)
             {
                 if (s.value == RequestStatue.Wait)
                 {
                 //    Invoke(new Action(() => listBox1.Items.Add(s.key)));
                     if (filled == false)
                     { if(this.__IntercepStatue_)
                         Invoke(new Action(() => RtxbxBody.Text = (s.key)));
                         filled = true;
                     }
                 }
               //  Invoke(new Action(() => richTextBox1.Text += (Environment.NewLine+s.value + " ____" + s.key.Substring(45,100) + ":"+s.value)));

                  
             }



         }

         private void btnPass_Click(object sender, EventArgs e)
         {
             if (this._InterceptionMode == InterCeptionMode.request)
             {
                 this.__Current_request = RtxbxBody.Text;
                 this.Pass();
             }
             else
             {
                 this.__InterceptinResponse = false;

             }
               
             
         }
        
         private void Pass( bool pass_all=false)
         {
             Working = true;
             for (int i = 0; i < Reqs.Count; i++)
             { 
                  if (Reqs[i].value == RequestStatue.Wait)
                  { 
                      Reqs[i].value = RequestStatue.Pass;
                      if (!pass_all)
                          break;
                  }
             }
             Invoke(new Action(() => ReBuildListBox()));
             Working = false;
         }

         private void Reject(bool Reject_all=false)
         {
             Working = true;
             for (int i = 0; i < Reqs.Count; i++)
                 if (Reqs[i].value == RequestStatue.Wait)
                 {
                     Reqs[i].value = RequestStatue.Reject;
                     if (!Reject_all)
                         break;
                 }

             Invoke(new Action(() => ReBuildListBox()));

             Working = true;
         }

         private void btnReject_Click(object sender, EventArgs e)
         {
             Reject();

         }

         internal void Proceed()
         {
             for (int i = 0; i < Reqs.Count; i++)

                 if (Reqs[i].value != RequestStatue.Wait)
                 {
                     // Reqs[i].value = RequestStatue.Proceeded;
                     Reqs.Remove(Reqs[i]);
                     break;
                 }

             Invoke(new Action(() => ReBuildListBox()));
         }

         private void btnSwitchIntercept_Click(object sender, EventArgs e)
         {
             this.__IntercepStatue_ =  !this.__IntercepStatue_;
             checkControls();

             if (this.__IntercepStatue_ == false && this.__Listening)
                 Pass(true);
         }

     
         private void checkControls()
         {
             Invoke(new Action(() => btnSwitchIntercept.Text = "Intercept is " + ((this.__IntercepStatue_) ? " On" : " Off")));
             Invoke(new Action(() => btnListen.Text = (this.__Listening ? "Listening" : "Listen")));
             Invoke(new Action(() => btnRejectAll.Enabled = btnReject.Enabled = btnPass.Enabled = (Reqs.Count > 0)));
             Invoke(new Action(() => btnSwitchIntercept.Enabled = this.__Listening));

               
         }

         private void btnRejectAll_Click(object sender, EventArgs e)
         {
             Reject(false);
             ReBuildListBox();
         }

         private void FrmInterCeptor_Load_1(object sender, EventArgs e)
         {
            
         }


         internal bool IsBusyNow()
         {
             return this.Working;
         }

         public bool Working = false;

         internal void SaveAttack(__HTTTPAttack_ h)
         {

         }

         internal string GetRequest()
         {
             return this.__Current_request;
         }

         private void btnInterceptResponse_Click(object sender, EventArgs e)
         {
             this.PassAndInterceptResponse();
         }

         private void PassAndInterceptResponse()
         {
             Working = true;
             for (int i = 0; i < Reqs.Count; i++)
                 if (Reqs[i].value == RequestStatue.Wait)
                 {
                     Reqs[i].value = RequestStatue.InterceptResponse;
                     break;
                 }
             Invoke(new Action(() => ReBuildListBox()));
             Working = false;
         }

         internal bool proceed_Response_Interception()
         {
             return this.__InterceptinResponse;
         }

         internal string Return_Intercepted_response()
         {
             return this._interception_response;
         }


         public string _interception_response = "";

         public bool __InterceptinResponse =false;

         internal void setCurrentInterceptedResponse(string resp)
         {
             this._interception_response = resp;
             this._InterceptionMode = InterCeptionMode.response;
         }
    }
    }
namespace ProxyTool
{
    class HttpServer
    {

        public FrmInterCeptor frm_obj;
        TcpListener _tcpListener;
        public void Start(int port)
        {
            try
            {

                 _tcpListener = new TcpListener(IPAddress.Any, port);
                if (frm_obj.__Listening == false)
                {
                    _tcpListener.Stop();
                    return;
                }
                _tcpListener.Start();
                frm_obj.Notify("Server Started at port " + port.ToString());

                while (true)
                {
                    var newClient = _tcpListener.AcceptTcpClient();
                    ThreadPool.QueueUserWorkItem(new WaitCallback(ProcessClient), newClient);

                }
            }
            catch (Exception x) { MessageBox.Show("Used "); }

        }
        TcpClient client;
        void ProcessClient(object state)
        {
             client = (TcpClient)state;
            var buffer = new byte[1024];
            var clientData = new StringBuilder();
            var isRequestCompleted = false;

 
            using (var stream = client.GetStream())
            {
                // Loop to receive all the data sent by the client.
                int bytesRead = 0;
                do
                {
                    // read the data
                    try
                    {
                        bytesRead = stream.Read(buffer, 0, buffer.Length);
                        if (bytesRead > 0)
                        {
                            // Translate data bytes to an ASCII string and append
                            clientData.Append(
                                Encoding.ASCII.GetString(buffer, 0, bytesRead));
                        }
                    }
                    catch (IOException ioe)
                    {
                        // read timed out, all data has been retrieved
                        Console.WriteLine("Read timed out: {0}", ioe.ToString());
                        bytesRead = 0;
                    }

                    isRequestCompleted = buffer.Contains((byte)10);
                }
                while (bytesRead == buffer.Length || !isRequestCompleted);

                frm_obj.Notify("Client says: "+ clientData.ToString());
                string st = /*"HTTP/1.1 200 OK\r\nContent-Type: text/plain\r\n\r\n" +*/ clientData.ToString();
                long id = Extender.CurrentStamp();
                // Send back a response.

                //var request = Encoding.ASCII.GetBytes(st);
                //stream.Write(request, 0, request.Length);
                frm_obj.AddRequest(st, id);
                while (true)
                {
                    if(frm_obj.IsBusyNow())
                        Thread.Sleep(1000);


                    RequestStatue r = frm_obj.GetStatue(id);
                    if (r == RequestStatue.Pass || r == RequestStatue.InterceptResponse)
                    {
                        st = frm_obj.GetRequest();
                        __HTTTPAttack_ h = new __HTTTPAttack_();
                        h.SetFromHoleRequest(st.Split(new char[] { '\n' }),true);
                         frm_obj.SaveAttack(h);

                        string resp = h.DocumentText;
                        if (r == RequestStatue.Pass)
                        {
                            frm_obj.setCurrentInterceptedResponse(resp);
                            while (true)
                            {
                                if (frm_obj.proceed_Response_Interception())
                                    break;
                                resp = frm_obj.Return_Intercepted_response();
                                Thread.Sleep(2000);
                            }
                        }

                        var request = Encoding.ASCII.GetBytes(resp);
                        stream.Write(request, 0, request.Length);
                        frm_obj.Proceed(); 
                        return;
                    }
                    else if (r == RequestStatue.Wait)

                        Thread.Sleep(1000);
                    else
                    {
                        string resp = "<body><div id=\"container\"><div class=\"title\"><h2>Web_Gunners Professional</h2></div><h3>Error</h3><p>Request was dropped by user.</p><p>&nbsp;</p></div></body>";
                        var request = Encoding.ASCII.GetBytes(resp);
                        stream.Write(request, 0, request.Length);
                        frm_obj.Proceed();

                     //   frm_obj.WriteLine("Rejected");
                        return;
                    }

                }
//                File.WriteAllText(Application.StartupPath + "\\prox", st);

            }
        }

        internal void stop()
        {
            _tcpListener.Stop();
        }
    }
}
public enum RequestStatue { Pass, Wait, Reject, InterceptResponse }

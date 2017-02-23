using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TwilioClientWebFormsDemo
{
    /// <summary>
    /// Summary description for Twiml
    /// </summary>
    public class Twiml : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/xml";

            var response = new Twilio.TwiML.VoiceResponse();
            response.Say("Hello World");

            context.Response.Write(response.ToString());
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Twilio.Jwt;
using Twilio.Jwt.Client;

namespace TwilioClientWebFormsDemo
{
    /// <summary>
    /// Summary description for Token
    /// </summary>
    public class Token : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/json";

            // Create a random identity for the client
            var identity = context.Request.QueryString["name"];

            // Create an Access Token generator
            var scopes = new HashSet<IScope>
            {
                { new IncomingClientScope(identity) },
                { new OutgoingClientScope("[YOUR_TWILIO_TWIML_APPLICATION_SID]") }
            };
            var capability = new ClientCapability("[YOUR_TWILIO_ACCOUNT_SID]", "[YOUR_TWILIO_AUTH_TOKEN]", null, scopes);
            var token = capability.ToJwt();

            context.Response.Write(
                JsonConvert.SerializeObject(new { identity = identity, token = token })
            );
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
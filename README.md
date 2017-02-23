# TwilioClientWebFormsDemo
Example demonstrating how to use Twilio Client in a WebForms app. Uses the latest Twilio helper library available on Nuget.

The sample contains four interesting files:

- Token.ashx - a generic HTTP Handler that generates and returns a JSON object containing th client identity and capability token
- Twiml.ashx - a generic HTTP handle that generates and return the Twiml instructions Twilio will request and execute once the client instance connects to Twilio
- Index.aspx - the example UI with references to the Twilio Client javascript SDK and jquery
- quickstart.js - contains the client side Twilio Client SDK code

To use the demo you need to add your own Twilio Application SID, Twilio Account Sid and Auth Token to the token.ashx file.

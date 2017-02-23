<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TwilioClientWebFormsDemo.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="//media.twiliocdn.com/sdk/js/client/v1.3/twilio.min.js"></script>
    <script type="text/javascript" src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.1.1/jquery.min.js"></script>
    <script src="quickstart.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="controls">
      <div id="info">
        <p class="instructions">Twilio Client</p>
        <div id="client-name"></div>
      </div>
      <div id="call-controls">
        <p class="instructions">Make a Call:</p>
        <input id="phone-number" type="text" placeholder="Enter a phone # or client name" />
        <button type="button" id="button-call">Call</button>
        <button type="button" id="button-hangup">Hangup</button>
      </div>
      <div id="log"></div>
    </div>
    </form>
</body>
</html>

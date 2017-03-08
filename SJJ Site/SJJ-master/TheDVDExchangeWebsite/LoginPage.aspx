<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginPage.aspx.cs" Inherits="LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <p>Username:</p>
    <asp:TextBox id="usernameTextBox"  runat="server" />
        <br />
          <p>Password:</p>
    <asp:TextBox id="passwordTextBox" TextMode="Password"  runat="server" />
   
        <br />
        <br />
        <asp:Button id="LoginButton" Text="Login" OnClick="Login" runat="server"/>
    </div>
   
    </form>
</body>
</html>

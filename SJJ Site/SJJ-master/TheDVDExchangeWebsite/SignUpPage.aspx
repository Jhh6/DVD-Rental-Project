<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SignUpPage.aspx.cs" Inherits="SignUpPage" %>

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
           <p>Email:</p>
    <asp:TextBox id="EmailTextBox"  runat="server" />
        <br />
        <br />
        <asp:Button id="CreateAccountButton" Text="Create" OnClick="CreateAccount" runat="server"/>
    </div>
    </form>
</body>
</html>

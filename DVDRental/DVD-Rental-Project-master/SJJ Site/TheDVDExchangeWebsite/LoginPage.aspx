<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginPage.aspx.cs" Inherits="LoginPage" %>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
    <style>
  h1 {color: white; font-family: garamond; font-size: 60px; }
        p {color:white; font-size: 20px;}
        
        </style>

    <link rel="stylesheet" href="StyleSheet.css" />



    <link rel="stylesheet" href="StyleSheet.css" />
</head>
<body>

         <h1 style="text-align:center">
       SJJ DVD Exchange
    </h1><br /><br />
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

        <asp:Button id="GoBack" Text="Back to Home Page" OnClick="BackToHomePage" runat="server"/>
    </div>
   
    </form>
</body>
</html>

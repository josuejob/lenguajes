<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Client.aspx.vb" Inherits="WebApplication1.Client" %>

<!DOCTYPE html>
<link href="boton.css" rel="stylesheet" />
<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 1050px;
            height: 387px;
        }
        .auto-style3 {
            margin-left: 0px;
            margin-top: 8px;
            border-radius:5px;
            font-family:Arial;
            font-size:large;

        }
        .auto-style4 {
          
        border-style: none;
            border-color: inherit;
            border-width: medium;
            background: #3a7999;
            color: #f2f2f2;
            padding: 10px;
            font-size: 18px;
            border-radius: 5px;
            position: relative;
            box-sizing: border-box;
            transition: all 500ms ease;
            left: 108px;
            top: -14px;
            width: 564px;
            height: 74px;
        }

        .auto-style4:hover {
 background: rgba(0,0,0,0);
 color: #3a7999;
 box-shadow: inset 0 0 0 3px #3a7999;
}
        .auto-style6 {
            width: 223px;
            height: 162px;
            margin-left: 396px;
        }
        body {
    background-color: lightblue;
}
        


        input { font:12px arial; }
  
a {
    color:#0000FF;
    text-decoration:none; }
  
    a:hover { text-decoration:underline; }
  
#wrapper, #loginform {
    margin:0 auto;
    padding-bottom:25px;
    background:#EBF4FB;
    width:504px;
    border:1px solid #ACD8F0;
    border-radius:10px;
}
    
  
#loginform { padding-top:18px; }
  
    #loginform p { margin: 5px; }
  
#chatbox {
    text-align:left;
    margin:0 auto;
    margin-bottom:25px;
    padding:10px;
    background:#fff;
    height:270px;
    width:430px;
    border:1px solid #ACD8F0;
    overflow:auto;
    border-radius:5px;
}
  
#usermsg {
    width:395px;
    border:1px solid #ACD8F0; }
  
#submit { width: 60px; }
  
.error { color: #ff0000; }
  
#menu { padding:12.5px 25px 12.5px 25px;
        
}
  
.welcome { float:left; }
  
.logout { float:right; }
  
.msgln { margin:0 0 2px 0; }




        .auto-style8 {
            margin-left: 29px;
        }




    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style2">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label1" runat="server" Text="Ejemplo de Web service para Timbrado de Nómina por Texto " Font-Names="Baskerville Old Face" Font-Size="24pt" ForeColor="#003366"></asp:Label>
                <br />
        <br />
        <img src="Imagen/logo%20sin%20fondo%202.png" class="auto-style6" />
        <br />
        <br />
                <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnNnaTexto" runat="server" Text="Generar Nomina mediante Texto" CssClass="auto-style4" />
                <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server" Height="213px" TextMode="MultiLine" Width="565px" CssClass="auto-style3"></asp:TextBox>
    </div>





    </form>


<%--


    <p>
        <br />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>




    <div id="wrapper">
        <div id="menu">
            <p class="welcome">Bienvenido </p>
            <p class="logout"><a id="exit" href="#">Exit Chat</a></p>
            <div style="clear:both">
            </div>
        </div>
        <div id="chatbox">
        </div>
        <input name="usermsg" type="text" id="usermsg" size="63" class="auto-style8" />
        <input name="submitmsg" type="submit"  id="submitmsg" value="Send" />
    </div>--%>

    </body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Demolab2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">

</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <asp:GridView ID="GvProveedor" runat="server" Width="1011px" OnSelectedIndexChanged="GvProveedor_SelectedIndexChanged" AllowPaging="True" AutoGenerateSelectButton="True" OnPageIndexChanging="GvProveedor_PageIndexChanging">
        </asp:GridView>
            </div>
        <div class="container-fluid">
            <asp:GridView ID="GvListaClientesPais" runat="server" Width="1081px"></asp:GridView>
        </div>
        
    </form>
   
        
</body>
</html>

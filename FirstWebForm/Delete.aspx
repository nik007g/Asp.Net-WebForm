<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="FirstWebForm.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/GridStyle.css" rel="stylesheet" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 150px;
            width: 326px;
        }
    </style>
</head>
<body style="background-color: Gray;">
    <form runat="server">
        <div  style="margin:auto;background-color:white; " class="auto-style1">
            <div style="padding-left:20px;">
    <h4>&nbsp;</h4>
 <h4>&nbsp; Are you sure you want to delete the&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Movie record?</h4>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
    <asp:Button runat="server" text="Delete" class="btn btn-danger "  OnClick="Delete"/>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button runat="server" text="Cancel" class="btn btn-default"  OnClick="redirect"/>
            </div>
            </div>
    </form>
</body>
</html>

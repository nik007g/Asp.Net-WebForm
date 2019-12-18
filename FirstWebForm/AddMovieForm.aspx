<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddMovieForm.aspx.cs" Inherits="FirstWebForm.AddMovieForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 274px;
            height: 370px;
        }
    </style>
</head>
<body style="background-color: Gray;">
    <form id="form2" runat="server" style="margin: auto; background-color: white;" class="auto-style1">
        <div style="padding-left: 20px;">

            <div class="form-group">
                <br />
                <asp:Label runat="server">Movie Name</asp:Label>
                <br />
                <asp:TextBox runat="server" class="form-control" ID="MovieName" placeholder="Enter Movie Name" Width="234px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="Red"
                    ControlToValidate="MovieName" runat="server"
                    ErrorMessage="Please Enter Movie Name">
                </asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <asp:Label runat="server">Category</asp:Label>
                <br />
                <asp:TextBox runat="server" class="form-control" ID="Category" placeholder="Enter Movie Name" Width="234px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ForeColor="Red"
                    ControlToValidate="Category" runat="server"
                    ErrorMessage="Please Enter Category">
                </asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <asp:Label runat="server">Rating</asp:Label>
                <br />
                <asp:TextBox runat="server" class="form-control" ID="Rating" placeholder="Enter Movie Name" Width="234px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ForeColor="Red"
                    ControlToValidate="Rating" runat="server"
                    ErrorMessage="Please Enter Rating">
                </asp:RequiredFieldValidator>
                <br />
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="Rating"
                    ErrorMessage="Enter value between (1-10)" ForeColor="Red" MaximumValue="10" MinimumValue="1"
                    SetFocusOnError="True" Type=" Integer">
                </asp:RangeValidator>
            </div>
            <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button class="btn btn-primary" ID="AddMovieButton" runat="server" OnClick="AddButton" Text="Add Movie" />
            <a class="btn btn-default" href="ViewAllMovies.aspx" runat="server">Cancel</a>
            </div>
        </div>
    </form>
</body>
</html>

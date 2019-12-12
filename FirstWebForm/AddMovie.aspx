<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true" CodeBehind="AddMovie.aspx.cs" Inherits="FirstWebForm.AddMovie" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="card">
        <h1>ASP.NET Movie Project</h1>
    </div>
   
    <div class="form-group ">
        <asp:Label class="control-label " runat="server" Height="26px" Style="margin-left: 93px">Movie Name</asp:Label>
        <br />
        <asp:TextBox runat="server" class="form-control" ID="MovieName" Style="margin-left: 93px" 
            Height="26px" OnTextChanged="MovieName_TextChanged" Width="213px" placeholder="Enter Movie Name">

        </asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="Red"
            ControlToValidate="MovieName" runat="server"
            ErrorMessage="Please Enter Movie Name" Style="margin-left: 93px">
        </asp:RequiredFieldValidator>
    </div>

    <div class="form-group">
        <asp:Label class="control-label" runat="server" Height="26px" Style="margin-left: 93px" >Category</asp:Label>
        <br />
        <asp:TextBox runat="server" class="form-control" ID="Category" Height="26px" Width="213px" Style="margin-left: 93px" 
            placeholder="Enter Category">

        </asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ForeColor="Red"
            ControlToValidate="Category" runat="server" ErrorMessage="Please Enter A Category" Style="margin-left: 93px">
        </asp:RequiredFieldValidator>
    </div>
    <div class="form-group">
        <asp:Label class="control-label" runat="server" Height="26px" Style="margin-left: 94px" >Rating</asp:Label>
        <br />
        <asp:TextBox runat="server" class="form-control" ID="Rating" Height="26px" Width="213px" Style="margin-left: 93px"
            placeholder="Enter Rating" >

        </asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ForeColor="Red"
            ControlToValidate="Rating" runat="server" ErrorMessage="Please Enter Rating" Style="margin-left: 93px" >
        </asp:RequiredFieldValidator>

        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="Rating"
            ErrorMessage="Enter value in  range 1 to 10" ForeColor="Red" MaximumValue="10" MinimumValue="1"
            SetFocusOnError="True" Type=" Integer" Style="margin-left: 93px"></asp:RangeValidator>

    </div>

    <div>
        <asp:Button class="btn btn-primary" ID="AddMovieButton" runat="server" OnClick="AddButton" Text="Add Movie" Width="183px" Style="margin-left: 93px" />
    </div>
    <div>
        <asp:Label ID="labelSuccessMessage" runat="server" Height="26px" Style="margin-left: 94px"></asp:Label>
    </div>
    <p>
        &nbsp;
    </p>
       

</asp:Content>


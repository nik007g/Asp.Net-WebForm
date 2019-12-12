﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewAllMovies.aspx.cs" Inherits="FirstWebForm.ViewAllMovies" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="Content/Site.css" rel="stylesheet" />
    <link href="Content/GridStyle.css" rel="stylesheet" />
    <h1>Movie List</h1>

    <asp:GridView ID="GridView1" runat="server"
        AutoGenerateColumns="false"
        AutoGenerateDeleteButton="true"
        AutoGenerateEditButton="true"

        DataKeyNames="MovieId"
        CssClass="mygrdContent"
        PagerStyle-CssClass="pager"
        HeaderStyle-CssClass="header"
        OnRowDeleting="GridView1_RowDeleting"
        OnRowUpdating="OnRowUpdating" 
        OnRowEditing="OnRowEditing"
        OnRowCancelingEdit="OnRowCancelingEdit">

           <Columns>
               <asp:TemplateField HeaderText="Movie Name" >
                    <ItemTemplate>
                        <asp:Label ID="lblMovieName" runat="server" Text='<%# Eval("MovieName") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtMovieName" runat="server" Text='<%# Eval("MovieName") %>' Width="140"></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>


               <asp:TemplateField HeaderText="Category" >
                    <ItemTemplate>
                        <asp:Label ID="lblCategory" runat="server" Text='<%# Eval("Category") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtCategory" runat="server" Text='<%# Eval("Category") %>' Width="140"></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>


                 <asp:TemplateField HeaderText="Rating" >
                    <ItemTemplate>
                        <asp:Label ID="lblRating" runat="server" Text='<%# Eval("Rating") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtRating" runat="server" Text='<%# Eval("Rating") %>' Width="140"></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                    
        </Columns>
       

    </asp:GridView>
    <div>
        <asp:Label runat="server" ID="labelSuccessDeleteMessage"></asp:Label>
    </div>






</asp:Content>

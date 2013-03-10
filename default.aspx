<%@ Page Title="" Language="VB" MasterPageFile="~/MasterPage.master" AutoEventWireup="false" CodeFile="default.aspx.vb" Inherits="_default" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="myContent" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">
    <div><b><asp:Literal ID="litPageTitle" runat="server" Text="<%$ Resources:PageTitle %>"></asp:Literal></b></div>
</asp:Content>


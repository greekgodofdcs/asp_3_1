<%@ Page Title="" Language="C#" MasterPageFile="~/adminHome.master" AutoEventWireup="true" CodeFile="listStudentbyBirthYear.aspx.cs" Inherits="listStudentbyBirthYear" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <div class="container">
        <div class="text-capitalize text-center bg-info text-white shadow p-3 rounded">
            <h2>List the students whose birth date is in specific year.</h2>
        </div>
        <div class="row  pt-3 mt-4">
            <div class="col-2">
                <asp:Label runat="server" CssClass="text-primary" Font-Size="X-Large" Text="Enter Year :" Font-Bold="True"></asp:Label>
            </div>
            <div class="col-5">
                    <asp:TextBox runat="server" ID="txtYear" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-3">
                <asp:Button Text="Search" runat="server" ID="btnSearch" CssClass="btn btn-outline-info" OnClick="btnSearch_Click" />
            </div>   
        </div>
        <div class="row mt-4">
            <asp:GridView ID="gvStud" CssClass="table" runat="server">
                <HeaderStyle CssClass="text-success text-capitalize bg-dark p-3 text-center" />
            </asp:GridView>
        </div>
    </div>
</asp:Content>


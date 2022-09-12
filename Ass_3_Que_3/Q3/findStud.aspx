<%@ Page Title="" Language="C#" MasterPageFile="~/adminHome.master" AutoEventWireup="true" CodeFile="findStud.aspx.cs" Inherits="findStud" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
        <div class="row text-capitalize text-center rounded shadow bg-primary text-white pt-4 pb-2">
            <h3>Find by name and if duplicate then ask for course.</h3>
        </div>
        <div class="row mt-5 ">
            <div class="col-2">
                <h3>Name :</h3>
            </div>
            <div class="col-3">
                <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-2">
                <asp:Label Text="Course:" CssClass="h3" ID="lblCourse" Visible="false" runat="server"></asp:Label>
            </div>
            <div class="col-3">
                <asp:DropDownList CssClass="form-control" Visible="false" runat="server" ID="ddlCourse"></asp:DropDownList>
            </div>
            <div class="col-2">
                <asp:Button  runat="server" CssClass="btn btn-info" text="Find" ID="btnFind" OnClick="btnFind_Click" />
            </div>
        </div>
        <div class="row m-2">
            <asp:GridView ID="gvstud" runat="server" CssClass="table table-hover table-responsive">
                <HeaderStyle CssClass="text-capitalize text-center bg-success text-white" />
            </asp:GridView>
        </div>
    </div>
</asp:Content>


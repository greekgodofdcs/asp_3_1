<%@ Page Title="" Language="C#" MasterPageFile="~/adminHome.master" AutoEventWireup="true" CodeFile="AddCourse.aspx.cs" Inherits="AddCourse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
        <center>
            <div class="row m-4">
                <div class="col-10 alert-heading  bg-secondary text-center text-white rounded shadow">
                    <h1 class="text-center">Add Course</h1>
                    <hr />
                </div>
            </div>
            <div class="row m-4">
                <h6><asp:Label ID="lblmsg" runat="server" Text=""></asp:Label></h6>
            </div>
            <div class="row m-4">
                <div class="col-3">
                    <h4>Course</h4>
                </div>
                <div class="col-4">
                    <asp:TextBox CssClass="form-control" runat="server" ID="txtClass"></asp:TextBox>
                </div>
                <div class="col-2">
                    <asp:Button runat="server" ID="btnAdd" CssClass="btn btn-outline-success col-10" text="Add" OnClick="btnAdd_Click"/>
                </div>
            </div>
        </center>
    </div>
</asp:Content>


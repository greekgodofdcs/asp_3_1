<%@ Page Title="" Language="C#" MasterPageFile="~/adminHome.master" AutoEventWireup="true" CodeFile="delStud.aspx.cs" Inherits="delStud" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container-fluid">
        <div class="row bg-danger text-white p-2 text-center text-capitalize shadow  rounded">
            <h2>Delete by roll no and course</h2>
        </div>
        <div class="row mt-4">
            <div class="col-2">
                <asp:Label runat="server" Text="Roll No." Font-Size="X-Large" Font-Bold="True" Font-Italic="True"></asp:Label>
            </div>
            <div class="col-2">
                <asp:TextBox runat="server" ID="txtRno" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-2">
                <asp:Label runat="server" Text="Course" Font-Size="X-Large" Font-Bold="true" Font-Italic="true"></asp:Label>
            </div>
            <div class="col-2">
                <asp:DropDownList ID="ddlCourse" runat="server" CssClass="form-control"></asp:DropDownList>
            </div>
            <div class="col-2">
                <asp:Button runat="server" CssClass="btn btn-danger" ID="btnDel" Text="Delete" OnClick="btnDel_Click" />
            </div>
        </div>
    </div>
</asp:Content>


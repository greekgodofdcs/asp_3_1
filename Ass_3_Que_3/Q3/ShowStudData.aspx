<%@ Page Title="" Language="C#" MasterPageFile="~/adminHome.master" AutoEventWireup="true" CodeFile="ShowStudData.aspx.cs" Inherits="ShowStudData" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
        <div class="row text-center bg-info shadow p-3 rounded-3 text-white">
            <h3>Student Data</h3>
        </div>
        <div class="row mt-5">
            <asp:GridView ID="gvStudDetail" CssClass="table text-center" runat="server" DataKeyNames="ernollno" 
                EmptyDataText ="Record Not found..." EmptyDataRowStyle-CssClass ="text-danger  text-center text-capitalize" OnRowEditing="gvStudDetail_RowEditing" OnRowDeleting="gvStudDetail_RowDeleting">
                <HeaderStyle CssClass="text-capitalize text-center" />
                <Columns>
                    <asp:CommandField HeaderText="Action" ShowEditButton="True" ControlStyle-CssClass="btn btn-outline-info " />
                    <asp:CommandField HeaderText="Action" ShowDeleteButton="true" EditText="Reject" ControlStyle-CssClass="btn btn-outline-danger "/>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>


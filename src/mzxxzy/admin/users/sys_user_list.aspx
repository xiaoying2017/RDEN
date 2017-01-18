<%@ Page Title="" Language="C#" MasterPageFile="~/master/_Admin.Master" AutoEventWireup="true" CodeBehind="sys_user_list.aspx.cs" Inherits="mzxxzy.admin.users.sys_user_list" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="tab" runat="server">
    <div class="tab" data-options="closable:true" title="用户列表">
        <table class="easyui-datagrid" data-options="fitColumns:true,striped:true,pagination:true,rownumbers:true,selected:true" id="tgList">
        </table>
    </div>

    <script src="/Content/js/sys_user_list.js"></script>
</asp:Content>

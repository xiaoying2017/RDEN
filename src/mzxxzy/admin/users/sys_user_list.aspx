<%@ Page Title="" Language="C#" MasterPageFile="~/master/_Admin.Master" AutoEventWireup="true" CodeBehind="sys_user_list.aspx.cs" Inherits="mzxxzy.admin.users.sys_user_list" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="tabs" runat="server">
    <div class="tab" title="用户列表">
        <table class="easyui-datagrid" data-options="fit:true">
            <thead>
		        <tr>
			        <th data-options="field:'id'">ID</th>
			        <th data-options="field:'name'">用户名</th>
			        <th data-options="field:'pwd'">密码</th>
		        </tr>
            </thead>
            <tbody></tbody>
        </table>
    </div>
    <div class="tab" title="添加用户" >

    </div>

    <script src="Content/js/sys_user_list.js"></script>
</asp:Content>

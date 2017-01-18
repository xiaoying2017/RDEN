<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="backstage.aspx.cs" Inherits="mzxxzy.admin.backstage" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>后台管理中心</title>
    <link rel="stylesheet" href="/admin/images/style.css" />
</head>
<body>
 <div class="easyui-window" title="Layout Window" icon="icon-help" style="width:500px;height:250px;padding:5px;background: #fafafa;">
		<div class="easyui-layout" fit="true">
			<div region="west" split="true" style="width:120px;">
				<ul class="easyui-tree">
					<li>
						<span>常规管理</span>
						<ul>
							<li><span>知识元管理</span></li>
							<li><span>我发布的资源</span></li>
							<li><span>资源评论</span></li>
							<li><span>回收站</span></li>
						</ul>
					</li>
				</ul>
			</div>
			<div region="center" border="false" border="false">
				<div class="easyui-tabs" fit="true">
					<div title="Home" style="padding:10px;">
						jQuery easyui framework help you build your web page easily.
					</div>
					<div title="Contacts">
						No contact data.
					</div>
				</div>
			</div>
			<div region="south" border="false" style="text-align:right;height:30px;line-height:30px;">
				<a class="easyui-linkbutton" icon="icon-ok" href="javascript:void(0)">Ok</a>
				<a class="easyui-linkbutton" icon="icon-cancel" href="javascript:void(0)">Cancel</a>
			</div>
		</div>
	</div>
<form method="post" action="./default.aspx" onsubmit="javascript:return WebForm_OnSubmit();" id="form1">
padding: 0 16rem;
</form>
</body>

</html>

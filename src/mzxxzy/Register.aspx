<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="mzxxzy.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   title>用户注册页面title>
</head>
 
<body>
<fieldset>
    <legend>用户的注册区域</legend>
<form method="post" action="">
   < table border="1" bordercolor="#0099ff" cellpadding="10px" cellspacing="0">
        <tr>
            th colspan="3">注册页面th>
       <tr>
        <tr>
            <td>用户名：</td>
            <td>
                input  type="text" name="name" value="--请输入用户名--"/>
            </td>
            <td>font color="#FF0000">*不能以数字、下划线开头font></td>
        </tr>
        </tr>
            <td>密码：</td>
            <td>
                input type="password" nam="pwd" />
            </td>
            <td>font color="#FF0000">*数字和字母的组合font></td>
       <tr>
        <tr>
            <td>确认密码：</td>
            <td>
                input type="password" nam="pwd" />
            </td>
            <td>font color="#FF0000">*重新输入上面的密码font></td>
        </tr>
        </tr>
            <td>性别：</td>
            <td>
                input type="radio" name="sex" value="nan" checked="checked"/>Man
                input type="radio" name="sex" value="nv" />Woman
            </td>
            <td>font color="#FF0000">*要慎重选择font></td>

    </form>
</body>
</html>

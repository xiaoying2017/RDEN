<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="mzxxzy.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>少数民族文化信息资源管理 用户登录</title>
    <link href="css/login.css" rel="stylesheet" type="text/css" />
    <link href="/WebResource.axd?d=VmD7Q-_3rpybVJxq3sC0EH_0wkXNxG7OeVBlY_a02Uynb7LxdKLbQnK4SxNbLw1xRbWIjWSHYX8cyCrJmGZ2oDCybhDooP09yc48Xd0VJNTaiRBDPAdC_a_RsrMW5rFO1xmgB5UuIRCxJ72_7WG9JF8TClQAfpRe4fpaYL2Yc8U1&amp;t=635226662440000000" type="text/css" rel="stylesheet" />

    <script src="Content/lib/jquery-1.10.2.min.js"></script>
    <script src="Content/lib/layer/layer.js"></script>
    <script src="Content/js/login.js"></script>
</head>
<body>
    <div id="login">
        <div id="login_header">
            <div class="login_logo">
                <span id="LabelTitle" style="font-family: 黑体; font-size: 24px;">少数民族文化信息资源管理系统 用户登录</span>
            </div>
            <div class="login_headerContent">
                <div class="navList">
                    <ul>
                        <li><a href="#">设为首页</a></li>
                        <li><a href="/">返回首页</a></li>
                    </ul>
                </div>
                <h2 class="login_title">
                    <img src="/Content/images/login_title.png" /></h2>
            </div>
        </div>
        <div id="login_content">
            <div class="loginForm">
                <p>
                    <label>用户名：</label>
                    <input name="userid" type="text" maxlength="30" id="userid" class="login_input" />
                    <span id="RequiredFieldValidatoruserid" style="color: Red; display: none;"></span>                   
                </p>
                <p>
                    <label>密码：</label>
                    <input name="pwd" type="password" maxlength="30" id="pwd" class="login_input" />
                    <span id="RequiredFieldValidatorpwd" style="color: Red; display: none;"></span>
                </p>
                <p>
                    <label>验证码：</label>
                    <input name="vcode" type="text" maxlength="4" id="vcode" class="code" size="5" />
                    <span>
                        <img style="cursor: pointer" id="vdimgck" onclick="this.src=this.src+'?'" alt="看不清？点击更换"
                            align="absMiddle" src="/include/vcode.aspx" height="20" width="70" /></span>
                    <span id="RequiredFieldValidatorvcode" style="color: Red; display: none;"></span>
                </p>
                <div class="login_bar">
                    <input id="btnLogin" type="button" name="ButtonLogin" value="登录" />&nbsp;
                </div>
            </div>
            <div class="login_banner">
                <img src="/Content/images/login_banner.jpg" />
            </div>
            <div class="login_main">
                <ul class="helpList">
                </ul>
                <div class="login_inner">
                </div>
            </div>
        </div>
        <div id="login_footer">
        </div>
    </div>
</body>
</html>
$(function () {
    $("#btnLogin").on("click", function () {
        var $vcode = $("#vcode");
        if (!$vcode || $vcode.val() === "") {
            $vcode.focus();
            $vcode.next().next().text("验证码不能为空！");
            layer.msg("验证码不能为空！", { icon: 2 });
            return;
        }

        var $usr = $("#userid");
        if (!$usr || $usr.val() === "") {
            $usr.focus();
            $usr.next().text("用户名不能为空！");
            layer.msg("用户名不能为空！", { icon: 2 });
            return;
        }

        var $pwd = $("#pwd");
        if (!$pwd || $pwd.val() === "") {
            $pwd.focus();
            $pwd.next().text("密码不能为空！");
            layer.msg("密码不能为空！", { icon: 2 });
            return;
        }

        $.ajax({
            type: "post",
            url: "/tools/submit_ajax.ashx?action=user_login",
            data: { "username": $usr.val(), "password": $pwd.val(), "vcode": $vcode.val() },
            async: false,
            success: function (data) {
                if (data.status !== "success") {
                    layer.msg(data.msg, { icon: 0 });
                    return;
                }
                layer.msg(data.msg, { icon: 1 });
                window.location.href ="/master/_Layout.Master";
            }
        });
    });
});
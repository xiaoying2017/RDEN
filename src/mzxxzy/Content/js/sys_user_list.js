$(function () {
    var $dg = $("#tgList");
    $dg.datagrid({
        url: "/tools/admin_ajax.ashx?action=user_list",
        columns: [[
            { field: "ck", checkbox: true },
            { field: "id", title: "标识", align: "center", width: 10 },
            { field: "name", title: "用户名", align: "center", width: 40 },
            { field: "pwd", title: "密码", align: "center", width: 30 },
            { field: "tel", title: "联系方式", align: "center", width: 20 },
            { field: "date", title: "出生日期", align: "center", width: 20 }
        ]]
    });

    var $pager = $dg.datagrid("getPager");
    $pager.pagination({
        onSelectPage: function (pageNumber, pageSize) {
            $dg.datagrid("reload", "/tools/admin_ajax.ashx?action=user_list&pageIndex=" + pageNumber + "&pageSize=" + pageSize);
        },
        onRefresh: function (pageNumber, pageSize) {
            // $dg.datagrid("reload", "/tools/admin_ajax.ashx?action=user_list&pageIndex=" + pageNumber + "&pageSize=" + pageSize);
        }
    });
});
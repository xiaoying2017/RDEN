$(function () {
    $.ajax({
        type: "get",
        url: "/tools/submit_ajax.ashx?action=user_list&page=1&pageSize=10",
        success: function (data) {
            if (data.total == 0) return;
            var str = "";
            $.each(data.list, function (i, obj) {
                str += "<tr><td>" + obj.user_id + "</td>";
                str += "</tr>";
            });
            $("table tbody").append(str);
        }
    });
});
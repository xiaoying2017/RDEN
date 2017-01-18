$(function(){
	$(".theme li").on("click", function() {
		var bg = $(this).css("background-color");
		setTheme(bg);
	});
	$(".theme li").eq(0).trigger("click");

	$(".easyui-tree").tree({
	    lines: true,
	    animate: true,
	    onClick: function (node) {
	        $("#tabs").tabs("add", {
	            title: node.text,
	            href: "/admin/users/sys_user_list.html",
	            closable: true,
                selected: true
	        });
	        $.messager.alert("系统提示", node.text, "info");
	    }
	});
});

function setTheme(color) {
	$("#sys_header").css("background-color", color);
	$("#footer").css("background-color", color);
}
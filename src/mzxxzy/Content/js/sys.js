$(function(){
	$(".theme li").on("click", function() {
		var bg = $(this).css("background-color");
		setTheme(bg);
	});
	$(".theme li").eq(0).trigger("click");
});

function setTheme(color) {
	$("#sys_header").css("background-color", color);
	$("#footer").css("background-color", color);
}
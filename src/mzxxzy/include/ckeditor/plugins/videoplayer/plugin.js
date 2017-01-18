CKEDITOR.plugins.add('videoPlayer',
{
    init: function (editor) {
        //plugin code goes here
        var pluginName = 'videoPlayer';
        CKEDITOR.dialog.add(pluginName, this.path + 'dialogs/videoPlayer.js');
        editor.addCommand(pluginName, new CKEDITOR.dialogCommand(pluginName));
        
        editor.ui.addButton('videoPlayer',
        {
            label: '插入视频',
            command: pluginName
        });
    }
});

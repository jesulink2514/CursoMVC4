$(document).ready(function () {
    $("ul.speakers a").click(function (e) {
        e.preventDefault();

        $(".selected-speaker").hide().html('');
        $("#indicator").show();

        var url = $(this).attr('href');

        $.getJSON(url, null, function (speaker) {
            $("#indicator").hide();

            $("#speakerTemplate")
                .tmpl(speaker)
                .appendTo('.selected-speaker');

            $('.selected-speaker').show();
        });
    });
});
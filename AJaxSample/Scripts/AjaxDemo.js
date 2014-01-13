$(document).ready(function () {
    $('#privacyLink').click(function (event) {
        event.preventDefault();
        var url = $(this).attr('href');
        $('#privacy').load(url);
    });

    $('#commentForm').submit(function (event) {
        event.preventDefault();
        var data = $(this).serialize();
        var url = $(this).attr('action');

        $.post(url, data, function (response) {
            $('#comments').append(response);
        });

    });
});
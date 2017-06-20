$(document).ready(function () {
    ListReviews();
});

function saveReview() {
    var params = {
        productId: $('#productId').val(),
        comment: $('#comment').val(),
        rating: $('#rating').val()
    }
    $.ajax({
        type: "POST",
        contentType: "application/json; charset=utf-8",
        url: '/ProductReview/Add',
        data: JSON.stringify(params),
        dataType: "JSON",
        success: function (result) {
            if (result) {
                alert('review successifuly added');
                $('#comment').val('');
                $('#rating').val('');
                $('#reviewTable tr:last').after('<tr><td>' + params.comment + '</td><td>' + params.rating + '</td></tr>')
            }
        },
        error: function () {
            alert(error);
        },
    });
}

function ListReviews() {
    var productId = $('#productId').val();
    $.ajax({
        type: "Get",
        contentType: "application/json",
        url: "/ProductReview/getReviews/" + productId,
        dataType: "JSON",
        success: function (result) {
            result.forEach(function (element) {
                $('#reviewTable tr:last').after('<tr><td>' + element.comment + '</td><td>' + element.rating + '</td></tr>');
            }, this);
        },
        error: function () {
            alert(error);
        },
    });
}

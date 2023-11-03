// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    // Login butonuna tıklama işlemi
    $(".btn.btn-outline-warning").click(function () {
        // Partial Page'i yükleme işlemi
        $("#login-partial-container").load("/Shared/_LoginPartial");
    });
});
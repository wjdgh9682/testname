﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function () {

    if ($("a.DeletionConfirm").length) {
        $("a.DeletionConfirm").click(() => {
            if (!confirm("Deletion confirmed?")) return false;
        })
    }

    if ($("div.alert.notification").length) {
        setTimeout(() => {
            $("div.alert.notification").fadeOut();
        }, 2000);
    }

});
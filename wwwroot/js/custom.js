$(document).ready(function () {
    // Handle click on paging links
    $('.tm-paging-link').click(function (e) {
        e.preventDefault();
        indexBilgisi = ($('.tm-paging-link').index(this))
        //var page = $(this).text().toLowerCase();
        $('.tm-gallery-page').addClass('hidden');
        $('.tm-gallery-page:eq(' + indexBilgisi+')').removeClass('hidden');
        $('.tm-paging-link').removeClass('active');
        $(this).addClass("active");
    });
});